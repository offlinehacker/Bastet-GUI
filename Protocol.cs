using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Runtime.InteropServices; //For Sequential structure layout

namespace TROL_MgmtGui2
{
    /// <summary>
    /// Base header of protocol above link layer.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    class ProtocolHeader{}

    class Packet { }

    /// <summary>
    /// Layer above LinkLayer, used for data handling.
    /// </summary>
    class ProtocolLayer
    {
        /// <summary>
        /// Serializer for static header data.
        /// </summary>
        public BinarySerializer cHeaderSerializer = new BinarySerializer();
        protected LinkLayer cLinkLayer;

        public void SetStaticSerializer(BinarySerializer lStaticSerializer)
        {
            cHeaderSerializer= lStaticSerializer;
        }

        /// <summary>
        /// Sets class for handling link layer.
        /// </summary>
        /// <param name="lLinkLayer"></param>
        public void SetLinkLayer(LinkLayer lLinkLayer)
        {
            cLinkLayer = lLinkLayer;
            cLinkLayer.SetReceiveHandler(new DataReceivedDelegate(LinkLayerCallback));
        }

        public virtual void SerializeData( ref MemoryStream StreamToWrite, object[] DataToSerialize )
        {
            Byte[] tdata = cHeaderSerializer.SerializeData(DataToSerialize);
            StreamToWrite.Write(tdata,0,tdata.Count());
        }

        /// <summary>
        /// Gets called when new data packet is received.
        /// </summary>
        /// <param name="data">Received data</param>
        public virtual void LinkLayerCallback(LinkLayerHeader lLinkLayerHeader){}
    }

    /// <summary>
    /// Base LinkLayer header class.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    class LinkLayerHeader
    {
        /// <summary>
        /// Gets data that is inside LinkLayer
        /// </summary>
        /// <returns>Link layer data</returns>
        public virtual Byte[] GetData() { return null; }
        /// <summary>
        /// Gets LinkId if Link layer has support for different devices.
        /// </summary>
        /// <returns></returns>
        public virtual Byte GetLinkId() { return 0; }
    }

    /// <summary>
    /// Delegate called when received message from device.
    /// </summary>
    /// <param name="Data">Received data.</param>
    delegate void DataReceivedDelegate(LinkLayerHeader lLinkLayerHeader);

    /// <summary>
    /// Class for handling link-layer communication.
    /// </summary>
    class LinkLayer
    {
        /// <summary>
        /// Called when received a message from device.
        /// </summary>
        protected DataReceivedDelegate cDataReceivedDelegate;

        /// <summary>
        /// Returns list of all serial ports available.
        /// </summary>
        /// <returns>List of all serial ports avalible.</returns>
        public virtual String[] GetAvailablePorts() { return null; }
        /// <summary>
        /// Opens link layer.
        /// </summary>
        /// <param name="PortName">Name of the port gatherd by GetAvailablePorts.</param>
        public virtual bool Open(String PortName) { return false; }
        /// <summary>
        /// Closes link layer.
        /// </summary>
        public virtual void Close() { }
        /// <summary>
        /// Writes data to link layer.
        /// </summary>
        /// <param name="LinkId">Adress of the device.</param>
        /// <param name="ProtocolHeader">Protocol header. </param>
        /// <param name="ProtocolHedareData">Data of protocol header.</param>
        /// <param name="Data">Data</param>
        public virtual void Write(Packet Packet) { }

        /// <summary>
        /// Sets callback delegate for handling received data.
        /// </summary>
        /// <param name="lDataReceivedDelegate">Callback delegate.</param>
        public void SetReceiveHandler(DataReceivedDelegate lDataReceivedDelegate)
        {
            cDataReceivedDelegate = lDataReceivedDelegate;
        }
    }
}
