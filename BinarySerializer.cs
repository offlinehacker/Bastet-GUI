using System;
using System.Reflection;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;
using NUnit.Framework;
using log4net;
using Log4Trace;

namespace TROL_MgmtGui2
{
    class VarByte{}
    class VarUInt16{}
    class VarUInt32{}

    /// <summary>
    /// Class for serializing and deserializing binary data based on input types.
    /// </summary>
    class BinarySerializer
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(BinarySerializer));
        private Type[] cSerializableTypes = new Type[] { };

        public BinarySerializer() { }

        public BinarySerializer(Type[] lSerializableTypes)
        {
            cSerializableTypes = lSerializableTypes;
            if(log.IsDebugEnabled) log.DebugFormat("Created binary serializer for types "+ GetTypeNames());
        }

        /// <summary>
        /// Sets instruction how to serialize based on types.
        /// </summary>
        /// <param name="lSerializableTypes">List of types for sequential serialization.</param>
        public void SetSerializableTypes(Type[] lSerializableTypes)
        {
            if(log.IsDebugEnabled) log.DebugFormat("Changing serializer types from "+ GetTypeNames()+ " to "+ lSerializableTypes);
            cSerializableTypes = lSerializableTypes;
        }

        /// <summary>
        /// Gets string representation of type names
        /// </summary>
        /// <returns>string representation of type names</returns>
        private string GetTypeNames()
        {
            string type_names= "";
            foreach(Type t in cSerializableTypes)
                type_names+= t.Name+ ",";

            return type_names;
        }

        /// <summary>
        /// Gets length of serialized data, if that can be determined.
        /// </summary>
        /// <param name="startType">Index of start type.</param>
        /// <param name="endType">Index of end type.</param>
        /// <returns>Length of data to be serilized.</returns>
        public int GetSerializedDataLength(int startType=0, int endType=0)
        {
            if (endType == 0)
                endType = cSerializableTypes.Count();

            //Check the bounds of start and end.
            if (startType > cSerializableTypes.Count() - 1 || endType > cSerializableTypes.Count())
            {
                log.Error("Indexes out of range");
                return -1;
            }

            int len = 0;
            Type CurrentType;
            for (int x = startType; x < endType; x++)
            {
                CurrentType = cSerializableTypes[x];
                try
                {
                    len += Marshal.SizeOf(CurrentType);
                }
                catch (Exception e)
                {
                    log.Error("Cannot marshal type " + CurrentType.Name);
                    return -1;
                }

                log.Debug("Type is " + cSerializableTypes[x].Name + " and length is" + len);
            }

            return len;
        }

        /// <summary>
        /// Serializes passed objects.
        /// </summary>
        /// <param name="lSerializableData">Data you want to serialize as <see cref="object[]"/></param>
        /// <returns>Serialized data as <see cref="Byte[]"/></returns>
        public virtual Byte[] SerializeData(object lSerializableData)
        {
            object[] lOutputData = (object[])lSerializableData;
            MemoryStream lStream = new MemoryStream();
            uint ManyParse = 0;

            if (lOutputData.Count() > 0)
                log.Debug("Serializing type " + cSerializableTypes[0]);

            //Allways returns something, it it up to user to verify that data is correrect
            //Counter for types-x is controled by user, since we can initialize many parse.
            for (int x = 0,y = 0; y < lOutputData.Count() && x<cSerializableTypes.Count(); y++ )
            {
                if (ManyParse > 0)
                    ManyParse--;

                object data = lOutputData[y];
                Type CurrentType = cSerializableTypes[x];
                switch (CurrentType.Name)//Switch for many parse, dont ever have two many parses in serial!
                {
                    case "VarByte":
                        ManyParse = (uint)Convert.ChangeType(data,typeof(uint));
                        x++;
                        CurrentType = typeof(Byte);
                        break;//Go to next export round
                    case "VarUInt16":
                        ManyParse = (uint)Convert.ChangeType(data,typeof(uint));
                        x++;
                        CurrentType = typeof(UInt16);
                        break;//Go to next export round
                    case "VarUInt32":
                        ManyParse = (uint)Convert.ChangeType(data,typeof(uint));
                        x++;
                        CurrentType = typeof(UInt32);
                        break;//Go to next export round
                }
                switch (CurrentType.Name)
                {
                    case "String":
                        byte[] StringByte = StringToByteArray(data);
                        if (StringByte == null)
                        {
                            log.Error("Problems while serializing to String type.");
                            return null;
                        }
                        lStream.Write(StringByte, 0, StringByte.Count());
                        break;
                    case "Byte[]":
                        Byte[] DataByte= (Byte[])data;
                        if(data==null)
                        {
                            log.Error("Problems while serializing to Byte[] type");
                            return null;
                        }
                        lStream.Write(DataByte, 0, DataByte.Length);
                        break;
                    default:
                        object ConvertedData = Convert.ChangeType(data, CurrentType);
                        if (ConvertedData == null) 
                        {
                            log.Error("Problems while serializing to unknown type");
                            return null;
                        }
                        lStream.Write(StructureToByteArray(ConvertedData), 0, StructureToByteArray(ConvertedData).Count());
                        break;
                }

                if (ManyParse == 0)
                {
                    x++;
                    if(cSerializableTypes.Count()>x+1)
                        log.Debug("Serializing type " + cSerializableTypes[x]);
                }
            }

            log.Debug("Serialized "+ lStream.Length + " of data.");
            return lStream.ToArray();
        }

        /// <summary>
        /// Deserializes passed binary data.
        /// </summary>
        /// <param name="lInputData"><see cref="Byte[]"/> of data you want to serialize.</param>
        /// <param name="InitalOffset">Offset where you want to start serialization as <see cref="int"/></param>
        /// <param name="NewOffset"Offset where serialization ended as <see cref="int"/></param>
        /// <returns>Serialized objects as <see cref="object[]"/></returns>
        public virtual object[] DeserializeData(Byte[] lInputData, int InitalOffset, ref int NewOffset, int startType = 0, int endType = 0)
        {
            int offset = InitalOffset;
            List<object> OutputStructures = new List<object>();
            int loffset = 0;
            uint ManyParse = 0;
            bool ManyParseCondition = false;

            if (endType == 0)
                endType = cSerializableTypes.Count();

            //Check the bounds of start and end.
            if (startType > cSerializableTypes.Count() - 1 || endType > cSerializableTypes.Count())
                return null;

            for (int x = startType; x < endType; )
            {
                Type CurrentType = cSerializableTypes[x];
                if (offset >= lInputData.Count())
                {
                    log.Error("Offset is bigger than data count");
                    return null;
                }

                switch (CurrentType.Name)
                {
                    case "VarByte":
                        ManyParseCondition = true;
                        CurrentType = typeof(Byte);
                        break;//Go to next export round
                    case "VarUInt16":
                        ManyParseCondition = true;
                        CurrentType = typeof(UInt16);
                        break;//Go to next export round
                    case "VarUInt32":
                        ManyParseCondition = true;
                        CurrentType = typeof(UInt32);
                        break;//Go to next export round
                }
                switch (CurrentType.Name)
                {
                    case "String":
                        string strdata = ByteArrayToString(lInputData.Skip(offset).ToArray());
                        if (strdata == null)
                        {
                            log.Error("Problems while deserializing to String");
                            return null;
                        }
                        OutputStructures.Add(strdata);
                        loffset = strdata.Length + 1;
                        break;
                    case "Byte[]":
                        Byte[] bytedata = lInputData.Skip(offset).ToArray();
                        OutputStructures.Add(bytedata);
                        loffset = bytedata.Length;
                        break;
                    default:
                        //We must get size or we get error.
                        object result = ByteArrayToStructure(lInputData.Skip(offset).ToArray(), CurrentType, ref loffset);
                        if (result == null)
                        {
                            List<Type> t= new List<Type>();
                            foreach (System.Reflection.FieldInfo prop in CurrentType.GetFields())
                                t.Add(prop.FieldType);

                            object[] allData= (new BinarySerializer(t.ToArray())).DeserializeData(lInputData.Skip(offset).ToArray(), loffset, ref loffset);
                            int m=0;
                            object o = Activator.CreateInstance(CurrentType);
                            foreach (System.Reflection.FieldInfo prop in CurrentType.GetFields())
                            {
                                prop.SetValue(o, allData[m]);
                                m++;
                            }
                            log.Error("Problems while deserializing to unkown type");
                            return null;
                        }
                        OutputStructures.Add(result);
                        break;
                }
                
                offset += loffset;
                loffset = 0;

                if (ManyParseCondition)
                {
                    ManyParse = (uint)Convert.ChangeType(OutputStructures.Last(), typeof(uint));
                    ManyParseCondition = false;
                    x++;
                }
                else
                {
                    if (ManyParse > 1)
                        ManyParse--;
                    else
                        x++;
                }
            }

            NewOffset = offset;
            log.Debug("Deserialized "+ OutputStructures.Count+ " elements with types; "+ GetStringTypes(OutputStructures.ToArray()));
            return OutputStructures.ToArray();
        }

        /// <summary>
        /// Gets string representation of types from objects.
        /// </summary>
        /// <param name="objs">List of objects.</param>
        /// <returns>String representation of types</returns>
        private string GetStringTypes( object[] objs )
        {
            string ret= "";
            foreach(object obj in objs)
            {
                ret+= obj.GetType().Name+", ";
            }

            return ret;
        }

        static byte[] StringToByteArray(object obj)
        {
            try
            {
                System.Text.ASCIIEncoding AsciEncoding = new System.Text.ASCIIEncoding();
                byte[] output = AsciEncoding.GetBytes((string)obj);
                List<byte> tmp = new List<byte>(output);
                tmp.Add(0);
                return tmp.ToArray();
            }
            catch { return null; }
        }

        static string ByteArrayToString(Byte[] arr)
        {
            try
            {
                IntPtr dst = Marshal.AllocHGlobal(arr.Length);
                Marshal.Copy(arr, 0, dst, arr.Length);
                string output = Marshal.PtrToStringAnsi(dst);
                Marshal.FreeHGlobal(dst);
                return output;
            }
            catch { return null; }
        }

        static byte[] StructureToByteArray(object obj)
        {
            try
            {
                int len = Marshal.SizeOf(obj);
                byte[] arr = new byte[len];
                IntPtr ptr = Marshal.AllocHGlobal(len);
                Marshal.StructureToPtr(obj, ptr, true);
                Marshal.Copy(ptr, arr, 0, len);
                Marshal.FreeHGlobal(ptr);
                return arr;
            }
            catch { return null; }
        }

        static object ByteArrayToStructure(byte[] bytearray, Type CreatingType, ref int offset)
        {
            try
            {
                int len = Marshal.SizeOf(CreatingType);
                IntPtr i = Marshal.AllocHGlobal(len);
                Marshal.Copy(bytearray, 0, i, len);
                object obj = Marshal.PtrToStructure(i, CreatingType);
                Marshal.FreeHGlobal(i);
                if (offset != -1)
                    offset = len;
                return obj;
            }
            catch{ return null; }
        }
    }

    class DatasetRowSerializer : BinarySerializer
    {
        private int cStartColumnOffset = 0;
        private int cEndColumnOffset = 0;

        public DatasetRowSerializer(DataTable table, int lStartColumnOffset, int lEndColumnOffset)
        {
            cStartColumnOffset = lStartColumnOffset;
            cEndColumnOffset = lEndColumnOffset;
            SetSerializableTypes(table);
        }

        public override Byte[] SerializeData(object lOutputData)
        {
            object[] tOutputData = (object[])lOutputData;
            object[] lRowData = ((DataRow)tOutputData[0]).ItemArray;
            List<object> lSerializableData = new List<object>();
            for (int x = cStartColumnOffset; x < lRowData.Count() - cEndColumnOffset; x++)
            {
                lSerializableData.Add(lRowData[x]);
            }
            return base.SerializeData(lSerializableData.ToArray());
        }

        public void SetSerializableTypes(DataTable table)
        {
            List<Type> lSerializableTypes = new List<Type>();
            for (int x = cStartColumnOffset; x < table.Columns.Count - cEndColumnOffset; x++)
            {
                lSerializableTypes.Add(table.Columns[x].DataType);
            }

            base.SetSerializableTypes(lSerializableTypes.ToArray());
        }

        public void SetColumnOffsets(int lStartColumnOffset, int lEndColumnOffset)
        {
            cStartColumnOffset = lStartColumnOffset;
            cEndColumnOffset = lEndColumnOffset;
        }
    }

    [TestFixture(Description = "Tests BinarySerializer")]
    class BinarySerializerTest
    {
        [TestCase(Description = "Tests if output data for simple number serialization is correct")]
        public void TestBasicExportSerialization()
        {
            BinarySerializer serializer = new BinarySerializer(new Type[] { typeof(UInt16) });
            Byte[] output = serializer.SerializeData(new object[] { 1 });
            Assert.AreEqual(GetBinaryString(output), "0000000000000001");
        }

        [TestCase(Description = "Tests if output data for medium conversions are correct, we asume basic test works.")]
        public void TestMediumExportSerialization()
        {
            BinarySerializer serializer = new BinarySerializer();

            serializer.SetSerializableTypes(new Type[] { typeof(UInt16), typeof(UInt32) });
            Byte[] output = serializer.SerializeData(new object[] { 1, 100000 });
            string CompareData = GetBinaryString(SumByteArrays(GetData(1, typeof(UInt16)), GetData(100000, typeof(UInt32))));
            Assert.AreEqual(GetBinaryString(output), CompareData);

            serializer.SetSerializableTypes(new Type[] { typeof(string) });
            output = serializer.SerializeData(new object[] { "abcd" });
            Assert.AreEqual(new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', 0 }, output);

            serializer.SetSerializableTypes(new Type[] { typeof(string), typeof(Int16), typeof(UInt32), typeof(Int16), typeof(string) });
            output = serializer.SerializeData(new object[] { "abcd", 100, 100000, 900, "defghi" });
            CompareData = GetBinaryString(SumByteArrays(new byte[] { (byte)'a', (byte)'b', (byte)'c', (byte)'d', 0 }, GetData(100, typeof(Int16)), GetData(100000, typeof(Int32)), GetData(900, typeof(Int16)), new byte[] { (byte)'d', (byte)'e', (byte)'f', (byte)'g', (byte)'h', (byte)'i', 0 }));
            Assert.AreEqual(GetBinaryString(output), CompareData);
        }

        [TestCase(Description = "Tests if basic serialization import works, we asume serialization export works")]
        public void TestBasicImport()
        {
            int offset = 0;
            BinarySerializer serializer = new BinarySerializer(new Type[] { typeof(UInt16) });
            Byte[] export = serializer.SerializeData(new object[] { 1 });
            object[] import = serializer.DeserializeData(export,0,ref offset);

            Assert.AreEqual(new object[] { (UInt16)1 }, import);
            Assert.AreEqual(2, offset);
        }

        [TestCase(Description = "Tests if medium serialization import works, we asume serialization export works")]
        public void TestMediumImport()
        {
            int offset = 0;
            BinarySerializer serializer = new BinarySerializer();
            serializer.SetSerializableTypes(new Type[] { typeof(string), typeof(Int16), typeof(UInt32), typeof(Int16), typeof(string) });
            Byte[] export = serializer.SerializeData(new object[] { "abcd", 100, 100000, 900, "defghi" });
            object[] import = serializer.DeserializeData(export,0,ref offset);

            Assert.AreEqual(new object[] { "abcd", (UInt16)100, (UInt32)100000, (UInt16)900, "defghi" }, import, "defghi");
            Assert.AreEqual(20, offset);
        }

        [TestCase(Description = "Tests if serializing byte structures works.")]
        public void TestByteSerialize()
        {
            int offset = 0;
            BinarySerializer serializer = new BinarySerializer();
            serializer.SetSerializableTypes(new Type[] { typeof(Byte[]) });

            Byte[] input = new Byte[] { 1, 2, 3, 4, 5 };
            Byte[] export = serializer.SerializeData(new object[] { input });

            object[] import = serializer.DeserializeData(export, 0, ref offset);
            Assert.AreEqual(input, import[0]);
        }

        [TestCase(Description = "Tests many parse")]
        public void TestManyParse()
        {
            BinarySerializer serializer = new BinarySerializer();
            serializer.SetSerializableTypes(new Type[] { typeof(VarByte), typeof(UInt16) });
            object[] TestData= new object[]{ 5, 1, 2, 3, 4, 5 };

            Byte[] export = serializer.SerializeData(TestData);
            int offset=0;
            object[] import = serializer.DeserializeData(export, 0, ref offset);

            Assert.AreEqual(TestData, import);

            serializer.SetSerializableTypes(new Type[] { typeof(VarUInt32), typeof(string), typeof(Int16), typeof(VarUInt16), typeof(Byte) });
            TestData = new object[] { 5, "a", "b", "c", "d", "e", 10, 3, 1, 2, 3 };
            export = serializer.SerializeData(TestData);
            offset = 0;
            import = serializer.DeserializeData(export, 0, ref offset);

            Assert.AreEqual(TestData, import);
        }

        [StructLayout(LayoutKind.Sequential)]
        class test1
        {
            public int a1;
            public int a2;
        }

        [StructLayout(LayoutKind.Sequential)]
        class test2: test1
        {
            public int a3;
            public int a4;
        }

        [TestCase(Description = "Tests paring of classes")]
        public void TestClassParse()
        {
            BinarySerializer serializer = new BinarySerializer(new Type[] { typeof(test2) });
            test2 t2= new test2();
            t2.a1=1;
            t2.a2=2;
            t2.a3=3;
            t2.a4=4;

            int off = 0;
            byte[] serData= serializer.SerializeData(new object[] { t2 });
            test2 desData = (test2)serializer.DeserializeData(serData, 0, ref off)[0];

            Assert.AreEqual(t2.a1, desData.a1);
            Assert.AreEqual(t2.a2, desData.a2);
            Assert.AreEqual(t2.a3, desData.a3);
            Assert.AreEqual(t2.a4, desData.a4);
        }

        public static Byte[] SumByteArrays(params Byte[][] array)
        {
            List<Byte> sum = new List<Byte>();
            foreach (Byte[] param in array)
                sum.AddRange(param);
            return sum.ToArray();
        }

        public static Byte[] GetData(object data, Type type)
        {
            BinarySerializer serializer = new BinarySerializer(new Type[] { type });
            Byte[] output = serializer.SerializeData(new object[] { data });
            return output;
        }

        public static string GetBinaryString(Byte[] data)
        {
            string output = "";
            foreach (byte lByte in data.Reverse())
            {
                char[] b = new char[8];
                int pos = 7;
                int i = 0;

                while (i < 8)
                {
                    if ((lByte & (1 << i)) != 0)
                    {
                        b[pos] = '1';
                    }
                    else
                    {
                        b[pos] = '0';
                    }
                    pos--;
                    i++;
                }

                output += new string(b);
            }
            return output;
        }

    }
}
