using System.Text;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;

namespace TryDecrypt
{
    internal class MyBlowfish
    {
        private static readonly BlowfishEngine Engine = new();
        private static readonly PaddedBufferedBlockCipher Cipher = new(Engine, new Pkcs7Padding());

        public static string Encrypt(string decrypted, string key)
        {
            var keyBytes = new KeyParameter(Encoding.UTF8.GetBytes(key));
            Cipher.Init(true, keyBytes);
            var inB = Encoding.UTF8.GetBytes(decrypted);

            var outB = new byte[Cipher.GetOutputSize(inB.Length)];

            var len1 = Cipher.ProcessBytes(inB, 0, inB.Length, outB, 0);

            Cipher.DoFinal(outB, len1);

            return BitConverter.ToString(outB).Replace("-", "");
        }

        public static string Decrypt(string encrypted, string key)
        {
            var result = new StringBuilder();

            Cipher.Init(false, new KeyParameter(Encoding.UTF8.GetBytes(key)));

            var out1 = Convert.FromBase64String(encrypted);
            var out2 = new byte[Cipher.GetOutputSize(out1.Length)];

            var len2 = Cipher.ProcessBytes(out1, 0, out1.Length, out2, 0);

            Cipher.DoFinal(out2, len2); //Pad block corrupted error happens here

            var s2 = BitConverter.ToString(out2);

            foreach (var c in s2.Where(c => c != 0))
            {
                result.Append(c.ToString());
            }

            return result.ToString();

        }
    }
}
