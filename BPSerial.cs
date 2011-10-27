using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.InteropServices; //For Sequential structure layout
using log4net;

namespace TROL_MgmtGui2
{
    /// <summary>
    /// Layer 1 on link layer. 
    /// <remarks>
    /// We must split, because we want to know the size, before serializing anything else.
    /// </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    class BPPacketL1
    {
        public Byte DataSize; //Data size is used needed for raw serial protocol.

        public BPPacketL1(Byte DataSize)
        {
            this.DataSize = DataSize;
        }
    }

    /// <summary>
    /// Layer 2 on link layer. 
    /// <remarks>
    /// We must split, because we want to know the size, before serializing anything else.
    /// </remarks>
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    class BPPacketL2 : LinkLayerHeader
    {
        public Byte LinkId;
        public Byte[] Data;

        public override Byte[] GetData() { return Data; }
        public override Byte GetLinkId() { return LinkId; }

        public BPPacketL2(Byte LinkId, Byte[] Data)
        {
            this.LinkId = LinkId;
            this.Data = Data;
        }
    }

    /// <summary>
    /// This class holds data that is passed from protocol layer to link layer.
    /// </summary>
    class BPPacketSerial : BPPacket
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BPPacketSerial));

        public BPPacketL1 L1
        {
            get{ return new BPPacketL1((byte)(this.Data.Length + this.BPProtocolHeaderData.Length)); }
        }

        public BPPacketL2 L2
        {
            get { return new BPPacketL2((byte)this.LinkId, Util.Combine(Data, BPProtocolHeaderData)); }
        }
    }

    /// <summary>
    /// Class for handling serial connections.
    /// </summary>
    class BPSerial : SerialBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BPSerial));

        /// <summary>
        /// Serializer for static header data.
        /// </summary>
        protected BinarySerializer cHeaderSerializer = new BinarySerializer();

        public BPSerial()
        {
            cHeaderSerializer.SetSerializableTypes(new Type[] { typeof(BPPacketL1), typeof(BPPacketL2) });
        }
        /// <summary>
        /// Signal the thread that device acknowledged previous message.
        /// </summary>
        public void AckReceived()
        {
            ackReceived = true;
        }

        /// <summary>
        /// Info about acknowlegement of previous message
        /// </summary>
        public bool IsAckReceived()
        {
            return ackReceived == true;
        }

        #region serialThread
        protected override void serialThread()
        {
            BPPacketSerial pckt;

            Byte[] rxBuf = new Byte[80];
            Byte[] txBuf;
            int rxBufNum = 0; // index in rxBuf used for byte per byte receiving
            int serializerOffset = 0; // Offset for data serialization.
            bool rxReadHeader = true; // Expecting first byte of rx message
            bool recevied = false; //Flag to speciffic if packet was received

            BPPacketL1 lBPPacketL1 = null;
            BPPacketL2 lBPPacketL2 = null;
            int lL1HeaderLen = cHeaderSerializer.GetSerializedDataLength(0, 1);
            log.Debug("L1 header length is: " + lL1HeaderLen.ToString());

            if (cDataReceivedDelegate == null)
                throw new Exception("ReceiveDelegate not set!");

            log.Debug("Starting infinite receiving loop");
            while (true)
            {
                // Do we need to shutdown the thread?
                if ((shutdownThread == true) &&
                    (packets.Count == 0))
                {
                    log.Debug("Communication thread shutdown");
                    try
                    {
                        sp.Close();
                    }
                    catch (Exception e)
                    {
                        log.Error("Problem closing serial port", e);
                    }
                    return;
                }

                // We can send a new packet via serial, only when a device
                // on the other end of the line acknowledges the previous packet.
                // Anyone who listens for event PacketReceived must call the function
                // AckReceived to signal this thread that device acknowledged previous msg.
                if (ackReceived == true)
                {
                    if (packets.Count != 0)
                    {
                        log.Debug("New packet on queue to send");
                        lock (packets)
                        {
                            pckt = (BPPacketSerial)packets.Dequeue();
                            //sp.Write(pckt.Data, 0, pckt.Data.Length);
                            //sp.Write("\n");
                            txBuf = cHeaderSerializer.SerializeData(new object[] { pckt.L1, pckt.L2 });
                        }

                        log.Debug("Writing packet to serial bus");
                        try
                        {
                            sp.Write(txBuf, 0, txBuf.Length + 1);
                        }
                        catch (Exception e)
                        {
                            log.Error("Problem writing packet to serial bus, closing serial port and communication thread", e);
                            sp.Close();
                            return;
                        }

                        log.Debug("Resetting state variables");
                        rxBufNum = 0;
                        serializerOffset = 0;
                        rxReadHeader = true;
                        ackReceived = false;
                        lBPPacketL1 = null;
                        lBPPacketL2 = null;
                    }
                }

                // We don't want to hog up whole CPU
                Thread.Sleep(100);


                // Let's try to read any incoming Data.
                if (sp.BytesToRead == 0)
                {
                    Thread.Sleep(100);
                    continue;
                }
                else
                {
                    log.Debug("New data avalible on serial port, starting receiving BPPacketL1");
                    do
                    {
                        //Read byte by byte and process.
                        rxBuf[rxBufNum++] = (Byte)sp.ReadByte();

                        if (rxReadHeader)
                        {
                            if (rxBufNum + 1 == lL1HeaderLen)
                            {
                                log.Debug("BPPacketL1 received");

                                //Deserialize Layer1 of Link layer.
                                lBPPacketL1 = (BPPacketL1)cHeaderSerializer.DeserializeData(rxBuf, 0, ref serializerOffset, 0, 1)[0];
                                log.Debug("Data size is: " + lBPPacketL1.DataSize);
                                log.Debug("Starting receiving BPPacketL2");
                            }
                            rxReadHeader = false;
                        }
                        else
                        {
                            if (rxBufNum >= rxBuf.Length)
                                throw new Exception("Buffer size for incoming data too small!");
                            if (rxBufNum == lBPPacketL1.DataSize)
                            {
                                log.Debug("BPPacketL2 received");
                                lBPPacketL2 = (BPPacketL2)cHeaderSerializer.DeserializeData(rxBuf, serializerOffset, ref serializerOffset, 1, 2)[0];

                                log.Debug("Calling receive delegate");

                                // report the message
                                cDataReceivedDelegate(lBPPacketL2);

                                recevied = false;
                            }
                        }
                    } while (sp.BytesToRead != 0);
                    log.Debug("No more data to read");

                    if (recevied == false)
                        log.Debug("Packet succesfully received.");
                    else
                        log.Warn("Packet not fully received.");

                    log.Debug("Resetting state variables");
                    rxBufNum = 0;
                    serializerOffset = 0;
                    rxReadHeader = true;
                    recevied = false;
                    lBPPacketL1 = null;
                    lBPPacketL2 = null;
                }
            }
        }
        #endregion
    }
}
