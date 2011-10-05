using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices; //For Sequential structure layout
using System.Data;
using NUnit.Framework;

namespace TROL_MgmtGui2
{
    delegate void ProcessReceivedData(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData);

    class BPOperation
    {
        public string cOperationName;
        public int cRecvCode;
        public int cSendCode;
        public BinarySerializer cUplinkSerializer;
        public BinarySerializer cDownlinkSerializer;
        public ProcessReceivedData cCallbackDelegate;
        public string[] cOperationGroups;

        public BPOperation(string lOperationName, int lRecvCode, int lSendCode, BinarySerializer lUplinkSerializer, BinarySerializer lDownlinkSerializer, ProcessReceivedData lCallbackDelegate, string[] lOperationGroups=null)
        {
            cOperationName = lOperationName;
            cRecvCode = lRecvCode;
            cSendCode = lSendCode;
            cUplinkSerializer = lUplinkSerializer;
            cDownlinkSerializer = lDownlinkSerializer;
            cCallbackDelegate = lCallbackDelegate;
            cOperationGroups = lOperationGroups;
        }
    }
    
    [StructLayout(LayoutKind.Sequential)]
    struct BPProtocolHeader
    {
        public Byte cOperationId;

        public BPProtocolHeader(Byte lOperationId)
        {
            cOperationId = lOperationId;
        }
    }

    class BPProtocol: ProtocolLayer
    {
        private List<BPOperation> cOperations = new List<BPOperation>();

        public BPProtocol()
        {
            cHeaderSerializer.SetSerializableTypes(new Type[] { typeof(BPProtocolHeader) });
        }

        public void AddOperation(BPOperation lOperation)
        {
            if ((from n in cOperations where n.cOperationName == lOperation.cOperationName select n).Count() != 0)
                return;
            cOperations.Add(lOperation);
        }

        public void CallGroupOperations(int LinkId, string GroupName)
        {
            BPOperation[] Operations = (from n in cOperations where n.cOperationGroups!=null && n.cOperationGroups.Contains(GroupName) select n).ToArray<BPOperation>();
            if (Operations.Count() == 0)
                return;
            foreach (BPOperation operation in Operations)
                CallOperation(LinkId, operation.cOperationName);
            return;
        }

        public void CallOperation(int LinkId, string OperationName, object[] data=null)
        {
            MemoryStream StreamToWrite= new MemoryStream();
            BPOperation lOperation;
            try
            {
                lOperation = (from o in cOperations where o.cOperationName == OperationName select o).First();
            }
            catch { return; }

            if (lOperation.cSendCode == -1)
                return;

            //Serializes header data.
            base.SerializeData(ref StreamToWrite, new object[] {new BPProtocolHeader((byte)lOperation.cSendCode)});

            //It allows us to send only a command if data is not set.
            if (data != null && lOperation.cUplinkSerializer!=null)
            {
                Byte[] SerializedData = lOperation.cUplinkSerializer.SerializeData(data);
                StreamToWrite.Write(SerializedData, 0, SerializedData.Count());
            }

            cLinkLayer.Write(LinkId, StreamToWrite.ToArray());
        }

        /// <summary>
        /// Gets called when new data packet is received.
        /// </summary>
        /// <param name="data">Received data</param>
        public override void LinkLayerCallback(Byte[] data, ref object ProcessedData, ref int DataOffset)
        {
            base.LinkLayerCallback(data, ref ProcessedData, ref DataOffset);
            BPProtocolHeader lProtocolHeader = (BPProtocolHeader)((object[])ProcessedData)[0];

            BPOperation lOperation;
            try
            {
                lOperation = (from o in cOperations where o.cRecvCode == lProtocolHeader.cOperationId select o).First();
            }
            catch 
            { return; }

            object[] DeserializedData = null;
            if (lOperation.cDownlinkSerializer != null)
            {
                DeserializedData = lOperation.cDownlinkSerializer.DeserializeData(data, DataOffset, ref DataOffset);
                if (DeserializedData == null) return;
            }

            if (lOperation.cCallbackDelegate != null)
                lOperation.cCallbackDelegate(lOperation.cOperationName, lProtocolHeader, DeserializedData);
        }
    }

    [TestFixture]
    class TestBPProtocolOffline
    {
        bool called = false;
        [TestCase]
        public void SimpleTest()
        {
            RawSerial sr = new RawSerial();
            BPProtocol bp = new BPProtocol();
            bp.SetLinkLayer(sr);
            bp.AddOperation(new BPOperation("test", 0, 1, new BinarySerializer(new Type[] { typeof(UInt16), typeof(UInt32) }), new BinarySerializer(new Type[] { typeof(UInt16), typeof(UInt32) }), new ProcessReceivedData(DataLayerRecvCallback)));
            bp.CallOperation(0, "test", new object[] { 100, 200 });
            sr.TestCallback2();
            Assert.AreEqual(called, true);
        }

        public void DataLayerRecvCallback(string OperationName, BPProtocolHeader lProtocolHeader, object[] DeserializedData)
        {
            called = true;
            Assert.AreEqual(lProtocolHeader, new BPProtocolHeader(100,0));
            Assert.AreEqual(DeserializedData, new object[] { 10, 20 });
        }
    }
}
