using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace TryDecrypt
{
    internal static class Extension
    {
        public static int ToBase10(byte[] entityStates)  // Each state can be 0, 1 or 2.
        {
            int result = 0;

            for (int i = 0, n = 1; i < entityStates.Length; n *= 3, ++i)
                result += n * entityStates[i];

            return result;
        }

        /// <summary>
        /// byte[] inHex = "FFFF".GetHexBytes();      // => [ 0xFF, 0xFF ]
        /// </summary>
        /// <param name="hex"></param>
        /// <returns></returns>
        public static byte[] GetHexBytes(this string hex)
        {
            return BigInteger.Parse(hex, System.Globalization.NumberStyles.HexNumber).ToByteArray(true);
        }

        /// <summary>
        /// byte[] inDec = "65535".GetDecimalBytes(); // => [ 0xFF, 0xFF ]
        /// </summary>
        /// <param name="dec"></param>
        /// <returns></returns>
        public static byte[] GetDecimalBytes(this string dec)
        {
            return BigInteger.Parse(dec).ToByteArray(true);
        }
    }
}
