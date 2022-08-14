namespace TryDecrypt
{
    partial class Fish
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonStartStop = new System.Windows.Forms.Button();
            this.labelCurrentKey = new System.Windows.Forms.Label();
            this.textBoxCurrentKey = new System.Windows.Forms.TextBox();
            this.textBoxCount = new System.Windows.Forms.TextBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.textBoxDecrypted = new System.Windows.Forms.TextBox();
            this.labelDecrypted = new System.Windows.Forms.Label();
            this.textBoxEncrypted = new System.Windows.Forms.TextBox();
            this.labelEncrypted = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonStartStop
            // 
            this.buttonStartStop.Location = new System.Drawing.Point(12, 12);
            this.buttonStartStop.Name = "buttonStartStop";
            this.buttonStartStop.Size = new System.Drawing.Size(382, 46);
            this.buttonStartStop.TabIndex = 0;
            this.buttonStartStop.Text = "start/stop";
            this.buttonStartStop.UseVisualStyleBackColor = true;
            this.buttonStartStop.Click += new System.EventHandler(this.buttonStartStop_Click);
            // 
            // labelCurrentKey
            // 
            this.labelCurrentKey.AutoSize = true;
            this.labelCurrentKey.Location = new System.Drawing.Point(12, 67);
            this.labelCurrentKey.Name = "labelCurrentKey";
            this.labelCurrentKey.Size = new System.Drawing.Size(137, 32);
            this.labelCurrentKey.TabIndex = 1;
            this.labelCurrentKey.Text = "current-key";
            // 
            // textBoxCurrentKey
            // 
            this.textBoxCurrentKey.Location = new System.Drawing.Point(152, 64);
            this.textBoxCurrentKey.Name = "textBoxCurrentKey";
            this.textBoxCurrentKey.Size = new System.Drawing.Size(242, 39);
            this.textBoxCurrentKey.TabIndex = 2;
            // 
            // textBoxCount
            // 
            this.textBoxCount.Location = new System.Drawing.Point(152, 109);
            this.textBoxCount.Name = "textBoxCount";
            this.textBoxCount.Size = new System.Drawing.Size(242, 39);
            this.textBoxCount.TabIndex = 4;
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Location = new System.Drawing.Point(12, 112);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(127, 32);
            this.labelCount.TabIndex = 3;
            this.labelCount.Text = "find-count";
            // 
            // textBoxDecrypted
            // 
            this.textBoxDecrypted.Location = new System.Drawing.Point(152, 154);
            this.textBoxDecrypted.Name = "textBoxDecrypted";
            this.textBoxDecrypted.Size = new System.Drawing.Size(242, 39);
            this.textBoxDecrypted.TabIndex = 6;
            this.textBoxDecrypted.Text = "710";
            // 
            // labelDecrypted
            // 
            this.labelDecrypted.AutoSize = true;
            this.labelDecrypted.Location = new System.Drawing.Point(12, 157);
            this.labelDecrypted.Name = "labelDecrypted";
            this.labelDecrypted.Size = new System.Drawing.Size(121, 32);
            this.labelDecrypted.TabIndex = 5;
            this.labelDecrypted.Text = "decrypted";
            // 
            // textBoxEncrypted
            // 
            this.textBoxEncrypted.Location = new System.Drawing.Point(152, 199);
            this.textBoxEncrypted.Name = "textBoxEncrypted";
            this.textBoxEncrypted.Size = new System.Drawing.Size(242, 39);
            this.textBoxEncrypted.TabIndex = 8;
            this.textBoxEncrypted.Text = "pmxOzFlUECU=";
            // 
            // labelEncrypted
            // 
            this.labelEncrypted.AutoSize = true;
            this.labelEncrypted.Location = new System.Drawing.Point(12, 202);
            this.labelEncrypted.Name = "labelEncrypted";
            this.labelEncrypted.Size = new System.Drawing.Size(121, 32);
            this.labelEncrypted.TabIndex = 7;
            this.labelEncrypted.Text = "encrypted";
            // 
            // Fish
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 255);
            this.Controls.Add(this.textBoxEncrypted);
            this.Controls.Add(this.labelEncrypted);
            this.Controls.Add(this.textBoxDecrypted);
            this.Controls.Add(this.labelDecrypted);
            this.Controls.Add(this.textBoxCount);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.textBoxCurrentKey);
            this.Controls.Add(this.labelCurrentKey);
            this.Controls.Add(this.buttonStartStop);
            this.Name = "Fish";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fish by h3ll0";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Fish_FormClosed);
            this.Load += new System.EventHandler(this.Fish_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonStartStop;
        private Label labelCurrentKey;
        private TextBox textBoxCurrentKey;
        private TextBox textBoxCount;
        private Label labelCount;
        private TextBox textBoxDecrypted;
        private Label labelDecrypted;
        private TextBox textBoxEncrypted;
        private Label labelEncrypted;
    }
}