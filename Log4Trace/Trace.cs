using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace Log4Trace
{
   /// <summary>
    /// Class for tacing of execution.
    /// </summary>
    /// <remarks>
    /// This class is thread safe since log4net takes care of tread safety.
    /// </remarks>
    public class Trace
    {
        /// <summary>
        /// Name of tracer.
        /// </summary>
        private string cName;

        /// <summary>
        /// Unique id of tracer.
        /// </summary>
        private int cTraceId;

        /// <summary>
        /// Stack representing trace path.
        /// </summary>
        private Stack<string> cTraceStack= new Stack<string>();

        /// <summary>
        /// Tells if trace is over(because of mistake or because we end trace)
        /// </summary>
        /// <remarks>
        /// We use that, so we can remove trace from log4net.
        /// Once this field is true, data in this class is
        /// </remarks>
        private bool cTraceEnd = false;

        /// <summary>
        /// Enters trace entry.
        /// </summary>
        /// <param name="name">Name of entry.</param>
        public void TraceEnter( string name )
        {
            cTraceStack.Push(name);
        }

        /// <summary>
        /// Leaves trace entry.
        /// </summary>
        /// <returns>False if stack is empty.</returns>
        public bool TraceLeave()
        {
            try
            {
                cTraceStack.Pop();
            }
            catch (InvalidOperationException e)
            {
                //Remove trace on wrong operation.
                cTraceEnd = true;
                return false;
            }

            return true;
        }

        private string StackToString()
        {
            if (cTraceStack.Count == 0)
                return "";

            string value = "";
            foreach (string StackEntry in cTraceStack.Reverse<string>())
            {
                value += StackEntry+".";
            }

            return value.Remove(value.Length-1);
        }

        public override string ToString()
        {
            Parameters cParameters = new Parameters();
            if (!cTraceEnd)
            {
                cParameters.Entries.Add("Path", StackToString());
                cParameters.Entries.Add("Id", cTraceId.ToString());
            }
            else
            {
                //If trace is over we should not get new parameters, so we indicate an error.
                cParameters.Entries.Add("Path", "Trace_error");
                cParameters.Entries.Add("Id", cTraceId.ToString());
            }

            return cParameters.GenerateParametersString();
        }

        /// <summary>
        /// Goes to trace destroy state of operation.
        /// </summary>
        /// <returns></returns>
        public void TraceDestroy()
        {
            cTraceEnd = true;
        }

        public bool IsTraceOver()
        {
            return cTraceEnd;
        }

        /// <summary>
        /// Initializes new tracer.
        /// </summary>
        /// <param name="TraceName">Name of tracer.</param>
        public Trace(string TraceName)
        {
            Random rnd= new Random();
            cName = TraceName;
            cTraceId = rnd.Next(int.MaxValue);
        }
    }

    [TestFixture, Description("Tests trace class")]
    class TraceTest
    {
        [TestCase]
        public static void Test()
        {
            Trace tTrace = new Trace("TestniTrace");
            tTrace.TraceEnter("objekt1");
            tTrace.TraceEnter("objekt2");
            tTrace.TraceEnter("objekt3");
            Assert.AreEqual("Path=objekt1.objekt2.objekt3", tTrace.ToString());
            tTrace.TraceLeave();
            Assert.AreEqual("Path=objekt1.objekt2",tTrace.ToString());
            tTrace.TraceLeave();
            Assert.AreEqual("Path=objekt1",tTrace.ToString());
            tTrace.TraceEnter("objekt4");
            Assert.AreEqual("Path=objekt1.objekt4", tTrace.ToString());
            tTrace.TraceLeave();
            tTrace.TraceLeave();
            tTrace.TraceLeave();
            Assert.AreEqual("Path=Trace_error", tTrace.ToString());
            tTrace.TraceEnter("objekt5");
            Assert.AreEqual("Path=Trace_error", tTrace.ToString());
        }
    }
}
