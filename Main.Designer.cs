namespace TryDecrypt
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.textBoxKey = new System.Windows.Forms.TextBox();
            this.textBoxBlock = new System.Windows.Forms.TextBox();
            this.labelBlock = new System.Windows.Forms.Label();
            this.textBoxCurrent = new System.Windows.Forms.TextBox();
            this.labelCurrent = new System.Windows.Forms.Label();
            this.labelMethod = new System.Windows.Forms.Label();
            this.textBoxAcceptChar = new System.Windows.Forms.TextBox();
            this.labelAcceptChars = new System.Windows.Forms.Label();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.labelDecrypted = new System.Windows.Forms.Label();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.labelEncrypted = new System.Windows.Forms.Label();
            this.labelFromIndex = new System.Windows.Forms.Label();
            this.textBoxFromIndex = new System.Windows.Forms.TextBox();
            this.comboBoxMethod = new System.Windows.Forms.ComboBox();
            this.buttonProcess = new System.Windows.Forms.Button();
            this.buttonTest = new System.Windows.Forms.Button();
            this.labelKey = new System.Windows.Forms.Label();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.tableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.Controls.Add(this.textBoxKey, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.textBoxBlock, 1, 7);
            this.tableLayoutPanel.Controls.Add(this.labelBlock, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.textBoxCurrent, 1, 6);
            this.tableLayoutPanel.Controls.Add(this.labelCurrent, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.labelMethod, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.textBoxAcceptChar, 1, 4);
            this.tableLayoutPanel.Controls.Add(this.labelAcceptChars, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.textBoxDecrypted, 1, 0);
            this.tableLayoutPanel.Controls.Add(this.labelDecrypted, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.textBoxEncrypted, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.labelEncrypted, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.labelFromIndex, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.textBoxFromIndex, 1, 5);
            this.tableLayoutPanel.Controls.Add(this.comboBoxMethod, 1, 3);
            this.tableLayoutPanel.Controls.Add(this.buttonProcess, 1, 8);
            this.tableLayoutPanel.Controls.Add(this.buttonTest, 2, 6);
            this.tableLayoutPanel.Controls.Add(this.labelKey, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.buttonDecrypt, 2, 0);
            this.tableLayoutPanel.Controls.Add(this.buttonEncrypt, 2, 1);
            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 9;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(687, 443);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // textBoxKey
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxKey, 2);
            this.textBoxKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxKey.Location = new System.Drawing.Point(209, 91);
            this.textBoxKey.Name = "textBoxKey";
            this.textBoxKey.Size = new System.Drawing.Size(475, 39);
            this.textBoxKey.TabIndex = 16;
            this.textBoxKey.TextChanged += new System.EventHandler(this.textBoxKey_TextChanged);
            // 
            // textBoxBlock
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxBlock, 2);
            this.textBoxBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxBlock.Location = new System.Drawing.Point(209, 311);
            this.textBoxBlock.Name = "textBoxBlock";
            this.textBoxBlock.Size = new System.Drawing.Size(475, 39);
            this.textBoxBlock.TabIndex = 13;
            this.textBoxBlock.Text = "5000";
            // 
            // labelBlock
            // 
            this.labelBlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBlock.Location = new System.Drawing.Point(3, 308);
            this.labelBlock.Name = "labelBlock";
            this.labelBlock.Size = new System.Drawing.Size(200, 44);
            this.labelBlock.TabIndex = 12;
            this.labelBlock.Text = "block";
            this.labelBlock.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxCurrent
            // 
            this.textBoxCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCurrent.Location = new System.Drawing.Point(209, 267);
            this.textBoxCurrent.Name = "textBoxCurrent";
            this.textBoxCurrent.Size = new System.Drawing.Size(337, 39);
            this.textBoxCurrent.TabIndex = 11;
            this.textBoxCurrent.TextChanged += new System.EventHandler(this.textBoxCurrent_TextChanged);
            // 
            // labelCurrent
            // 
            this.labelCurrent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelCurrent.Location = new System.Drawing.Point(3, 264);
            this.labelCurrent.Name = "labelCurrent";
            this.labelCurrent.Size = new System.Drawing.Size(200, 44);
            this.labelCurrent.TabIndex = 10;
            this.labelCurrent.Text = "current";
            this.labelCurrent.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelMethod
            // 
            this.labelMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMethod.Location = new System.Drawing.Point(3, 132);
            this.labelMethod.Name = "labelMethod";
            this.labelMethod.Size = new System.Drawing.Size(200, 44);
            this.labelMethod.TabIndex = 8;
            this.labelMethod.Text = "method";
            this.labelMethod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxAcceptChar
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxAcceptChar, 2);
            this.textBoxAcceptChar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxAcceptChar.Location = new System.Drawing.Point(209, 179);
            this.textBoxAcceptChar.Name = "textBoxAcceptChar";
            this.textBoxAcceptChar.Size = new System.Drawing.Size(475, 39);
            this.textBoxAcceptChar.TabIndex = 7;
            this.textBoxAcceptChar.Text = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 !\"#$%&\'()*+,-./:;<" +
    "=>?@[\\]^_`{|}~";
            this.textBoxAcceptChar.TextChanged += new System.EventHandler(this.textBoxAcceptChar_TextChanged);
            // 
            // labelAcceptChars
            // 
            this.labelAcceptChars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAcceptChars.Location = new System.Drawing.Point(3, 176);
            this.labelAcceptChars.Name = "labelAcceptChars";
            this.labelAcceptChars.Size = new System.Drawing.Size(200, 44);
            this.labelAcceptChars.TabIndex = 6;
            this.labelAcceptChars.Text = "accept-chars";
            this.labelAcceptChars.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDecrypted.Location = new System.Drawing.Point(209, 3);
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(337, 39);
            this.textBoxDecrypted.TabIndex = 0;
            this.textBoxDecrypted.TextChanged += new System.EventHandler(this.textBoxDecrypted_TextChanged);
            // 
            // labelDecrypted
            // 
            this.labelDecrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelDecrypted.Location = new System.Drawing.Point(3, 0);
            this.labelDecrypted.Name = "labelDecrypted";
            this.labelDecrypted.Size = new System.Drawing.Size(200, 44);
            this.labelDecrypted.TabIndex = 1;
            this.labelDecrypted.Text = "decrypted";
            this.labelDecrypted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxEncrypted.Location = new System.Drawing.Point(209, 47);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(337, 39);
            this.textBoxEncrypted.TabIndex = 2;
            this.textBoxEncrypted.TextChanged += new System.EventHandler(this.textBoxEncrypted_TextChanged);
            // 
            // labelEncrypted
            // 
            this.labelEncrypted.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelEncrypted.Location = new System.Drawing.Point(3, 44);
            this.labelEncrypted.Name = "labelEncrypted";
            this.labelEncrypted.Size = new System.Drawing.Size(200, 44);
            this.labelEncrypted.TabIndex = 3;
            this.labelEncrypted.Text = "encrypted";
            this.labelEncrypted.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelFromIndex
            // 
            this.labelFromIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelFromIndex.Location = new System.Drawing.Point(3, 220);
            this.labelFromIndex.Name = "labelFromIndex";
            this.labelFromIndex.Size = new System.Drawing.Size(200, 44);
            this.labelFromIndex.TabIndex = 4;
            this.labelFromIndex.Text = "from-index";
            this.labelFromIndex.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textBoxFromIndex
            // 
            this.tableLayoutPanel.SetColumnSpan(this.textBoxFromIndex, 2);
            this.textBoxFromIndex.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFromIndex.Location = new System.Drawing.Point(209, 223);
            this.textBoxFromIndex.Name = "textBoxFromIndex";
            this.textBoxFromIndex.Size = new System.Drawing.Size(475, 39);
            this.textBoxFromIndex.TabIndex = 5;
            this.textBoxFromIndex.TextChanged += new System.EventHandler(this.textBoxFromIndex_TextChanged);
            // 
            // comboBoxMethod
            // 
            this.tableLayoutPanel.SetColumnSpan(this.comboBoxMethod, 2);
            this.comboBoxMethod.Dock = System.Windows.Forms.DockStyle.Fill;
            this.comboBoxMethod.FormattingEnabled = true;
            this.comboBoxMethod.Location = new System.Drawing.Point(209, 135);
            this.comboBoxMethod.Name = "comboBoxMethod";
            this.comboBoxMethod.Size = new System.Drawing.Size(475, 40);
            this.comboBoxMethod.TabIndex = 9;
            this.comboBoxMethod.Text = "blowfish5";
            // 
            // buttonProcess
            // 
            this.tableLayoutPanel.SetColumnSpan(this.buttonProcess, 2);
            this.buttonProcess.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProcess.Location = new System.Drawing.Point(209, 355);
            this.buttonProcess.Name = "buttonProcess";
            this.buttonProcess.Size = new System.Drawing.Size(475, 85);
            this.buttonProcess.TabIndex = 1;
            this.buttonProcess.Text = "start/stop";
            this.buttonProcess.UseVisualStyleBackColor = true;
            this.buttonProcess.Click += new System.EventHandler(this.buttonProcess_Click);
            // 
            // buttonTest
            // 
            this.buttonTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonTest.Location = new System.Drawing.Point(552, 267);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(132, 38);
            this.buttonTest.TabIndex = 14;
            this.buttonTest.Text = "test";
            this.buttonTest.UseVisualStyleBackColor = true;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // labelKey
            // 
            this.labelKey.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelKey.Location = new System.Drawing.Point(3, 88);
            this.labelKey.Name = "labelKey";
            this.labelKey.Size = new System.Drawing.Size(200, 44);
            this.labelKey.TabIndex = 15;
            this.labelKey.Text = "key";
            this.labelKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDecrypt.Location = new System.Drawing.Point(552, 3);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(132, 38);
            this.buttonDecrypt.TabIndex = 17;
            this.buttonDecrypt.Text = "decrypt";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEncrypt.Location = new System.Drawing.Point(552, 47);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(132, 38);
            this.buttonEncrypt.TabIndex = 18;
            this.buttonEncrypt.Text = "encrypt";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 467);
            this.Controls.Add(this.tableLayoutPanel);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TryDecrypt (tuan@mitdac.net)";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tableLayoutPanel;
        private TextBox textBoxDecrypted;
        private Label labelDecrypted;
        private Label labelMethod;
        private TextBox textBoxAcceptChar;
        private Label labelAcceptChars;
        private TextBox textBoxEncrypted;
        private Label labelEncrypted;
        private Label labelFromIndex;
        private TextBox textBoxFromIndex;
        private ComboBox comboBoxMethod;
        private TextBox textBoxCurrent;
        private Label labelCurrent;
        private Button buttonProcess;
        private TextBox textBoxBlock;
        private Label labelBlock;
        private Button buttonTest;
        private TextBox textBoxKey;
        private Label labelKey;
        private Button buttonDecrypt;
        private Button buttonEncrypt;
    }
}