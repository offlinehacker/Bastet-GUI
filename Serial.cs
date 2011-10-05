using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using NUnit.Framework;

namespace TROL_MgmtGui2
{
    class Packet
    {
        private Byte[] data;
        public Byte[] Data
        {
            get { return data; }
        }

        public Packet(Byte[] Data)
        {
            data = Data;
        }
    }

    /// <summary>
    /// Class for handling serial connections.
    /// </summary>
    class Serial: LinkLayer
    {
        private const Int32 ReadTimeout = 30000; //1000 1 second
        private const Int32 WriteTimeout = 30000; //1000 1 second
        private const Int32 BaudRate = 9600;

        private SerialPort sp= new SerialPort();
        private Boolean shutdownThread;
        private Queue<Packet> packets = new Queue<Packet>();
        private volatile Boolean ackReceived = true;

        Thread serThread;

        /// <summary>
        /// Returns list of all serial ports available.
        /// </summary>
        /// <returns>List of all serial ports avalible.</returns>
        public override String[] GetAvailablePorts()
        {
            return SerialPort.GetPortNames();
        }

        /// <summary>
        /// Opens serial port and starts working thread.
        /// </summary>
        /// <param name="PortName">Name of the port gatherd by GetAvailablePorts.</param>
        public override bool Open(String PortName)
        {
            if (PortName == null)
                return false;

            sp = new SerialPort(PortName, BaudRate, Parity.None, 8, StopBits.One);
            try
            {
                sp.Open();
            }
            catch { return false; }

            sp.ReadTimeout = ReadTimeout;
            sp.WriteTimeout = WriteTimeout;
            //sp.NewLine = "\n";

            serThread = new Thread(serialThread);
            serThread.Name = "Serial communication thread";
            serThread.Start();

            return true;
        }

        /// <summary>
        /// Close the thread.
        /// </summary>
        public override void Close()
        {
            shutdownThread = true;
            if(sp.IsOpen && serThread!=null)
                serThread.Join();
            sp.Close();
        }

        /// <summary>
        /// Writes data to serial port (adds a packet to the queue).
        /// For every message sent, device need to send back acknowledge command,
        /// otherwise thread will send only one message.
        /// </summary>
        /// <param name="Data">Data to be sent.</param>
        public override void Write(Byte[] Data)
        {
            if (!sp.IsOpen)
                return;

            Packet pckt = new Packet(Data);

            lock (packets)
            {
                packets.Enqueue(pckt);
                Monitor.Pulse(packets);
            }
        }

        /// <summary>
        /// Signal the thread that device acknowledged previous message.
        /// </summary>
        public override void AckReceived()
        {
            ackReceived = true;
        }

        /// <summary>
        /// Info about acknowlegement of previous message
        /// </summary>
        public override bool IsAckReceived()
        {
            return ackReceived == true;
        }
        
        public void TestCallback()
        {
            object tmp=null;
            int tmp2=0;
            cDataReceivedDelegate(null, ref tmp, ref tmp2);
        }

        public void TestCallback2()
        {
            object tmp = null;
            int tmp2 = 0;
            cDataReceivedDelegate(BinarySerializerTest.SumByteArrays(BinarySerializerTest.GetData(100, typeof(Byte)),BinarySerializerTest.GetData(0, typeof(Byte)),BinarySerializerTest.GetData(10, typeof(UInt16)),BinarySerializerTest.GetData(20, typeof(UInt32))), ref tmp, ref tmp2);
        }


        #region serialThread
        private void serialThread()
        {
            Packet pckt;
            Byte[] txBuf = new Byte[80];

            Byte[] rxBuf = new Byte[80];
            Int32 rxBufNum = 0; // index in rxBug
            Int32 rxMsgLen = 0; // Expected receive msg len
            bool rxFirstByte = true; // Expecting first byte of rx message


            while (true)
            {
                // Do we need to shutdown the thread?
                if ((shutdownThread == true) &&
                    (packets.Count == 0))
                {
                    try
                    {
                        sp.Close();
                    }
                    catch { }
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
                      lock (packets)
                        pckt = packets.Dequeue();
                      //sp.Write(pckt.Data, 0, pckt.Data.Length);
                      //sp.Write("\n");
                      txBuf[0] = (byte)pckt.Data.Length;
                      Buffer.BlockCopy(pckt.Data, 0, txBuf, 1, pckt.Data.Length);
                      sp.Write(txBuf, 0, pckt.Data.Length+1);

                      rxBufNum = 0;
                      rxFirstByte = true;
                      rxMsgLen = 0; 
                      ackReceived = false;
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
                  do
                  {
                    Int32 b = sp.ReadByte();
                    if (rxFirstByte)
                    {
                      rxMsgLen = b;
                      rxFirstByte = false;
                    }
                    else
                    {
                      rxBuf[rxBufNum++] = (Byte)b;
                      if (rxBufNum >= rxBuf.Length)
                        throw new Exception("Buffer size for incoming data too small!");
                      if (rxBufNum == rxMsgLen)
                      {
                        Byte[] data = new Byte[rxBufNum];
                        Buffer.BlockCopy(rxBuf, 0, data, 0, rxBufNum);
                        rxBufNum = 0;
                        rxFirstByte = true;
                        // report the message
                        if (cDataReceivedDelegate != null)
                        {
                            object tmp = null;
                            int tmp2 = 0;
                            cDataReceivedDelegate(data, ref tmp, ref tmp2);
                        }
                      }
                    }
#if false

                    if (b == (Byte)'\n')
                    {
                      Byte[] data = new Byte[rxBufNum];
                      Buffer.BlockCopy(rxBuf, 0, data, 0, rxBufNum);

                      rxBufNum = 0;

                      // report the message
                      if (PacketReceived != null)
                          PacketReceived(data);
                    }
                    else
                    {
                      rxBuf[rxBufNum++] = (Byte)b;

                      if (rxBufNum >= rxBuf.Length)
                          throw new Exception("Buffer size for incoming data too small!");
                    }
#endif
                  } while (sp.BytesToRead != 0);
                }                
            }
        }
        #endregion
    }

    [TestFixture(Description = "Tests if correct callback is called")]
    class LinkLayerCallbackTest
    {
        int r = 0;
        [TestCase]
        public void Test()
        {
            Serial sr = new Serial();
            LinkLayer ll = (LinkLayer)sr;
            ll.SetReceiveHandler(new DataReceivedDelegate(testc));
            try
            {
                sr.TestCallback();
            }
            catch
            {
                Assert.Fail("Callback not set!");
            }

            Assert.AreEqual(1, r);
        }

        public void testc(Byte[] data, ref object test, ref int DataOffset)
        {
            r = 1;
        }
    }
}
