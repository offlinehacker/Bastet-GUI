using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TROL_MgmtGui2
{
    /// <summary>
    /// Class for utility functions.
    /// </summary>
    class Util
    {
        /// <summary>
        /// Combines together two byte arrays
        /// </summary>
        /// <param name="first">First byte array</param>
        /// <param name="second">Second byte array</param>
        /// <returns>Combined byte arrays</returns>
        public static byte[] Combine(byte[] first, byte[] second)
        {
            byte[] ret = new byte[first.Length + second.Length];
            Buffer.BlockCopy(first, 0, ret, 0, first.Length);
            Buffer.BlockCopy(second, 0, ret, first.Length, second.Length);
            return ret;
        }
    }
}
