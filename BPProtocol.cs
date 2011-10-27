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
using log4net;

namespace TROL_MgmtGui2
{
    delegate void ProcessReceivedData(string OperationName, BPProtocolHeader lProtocolHeader, Byte lLinkId, object[] DeserializedData);

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

    class BPPacket : Packet
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BPPacket));

        public int LinkId;
        public BPProtocolHeader BPProtocolHeader;
        public byte[] BPProtocolHeaderData;
        public byte[] Data;
        public int ExpectedLength;

        public BPPacket(int LinkId, BPProtocolHeader BPProtocolHeader, byte[] BPProtocolHeaderData, byte[] Data, int ExpectedLength)
        {
            log.Debug("New packet with destination: " + LinkId.ToString() + " and data: " + Data.ToString());

            this.LinkId = (byte)LinkId;
            this.BPProtocolHeader = BPProtocolHeader;
            this.BPProtocolHeaderData = BPProtocolHeaderData;
            this.Data = Data;
            this.ExpectedLength = ExpectedLength;
        }
    }
    
    [StructLayout(LayoutKind.Sequential)]
    class BPProtocolHeader : ProtocolHeader
    {
        public Byte cOperationId;

        public BPProtocolHeader(Byte lOperationId)
        {
            cOperationId = lOperationId;
        }

        public BPProtocolHeader(){}
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
            BPProtocolHeader lBPProtocolHeader= new BPProtocolHeader((byte)lOperation.cSendCode);
            base.SerializeData(ref StreamToWrite, new object[] {lBPProtocolHeader});

            int ExpectedLength= lOperation.cDownlinkSerializer.GetSerializedDataLength();

            //It allows us to send only a command if data is not set.
            Byte[] SerializedData = new Byte[0];
            if (data != null && lOperation.cUplinkSerializer!=null)
            {
                SerializedData = lOperation.cUplinkSerializer.SerializeData(data);
                StreamToWrite.Write(SerializedData, 0, SerializedData.Count());
            }

            cLinkLayer.Write(new BPPacket( LinkId, lBPProtocolHeader, StreamToWrite.ToArray(), SerializedData, ExpectedLength);
        }

        /// <summary>
        /// Gets called when new data packet is received.
        /// </summary>
        /// <param name="data">Received data</param>
        public override void LinkLayerCallback(LinkLayerHeader lLinkLayerHeader)
        {
            int offset = 0;

            //Deserialize ProtocolLayer header.
            BPProtocolHeader lProtocolHeader = (BPProtocolHeader)cHeaderSerializer.DeserializeData(lLinkLayerHeader.GetData(), 0, ref offset)[0];

            //Try to find operation by using id in ProtocolHeader
            BPOperation lOperation;
            try
            {
                lOperation = (from o in cOperations where o.cRecvCode == lProtocolHeader.cOperationId select o).First();
            }
            catch 
            { return; }

            //If we have DownlinkSerializer, then we deserialize data inside.
            object[] DeserializedData = null;
            if (lOperation.cDownlinkSerializer != null)
            {
                DeserializedData = lOperation.cDownlinkSerializer.DeserializeData(lLinkLayerHeader.GetData(), offset, ref offset);
                if (DeserializedData == null) return;
            }

            //End of deserialization

            //If we have callback routine call it.
            if (lOperation.cCallbackDelegate != null)
                lOperation.cCallbackDelegate(lOperation.cOperationName, lProtocolHeader, lLinkLayerHeader.GetLinkId(), DeserializedData);
        }
    }

    [TestFixture(Description="BPPProtocol tests.")]
    class BPProtocolTest
    {
        private static BPProtocol protocol = new BPProtocol();
        private bool calledCorrectly= false;
        private static BinarySerializer cUplinkSerializer= new BinarySerializer(new Type[] { typeof(string), typeof(Byte[]) });
        private static BinarySerializer cDownlinkSerializer= new BinarySerializer(new Type[] { typeof(UInt16) });

        class DummyLinkLayer: LinkLayer
        {
            public LinkLayerHeader lastLinkLayer = null;

            public override void Write(int LinkId, Byte[] Data)
            {
                //Assert.AreEqual(LinkId, 0);

                int of2 = 0;
                object[] deserializedData1= protocol.cHeaderSerializer.DeserializeData(Data, 0, ref of2);

                object[] deserializedData2= cUplinkSerializer.DeserializeData(Data, of2, ref of2);
                Assert.AreEqual(0, deserializedData1[0]);
                Assert.AreEqual("teststring", deserializedData2[0]);
                Assert.AreEqual(new Byte[]{1,2,3,4}, deserializedData2[1]);
            }
        }
        private DummyLinkLayer lDummyLinkLayer = new DummyLinkLayer();

        public BPProtocolTest()
        {
            protocol.SetLinkLayer(lDummyLinkLayer);
        }

        [Test(Description="Test operation calls")]
        public void TestOperations()
        {
            protocol.AddOperation(new BPOperation("test", 0, 0,
                cUplinkSerializer,
                cDownlinkSerializer,
                new ProcessReceivedData(Callback1)                                ) 
                );

            protocol.CallOperation(10, "test", new object[]{"teststring", new Byte[]{1,2,3,4}} );
        }

        private void Callback1(string OperationName, BPProtocolHeader lProtocolHeader, Byte lLinkId, object[] DeserializedData)
        {
        }
    }
}
