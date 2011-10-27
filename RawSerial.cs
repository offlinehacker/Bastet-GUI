using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using NUnit.Framework;
using System.Runtime.InteropServices; //For Sequential structure layout
using log4net;

namespace TROL_MgmtGui2
{

    class SerialBase : LinkLayer
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(SerialBase));

        protected const Int32 ReadTimeout = 30000; //1000 1 second
        protected const Int32 WriteTimeout = 30000; //1000 1 second
        protected const Int32 BaudRate = 9600;

        protected SerialPort sp = new SerialPort();
        protected Queue<Packet> packets = new Queue<Packet>();
        protected volatile Boolean shutdownThread;
        protected volatile Boolean ackReceived = true;

        protected Thread serThread;

        /// <summary>
        /// Returns list of all serial ports available.
        /// </summary>
        /// <returns>List of all serial ports avalible.</returns>
        public override static String[] GetAvailablePorts()
        {
            String[] ports= SerialPort.GetPortNames();
            log.Debug("Serial ports: " + ports.ToString());
            return ports;
        }

        /// <summary>
        /// Opens serial port and starts working thread.
        /// </summary>
        /// <param name="PortName">Name of the port gatherd by GetAvailablePorts.</param>
        public override bool Open(String PortName)
        {
            if (PortName == null)
            {
                log.Warn("Port name not defined");
                return false;
            }

            log.Debug("Opening serial port with name: " + PortName);
            sp = new SerialPort(PortName, BaudRate, Parity.None, 8, StopBits.One);
            try
            {
                sp.Open();
            }
            catch(Exception e)
            {
                log.Error("Cannot open serial port!", e);
                return false;
            }

            log.Debug("Serial port succesfully opened.");

            sp.ReadTimeout = ReadTimeout;
            sp.WriteTimeout = WriteTimeout;
            //sp.NewLine = "\n";

            log.Debug("Creating communication thread");
            serThread = new Thread(serialThread);
            serThread.Name = "Serial communication thread";
            serThread.Start();
            log.Debug("Communication thread created and started");

            return true;
        }

        /// <summary>
        /// Close the thread.
        /// </summary>
        public override void Close()
        {
            log.Debug("Closing communication thread");
            shutdownThread = true;
            if (sp.IsOpen && serThread != null)
                serThread.Join();
            log.Debug("Commuication thread closed");

            log.Debug("Closing serial port");
            sp.Close();
            log.Debug("Serial port closed");
        }

        /// <summary>
        /// Writes data to serial port (adds a packet to the queue).
        /// For every message sent, device need to send back acknowledge command,
        /// otherwise thread will send only one message.
        /// </summary>
        /// <param name="Data">Data to be sent.</param>
        public override void Write(Packet Packet)
        {
            if (!sp.IsOpen)
            {
                log.Warn("Serial port is not opened");
                return;
            }

            log.Debug("Creating new BPPacket");

            lock (packets)
            {
                log.Debug("Putting packet to the queue");
                packets.Enqueue(Packet);
                Monitor.Pulse(packets);
            }
        }

        protected virtual void serialThread(){}
    }
}
