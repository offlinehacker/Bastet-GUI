using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PostSharp.Aspects;
using log4net;
using log4net.Config;
using NUnit.Framework;

namespace Log4Trace
{
    /// <summary>
    /// Creates a new trace.
    /// </summary>
    /// <remarks>
    /// We must only use this attribute with functions!!!
    /// </remarks>
    [Serializable]
    public class TraceEnterAttribute: OnMethodBoundaryAspect
    {
        private string cTraceName;

        /// <summary>
        /// Constructor of TraceEnter attribute
        /// </summary>
        /// <param name="lTraceName">Name of trace</param>
        /// <remarks>
        /// We should not create trace here because this is not the thread which will be used druing real execution.
        /// </remarks>
        public TraceEnterAttribute(string lTraceName)
        {
            cTraceName = lTraceName;
        }

        /// <summary>
        /// On entry we create new trace.
        /// </summary>
        /// <param name="args">MethodExecutionArgs</param>
        public override void OnEntry(MethodExecutionArgs args)
        {
            ThreadContext.Properties["Trace_" + cTraceName] = new Trace(cTraceName);
            //Trace.WriteLine(string.Format("Entering {0}.{1}.",
            //    args.Method.DeclaringType.Name, args.Method.Name), this.category);
        }

        /// <summary>
        /// On exit we remove trace.
        /// </summary>
        /// <param name="args">MethodExecutionArgs</param>
        public override void OnExit(MethodExecutionArgs args)
        {
            if(ThreadContext.Properties["Trace_" + cTraceName]!=null)
                ThreadContext.Properties.Remove("Trace_" + cTraceName); 
           // Trace.WriteLine(string.Format("Leaving {0}.{1}.",
            //    args.Method.DeclaringType.Name, args.Method.Name), this.category);
        }
    }

    [Serializable]
    public class TraceAttribute : OnMethodBoundaryAspect
    {
        private string cTraceName;
        private string cTraceEntry;

        /// <summary>
        /// Constructor of TraceEnter attribute
        /// </summary>
        /// <param name="lTraceName">Name of trace</param>
        /// <remarks>
        /// We should not create trace here because this is not the thread which will be used druing real execution.
        /// </remarks>
        public TraceAttribute(string lTraceName, string lTraceEntry)
        {
            cTraceName = lTraceName;
            cTraceEntry = lTraceEntry;
        }

        /// <summary>
        /// On entry we enter into trace.
        /// </summary>
        /// <param name="args">MethodExecutionArgs</param>
        public override void OnEntry(MethodExecutionArgs args)
        {
            if (ThreadContext.Properties["Trace_" + cTraceName] != null)
            {
                Trace tTrace = (Trace)ThreadContext.Properties["Trace_" + cTraceName];
                if (tTrace.IsTraceOver())
                {
                    ThreadContext.Properties.Remove("Trace_" + cTraceName);
                }
                else
                {
                    tTrace.TraceEnter(cTraceEntry);
                }
            }
            //Trace.WriteLine(string.Format("Entering {0}.{1}.",
            //    args.Method.DeclaringType.Name, args.Method.Name), this.category);
        }

        /// <summary>
        /// On exit we remove trace.
        /// </summary>
        /// <param name="args">MethodExecutionArgs</param>
        public override void OnExit(MethodExecutionArgs args)
        {
            if (ThreadContext.Properties["Trace_" + cTraceName] != null)
            {
                Trace tTrace = (Trace)ThreadContext.Properties["Trace_" + cTraceName];
                if (tTrace.IsTraceOver())
                {
                    ThreadContext.Properties.Remove("Trace_" + cTraceName);
                }
                else
                {
                    //If we have problems leaving trace we should remove it.
                    if (!tTrace.TraceLeave())
                    {
                        ThreadContext.Properties.Remove("Trace_" + cTraceName);
                    }
                }
            }
            // Trace.WriteLine(string.Format("Leaving {0}.{1}.",
            //    args.Method.DeclaringType.Name, args.Method.Name), this.category);
        }
    }

    [TestFixture, Description("Logging test with xml output")]
    class Log4TraceTest
    {

        [TestCase]
        public static void Test()
        {
            XmlConfigurator.Configure(new System.IO.FileInfo("log.cfg"));
            TraceTestClass tc1 = new TraceTestClass();
            tc1.FirstFunction();
        }

        class TraceTestClass
        {
            private static readonly ILog log = LogManager.GetLogger(typeof(TraceTestClass));

            [TraceEnter("TraceTest")]
            public void FirstFunction()
            {
                log.Debug("FirstFunction");
                TestClass1 tc1 = new TestClass1();
                tc1.SecondFunction();
            }
        }

        class TestClass1
        {
            private static readonly ILog log = LogManager.GetLogger(typeof(TestClass1));

            [Trace("TraceTest","TestClass1")]
            public void SecondFunction()
            {
                log.Debug("SecondFunction");
                TestClass2 tc2 = new TestClass2();
                tc2.ThirdFunction();
            }
        }

        class TestClass2
        {
            private static readonly ILog log = LogManager.GetLogger(typeof(TestClass1));

            [Trace("TraceTest", "TestClass2")]
            public void ThirdFunction()
            {
                log.Debug("ThirdFunction");
                RecursionTest(10);
            }

            [Trace("TraceTest", "Recursion")]
            public void RecursionTest(int countdown)
            {
                if (countdown == 0)
                    return;

                log.Debug("Let's stop recursion in: "+ countdown);
                RecursionTest(countdown - 1);
            }
        }
    }
}
