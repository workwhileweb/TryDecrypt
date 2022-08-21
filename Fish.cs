namespace TryDecrypt
{
    public partial class Fish : Form
    {
        private const int Block = 10000;

        /// <summary>
        /// https://www.example-code.com/mono/crypt2_blowfish.asp
        /// </summary>
        /// <param name="cancel"></param>
        /// <param name="decrypted"></param>
        /// <param name="encryptedB64"></param>
        /// <param name="previousCount"></param>
        /// <param name="previousKeyHex"></param>
        /// <param name="block"></param>
        /// <param name="onBlockCount"></param>
        /// <param name="onBlockKey"></param>
        /// <returns></returns>
        private static (bool found, ulong count, string currentKeyHex) BlowfishFindKey(
            CancellationToken cancel,
            string decrypted,
            string encryptedB64,
            ulong previousCount,
            string previousKeyHex,
            ulong block = Block,
            Action<ulong>? onBlockCount=null,
            Action<string>? onBlockKey=null)
        {
            var bytes = string.IsNullOrWhiteSpace(previousKeyHex)
                ? new byte[16]
                : Convert.FromHexString(previousKeyHex);

            var crypt = new Chilkat.Crypt2();

            crypt.CryptAlgorithm = "blowfish2";
            // CipherMode may be "ecb", "cbc", or "cfb"
            crypt.CipherMode = "ecb";
            // KeyLength (in bits) may be a number between 32 and 448.
            // 128-bits is usually sufficient.  The KeyLength must be a 
            // multiple of 8.
            crypt.KeyLength = bytes.Length * 8;
            // The padding scheme determines the contents of the bytes
            // that are added to pad the result to a multiple of the
            // encryption algorithm's block size.  Blowfish has a block
            // size of 8 bytes, so encrypted output is always
            // a multiple of 8.
            crypt.PaddingScheme = 0;
            // EncodingMode specifies the encoding of the output for
            // encryption, and the input for decryption.
            // It may be "hex", "url", "base64", or "quoted-printable".
            crypt.EncodingMode = "base64";
            // An initialization vector is required if using CBC or CFB modes.
            // ECB mode does not use an IV.
            // The length of the IV is equal to the algorithm's block size.
            // It is NOT equal to the length of the key.
            const string ivHex = "FF";
            crypt.SetEncodedIV(ivHex, "hex");

            while (!cancel.IsCancellationRequested)
            {
                previousCount++;

                for (var i = 0; i < bytes.Length; i++)
                {
                    if (bytes[i] >= byte.MaxValue) bytes[i] = 0;
                    else
                    {
                        bytes[i] = (byte)(bytes[i] + 1);
                        break;
                    }
                }

                if (bytes[^1] >= byte.MaxValue) throw new Exception();

                // The secret key must equal the size of the key.  For
                // 256-bit encryption, the binary secret key is 32 bytes.
                // For 128-bit encryption, the binary secret key is 16 bytes.
                //crypt.SetEncodedKey("000102030405060708090A0B0C0D0E0F", "hex");
                //crypt.SetEncodedKey(Convert.ToHexString(bytes), "hex");
                crypt.SecretKey = bytes;
                // Encrypt a string...
                // The input string is 44 ANSI characters (i.e. 44 bytes), so
                // the output should be 48 bytes (a multiple of 8).
                // Because the output is a hex string, it should
                // be 96 characters long (2 chars per byte).
                //var encStr = crypt.EncryptStringENC("The quick brown fox jumps over the lazy dog.");
                //var decStr = crypt.DecryptStringENC(encStr);
                //Debug.WriteLine(decStr);

                //TODO : tăng tốc bằng so sánh và giải mã ra byte không convert về string lâu

                var encrypt = crypt.EncryptStringENC(decrypted);
                if (encrypt.Equals(encryptedB64)) return (true, previousCount, Convert.ToHexString(bytes));

                if (previousCount % block != 0) continue;
                
                onBlockCount?.Invoke(previousCount);
                onBlockKey?.Invoke(Convert.ToHexString(bytes));
            }

            return (false, previousCount, Convert.ToHexString(bytes));
        }

        public Fish()
        {
            InitializeComponent();
        }

        private void Fish_Load(object sender, EventArgs e)
        {
            textBoxCount.Text = Settings.Default.FishCount;
            textBoxCurrentKey.Text = Settings.Default.FishCurrentKey;
        }

        private void Fish_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.FishCount=textBoxCount.Text;
            Settings.Default.FishCurrentKey=textBoxCurrentKey.Text;

            Settings.Default.Save();
        }

        private CancellationTokenSource? _cancel;

        private void Message(string message, bool isError = true)
        {
            if (InvokeRequired)
            {
                BeginInvoke(() => { Message(message, isError); });
                return;
            }

            var icon = isError ? MessageBoxIcon.Error : MessageBoxIcon.Exclamation;
            MessageBox.Show(message, Text, MessageBoxButtons.OK,icon);
        }

        private void buttonStartStop_Click(object sender, EventArgs e)
        {
            if (_cancel is null || _cancel.IsCancellationRequested)
            {
                _cancel = new CancellationTokenSource();
                
                buttonStartStop.Text = @"stop";
                
                Task.Factory.StartNew(() =>
                {
                    var preCount = string.IsNullOrWhiteSpace(textBoxCount.Text) ? 0 : ulong.Parse(textBoxCount.Text);
                    var preKey = textBoxCurrentKey.Text;
                    var encryptedB64 = textBoxEncrypted.Text;
                    var decrypted = textBoxDecrypted.Text;

                    try
                    {
                        var (found, count, currentKeyHex) = BlowfishFindKey(_cancel.Token,
                            decrypted,
                            encryptedB64,
                            preCount,
                            preKey,
                            Block,
                            i => Invoke(() => textBoxCount.Text = i.ToString()),
                            s => Invoke(() => textBoxCurrentKey.Text = s));

                        Invoke(() => textBoxCount.Text = count.ToString());
                        Invoke(() => textBoxCurrentKey.Text = currentKeyHex);

                        if (!found) return;

                        Message(nameof(found), false);
                        return;
                    }
                    catch (Exception ex)
                    {
                        Message(ex.Message);
                    }
                }, _cancel.Token).ContinueWith(_ =>
                {
                    _cancel = null;
                    buttonStartStop.Text = @"start";
                });
            }
            else
            {
                _cancel.Cancel();
            }
        }
    }
}