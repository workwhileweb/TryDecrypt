using System.Diagnostics;
using System.Text;
using Org.BouncyCastle.Crypto;

namespace TryDecrypt
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void textBoxAcceptChar_TextChanged(object sender, EventArgs e)
        {
            labelAcceptChars.Text = $@"accept-chars ({textBoxAcceptChar.Text.Length})";

            textBoxFromIndex_TextChanged(null!, null!);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            textBoxAcceptChar.Text = Settings.Default.AcceptChars;
            textBoxFromIndex.Text= Settings.Default.FromIndex;
            textBoxCurrent.Text = Settings.Default.Current;
            textBoxBlock.Text  = Settings.Default.Block;
            textBoxDecrypted.Text= Settings.Default.Decrypted;
            textBoxEncrypted.Text= Settings.Default.Encrypted;
            textBoxKey.Text= Settings.Default.Key;

            textBoxAcceptChar_TextChanged(null!, null!);
        }
        
        private void textBoxFromIndex_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxAcceptChar.Text)) return;
            if (string.IsNullOrWhiteSpace(textBoxFromIndex.Text)) return;

            var baseN = new BaseN(textBoxAcceptChar.Text.Trim());
            var fromIndex = long.Parse(textBoxFromIndex.Text);
            
            textBoxCurrent.Text = baseN.From10(fromIndex);

            Debug.Assert(baseN.To10(textBoxCurrent.Text) == fromIndex);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.AcceptChars=textBoxAcceptChar.Text;
            Settings.Default.FromIndex=textBoxFromIndex.Text;
            Settings.Default.Current=textBoxCurrent.Text;
            Settings.Default.Decrypted=textBoxDecrypted.Text;
            Settings.Default.Encrypted=textBoxEncrypted.Text;
            Settings.Default.Block=textBoxBlock.Text;
            Settings.Default.Key=textBoxKey.Text;

            Settings.Default.Save();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            var baseN = new BaseN(textBoxAcceptChar.Text.Trim());
            var fromIndex = long.Parse(textBoxFromIndex.Text);
            
            var bytes = baseN.ToByteArray(baseN.From10(fromIndex), 100);
            baseN.ByteArrayAdd1(ref bytes);
            textBoxFromIndex.Text = baseN.To10(baseN.FromByteArray(bytes)).ToString();
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            //textBoxDecrypted.Text = MyBlowfish.Decrypt(textBoxEncrypted.Text, textBoxKey.Text);
            var bf=new BlowFish(Encoding.ASCII.GetBytes(textBoxKey.Text));
            var decrypt = bf.Decrypt_ECB(Convert.FromBase64String(textBoxEncrypted.Text));
            textBoxDecrypted.Text = Encoding.ASCII.GetString(decrypt);
            //textBoxDecrypted.Text = bf.Decrypt_CTR(textBoxEncrypted.Text);
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            //textBoxEncrypted.Text = MyBlowfish.Encrypt(textBoxDecrypted.Text, textBoxKey.Text);
            var bf = new BlowFish(Encoding.ASCII.GetBytes(textBoxKey.Text));
            var encrypt = bf.Encrypt_ECB(Encoding.ASCII.GetBytes(textBoxDecrypted.Text));
            textBoxEncrypted.Text = Convert.ToBase64String(encrypt);
            //textBoxEncrypted.Text = bf.Encrypt_CTR(textBoxDecrypted.Text);
        }

        private void textBoxCurrent_TextChanged(object sender, EventArgs e)
        {
            labelCurrent.Text = $@"current ({textBoxCurrent.Text.Length})";
        }

        private void textBoxKey_TextChanged(object sender, EventArgs e)
        {
            labelKey.Text = $@"key ({textBoxKey.Text.Length})";
        }

        private void textBoxEncrypted_TextChanged(object sender, EventArgs e)
        {
            labelEncrypted.Text = $@"encrypted ({textBoxEncrypted.Text.Length})";
        }

        private void textBoxDecrypted_TextChanged(object sender, EventArgs e)
        {
            labelDecrypted.Text = $@"decrypted ({textBoxDecrypted.Text.Length})";
        }

        private CancellationTokenSource? _cancel;

        private void buttonProcess_Click(object sender, EventArgs e)
        {
            if (_cancel is null || _cancel.IsCancellationRequested)
            {
                _cancel = new CancellationTokenSource();

                var baseN = new BaseN(textBoxAcceptChar.Text.Trim());
                var fromIndex = long.Parse(textBoxFromIndex.Text);
                var bytes = baseN.ToByteArray(baseN.From10(fromIndex), 100);
                var block = int.Parse(textBoxBlock.Text);
                var decryptBytes = Encoding.ASCII.GetBytes(textBoxDecrypted.Text);
                var encryptBytes = Convert.FromBase64String(textBoxEncrypted.Text);

                buttonProcess.Text = @"running";

                Task.Factory.StartNew(() =>
                {
                    try
                    {
                        var counter = 0;
                        while (!_cancel.IsCancellationRequested)
                        {
                            baseN.ByteArrayAdd1(ref bytes);
                            var key = baseN.FromByteArray(bytes);
                            var bf = new BlowFish(Encoding.ASCII.GetBytes(key));
                            var encrypt = bf.Encrypt_ECB(decryptBytes);
                            if (encrypt.SequenceEqual(encryptBytes))
                            {
                                Invoke(() =>
                                {
                                    Clipboard.SetText(key);
                                    MessageBox.Show($@"key found : {key}", Text,
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Exclamation);
                                    textBoxKey.Text = key;
                                });
                                return;
                            }

                            counter++;
                            if (counter <= block) continue;

                            counter = 0;
                            var index = baseN.To10(baseN.FromByteArray(bytes));
                            Invoke(() => { textBoxFromIndex.Text = index.ToString(); });
                        }
                    }
                    catch (Exception ex)
                    {
                        //throw;
                        Invoke(() => MessageBox.Show(ex.Message,Text, MessageBoxButtons.OK,MessageBoxIcon.Error));
                    }
                },_cancel.Token).ContinueWith(task =>
                {
                    _cancel = null;
                    buttonProcess.Text = @"start/stop";
                });
            }
            else
            {
                _cancel.Cancel();
            }
        }
    }
}