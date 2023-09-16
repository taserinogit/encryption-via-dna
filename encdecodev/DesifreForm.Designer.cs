namespace encdecodev
{
    partial class DesifreForm
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
            this.txtEncrypt = new System.Windows.Forms.RichTextBox();
            this.encryptLabel = new System.Windows.Forms.Label();
            this.txtDecrypt = new System.Windows.Forms.RichTextBox();
            this.decryptLabel = new System.Windows.Forms.Label();
            this.BtnDecrypt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.sifreleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(12, 105);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(700, 131);
            this.txtEncrypt.TabIndex = 10;
            this.txtEncrypt.Text = "";
            // 
            // encryptLabel
            // 
            this.encryptLabel.AutoSize = true;
            this.encryptLabel.Location = new System.Drawing.Point(12, 87);
            this.encryptLabel.Name = "encryptLabel";
            this.encryptLabel.Size = new System.Drawing.Size(102, 15);
            this.encryptLabel.TabIndex = 11;
            this.encryptLabel.Text = "Şifrelenmiş Mesaj:";
            // 
            // txtDecrypt
            // 
            this.txtDecrypt.Location = new System.Drawing.Point(12, 272);
            this.txtDecrypt.Name = "txtDecrypt";
            this.txtDecrypt.Size = new System.Drawing.Size(700, 136);
            this.txtDecrypt.TabIndex = 12;
            this.txtDecrypt.Text = "";
            // 
            // decryptLabel
            // 
            this.decryptLabel.AutoSize = true;
            this.decryptLabel.Location = new System.Drawing.Point(12, 254);
            this.decryptLabel.Name = "decryptLabel";
            this.decryptLabel.Size = new System.Drawing.Size(115, 15);
            this.decryptLabel.TabIndex = 13;
            this.decryptLabel.Text = "Deşifrelenmiş Mesaj:";
            // 
            // BtnDecrypt
            // 
            this.BtnDecrypt.Location = new System.Drawing.Point(637, 242);
            this.BtnDecrypt.Name = "BtnDecrypt";
            this.BtnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.BtnDecrypt.TabIndex = 14;
            this.BtnDecrypt.Text = "Deşifrele";
            this.BtnDecrypt.UseVisualStyleBackColor = true;
            this.BtnDecrypt.Click += new System.EventHandler(this.BtnDecrypt_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "ANAHTAR:";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(82, 38);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(197, 23);
            this.txtAnahtar.TabIndex = 16;
            // 
            // sifreleme
            // 
            this.sifreleme.Location = new System.Drawing.Point(586, 38);
            this.sifreleme.Name = "sifreleme";
            this.sifreleme.Size = new System.Drawing.Size(126, 23);
            this.sifreleme.TabIndex = 17;
            this.sifreleme.Text = "Şifreleme Sayfası";
            this.sifreleme.UseVisualStyleBackColor = true;
            this.sifreleme.Click += new System.EventHandler(this.sifreleme_Click_1);
            // 
            // DesifreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sifreleme);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnDecrypt);
            this.Controls.Add(this.decryptLabel);
            this.Controls.Add(this.txtDecrypt);
            this.Controls.Add(this.encryptLabel);
            this.Controls.Add(this.txtEncrypt);
            this.Name = "DesifreForm";
            this.Text = "Desifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RichTextBox txtEncrypt;
        private Label encryptLabel;
        private RichTextBox txtDecrypt;
        private Label decryptLabel;
        private Button BtnDecrypt;
        private Label label1;
        private TextBox txtAnahtar;
        private Button sifreleme;
    }
}