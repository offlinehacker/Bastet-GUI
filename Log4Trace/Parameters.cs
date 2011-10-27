using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Log4Trace
{
    class Parameters
    {
        private Dictionary<string, string> cEntries= new Dictionary<string,string>();

        public Dictionary<string, string> Entries { get { return cEntries; } }

        public string GenerateParametersString()
        {
            string lValue = "";

            if (cEntries.Count == 0)
                return "";
            foreach (KeyValuePair<string, string> lEntry in cEntries)
            {
                lValue += lEntry.Key + "=" + lEntry.Value + "&";
            }

            return lValue.Remove(lValue.Length - 1);
        }

        public Parameters(string parse)
        {
            foreach (string KeyValue in parse.Split(new char[] { '&' }))
            {
                string[] splited = KeyValue.Split(new char[] { '=' });
                if (splited.Length < 2)
                    continue;

                cEntries.Add(splited[0], splited[1]);
            }
        }

        public Parameters(){}
    }

    [TestFixture, Description("Tests parameters class")]
    class ParametersTest
    {
        [TestCase, Description("Tests generation to string")]
        public static void TestGenerating()
        {
            Parameters tParameters = new Parameters();
            tParameters.Entries.Add("key1", "value1");
            tParameters.Entries.Add("key2", "value2");

            Assert.AreEqual("key1=value1&key2=value2",tParameters.GenerateParametersString());
        }

        [TestCase, Description("Tests parsing")]
        public static void TestParsing()
        {
            Parameters tCompare = new Parameters();
            tCompare.Entries.Add("key1", "value1");
            tCompare.Entries.Add("key2", "value2");

            Parameters tWith= new Parameters("key1=value1&key2=value2");
            tWith.ToString();

            Assert.AreEqual(tWith.Entries["key1"], tCompare.Entries["key1"]);
            Assert.AreEqual(tWith.Entries["key2"], tCompare.Entries["key2"]);
        }
    }
}
