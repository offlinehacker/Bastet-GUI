using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using NUnit.Framework;
using Modbus.Device;

namespace TROL_MgmtGui2
{
    /// <summary>
    /// Class for handling modbus connections over serial bus.
    /// </summary>
    class ModbusSer : SerialBase
    {
        /// <summary>
        /// Handler for modbus protocol.
        /// </summary>
        private IModbusSerialMaster cModbusSerialMaster;

        /// <summary>
        /// Opens serial port, registers it with modbus handler and starts working thread.
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

            cModbusSerialMaster = ModbusSerialMaster.CreateRtu(sp);

            serThread = new Thread(serialThread);
            serThread.Name = "Serial communication thread";
            serThread.Start();

            return true;
        }

            

        #region serialThread
        private override void serialThread()
        {
            BPPacket pckt;
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

                if (packets.Count != 0)
                {
                    lock (packets)
                    pckt = packets.Dequeue();
                    //sp.Write(pckt.Data, 0, pckt.Data.Length);
                    //sp.Write("\n");
                    txBuf[0] = (byte)pckt.Data.Length;
                    Buffer.BlockCopy(pckt.Data, 0, txBuf, 1, pckt.Data.Length);
                    cModbusSerialMaster.WriteMultipleRegisters(pckt.

                    rxBufNum = 0;
                    rxFirstByte = true;
                    rxMsgLen = 0; 
                    ackReceived = false;
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
            ModbusSer sr = new ModbusSer();
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
