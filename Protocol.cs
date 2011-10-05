using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TROL_MgmtGui2
{
    class ProtocolLayer
    {
        /// <summary>
        /// Serializer for static header data.
        /// </summary>
        protected BinarySerializer cHeaderSerializer = new BinarySerializer();
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
        public virtual void LinkLayerCallback(Byte[] data, ref object ProcessedData, ref int DataOffset)
        {
            ProcessedData = cHeaderSerializer.DeserializeData(data, DataOffset, ref DataOffset);
        }
    }

    /// <summary>
    /// Delegate called when received message from device.
    /// </summary>
    /// <param name="Data">Received data.</param>
    public delegate void DataReceivedDelegate(Byte[] Data, ref object ProcessedData, ref int DataOffset);

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
        /// <param name="Data">Data to be written.</param>
        public virtual void Write(int LinkId, Byte[] Data) { }
        /// <summary>
        /// Signal the thread that device acknowledged previous message.
        /// </summary>
        public virtual void AckReceived() { }
        /// <summary>
        /// Info about acknowlegement of previous message
        /// </summary>
        public virtual bool IsAckReceived() { return false; }

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
