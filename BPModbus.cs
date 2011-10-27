using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using NUnit.Framework;
using Modbus.Device;
using log4net;

namespace TROL_MgmtGui2
{

    class BPPacketModbus : BPPacket{ }

    /// <summary>
    /// Class for handling serial connections.
    /// </summary>
    class BPModbus : SerialBase
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BPModbus));
        IModbusSerialMaster master;

        /// <summary>
        /// Serializer for static header data.
        /// </summary>
        protected BinarySerializer cHeaderSerializer = new BinarySerializer();

        public BPModbus()
        {
            //We need only layer 2, since modbus takes care of everything else.
            cHeaderSerializer.SetSerializableTypes(new Type[] { typeof(BPPacketL2) });
        }
        /// <summary>
        /// Signal the thread that device acknowledged previous message.
        /// </summary>
        public override void AckReceived()
        {
            ackReceived = true;
        }

        #region serialThread
        protected override void serialThread()
        {
            BPPacketModbus pckt;

            Byte[] txBuf= new Byte[0];

            if (cDataReceivedDelegate == null)
                throw new Exception("ReceiveDelegate not set!");

            log.Debug("Creating modbus protocol.");
            master = ModbusSerialMaster.CreateRtu(sp);

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

                if (packets.Count != 0)
                {
                    log.Debug("New packet on queue to send");
                    lock (packets)
                    {
                        pckt = (BPPacketModbus)packets.Dequeue();
                        if(pckt.Data.Length>0)
                            txBuf = cHeaderSerializer.SerializeData(new object[] { pckt.Data });
                    }

                    try
                    {
                        if (pckt.Data.Length > 0)
                        {
                            log.Debug("Writing packet to modbus");
                            master.WriteMultipleRegisters((byte)100, 
                                (ushort)GenAddress((Byte)pckt.LinkId, 
                                    (Byte)pckt.BPProtocolHeader.cOperationId), 
                                CreateRegisters(txBuf));
                        }
                        else
                        {
                            log.Debug("Reading packet from modbus");
                            master.ReadInputRegisters((byte)100,
                                (ushort)GenAddress((Byte)pckt.LinkId,
                                    (Byte)pckt.BPProtocolHeader.cOperationId),
                                (ushort)pckt.ExpectedLength);
                        }
                    }
                    catch (TimeoutException e)
                    {
                        log.Error("Timeout while writing packet to serial bus", e);
                    }
                    catch (Exception e)
                    {
                        log.Error("Problem writing packet to serial bus, closing serial port and communication thread", e);
                        sp.Close();
                        return;
                    }

                    log.Debug("Resetting state variables");
                    txBuf = new Byte[0];
                }

                // We don't want to hog up whole CPU
                Thread.Sleep(100);
            }
        }
        #endregion

        private ushort[] CreateRegisters( Byte[] data )
        {
            ushort[] nums= new ushort[data.Length/2+1];
            for(int x=0;x<data.Length;x++)
                if (x % 2 != 0)
                    nums[x / 2] = System.BitConverter.ToUInt16(data, x - 1);

            return nums;
        }

        private ushort GenAddress(Byte LinkId, Byte OperationId)
        {
            return System.BitConverter.ToUInt16(new byte[]{LinkId,OperationId} , 0);
        }
    }
}
