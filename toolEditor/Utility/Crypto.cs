using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility
{
    internal class Crypto
    {
        internal static byte[] EncodeMapTable;
        internal static byte[] DecodeMapTable = new byte[256];

        static Crypto()
        {
            EncodeMapTable = Convert.FromBase64String("PO2GkT+ALzNf1+Q9MblO8k2xb+FwtdRWwLK8GuWJSEvLW8JVjZ2m+c5CSvTscgMCdhIgJFBgGNtdQdnGZa7/hzd1o0/1WtgWYwqbWSFoOxUOIwtrboofdMHKiyhAfcygKoEPagHoDHjcyNJz84Lg1dqQyRMijmQQJaQ+LvrPRBG6ep6lvwnHrxxYXKiiNO6cBGnrfJmYlsTNmqx38d39U3n870mfBbM2UYVDq72PGZfpuDmnHg1/9x0p5xSSiADfZ+OTbVJxFyvwvizRt2IytuZFOsW7e5SDVJUITF41G7SwhKr+MK1mBtZh3vvibC32JupHw6mhjNP40Ac4fidXRg==");
            for (var i = 0; i < 256; i++)
                DecodeMapTable[EncodeMapTable[i]] = (byte)i;
        }

        public static byte[] Decrypt(byte[] buffer)
        {
            byte[] output = new byte[buffer.Length];

            for (var i = 0; i < buffer.Length; i++)
                output[i] = DecodeMapTable[buffer[i]];

            return output;
        }

        public static void Decrypt(byte[] buffer, int offset, int length)
        {
            for (var i = offset; i < length; i++)
                buffer[i] = DecodeMapTable[buffer[i]];
        }

        public static byte[] Encrypt(byte[] buffer)
        {
            byte[] output = new byte[buffer.Length];

            for (var i = 0; i < buffer.Length; i++)
                output[i] = EncodeMapTable[buffer[i]];

            return output;
        }

        public static void Encrypt(byte[] buffer, int offset, int length)
        {
            for (var i = offset; i < length; i++)
                buffer[i] = EncodeMapTable[buffer[i]];
        }
    }
}
