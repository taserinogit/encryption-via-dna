namespace encdecodev
{
    partial class Form1
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
            this.valueLabel = new System.Windows.Forms.Label();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.encryptLabel = new System.Windows.Forms.Label();
            this.txtEncrypt = new System.Windows.Forms.RichTextBox();
            this.txtValue = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAnahtar = new System.Windows.Forms.TextBox();
            this.Desifreleme = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.Location = new System.Drawing.Point(20, 61);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(107, 15);
            this.valueLabel.TabIndex = 0;
            this.valueLabel.Text = "Şifrelenecek Mesaj:";
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(645, 217);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 2;
            this.btnEncrypt.Text = "Şifrele";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // encryptLabel
            // 
            this.encryptLabel.AutoSize = true;
            this.encryptLabel.Location = new System.Drawing.Point(20, 272);
            this.encryptLabel.Name = "encryptLabel";
            this.encryptLabel.Size = new System.Drawing.Size(102, 15);
            this.encryptLabel.TabIndex = 3;
            this.encryptLabel.Text = "Şifrelenmiş Mesaj:";
            // 
            // txtEncrypt
            // 
            this.txtEncrypt.Location = new System.Drawing.Point(20, 290);
            this.txtEncrypt.Name = "txtEncrypt";
            this.txtEncrypt.Size = new System.Drawing.Size(700, 131);
            this.txtEncrypt.TabIndex = 9;
            this.txtEncrypt.Text = "";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(20, 79);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(700, 132);
            this.txtValue.TabIndex = 10;
            this.txtValue.Text = "";
            this.txtValue.TextChanged += new System.EventHandler(this.txtValue_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 11;
            this.label1.Text = "ANAHTAR:";
            // 
            // txtAnahtar
            // 
            this.txtAnahtar.Location = new System.Drawing.Point(90, 19);
            this.txtAnahtar.Name = "txtAnahtar";
            this.txtAnahtar.Size = new System.Drawing.Size(197, 23);
            this.txtAnahtar.TabIndex = 12;
            this.txtAnahtar.TextChanged += new System.EventHandler(this.txtAnahtar_TextChanged);
            // 
            // Desifreleme
            // 
            this.Desifreleme.Location = new System.Drawing.Point(594, 18);
            this.Desifreleme.Name = "Desifreleme";
            this.Desifreleme.Size = new System.Drawing.Size(126, 23);
            this.Desifreleme.TabIndex = 13;
            this.Desifreleme.Text = "Deşifreleme Sayfası";
            this.Desifreleme.UseVisualStyleBackColor = true;
            this.Desifreleme.Click += new System.EventHandler(this.Desifreleme_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 454);
            this.Controls.Add(this.Desifreleme);
            this.Controls.Add(this.txtAnahtar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.txtEncrypt);
            this.Controls.Add(this.encryptLabel);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.valueLabel);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sifreleme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label valueLabel;
        private Button btnEncrypt;
        private Label encryptLabel;
        private RichTextBox txtEncrypt;
        private RichTextBox txtValue;
        private Label label1;
        private TextBox txtAnahtar;
        private Button Desifreleme;
    }
}