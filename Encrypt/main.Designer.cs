namespace Encrypt
{
    partial class main
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
            this.title = new System.Windows.Forms.Label();
            this.textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.railfenceEncrypt = new System.Windows.Forms.Button();
            this.caesarEncrypt = new System.Windows.Forms.Button();
            this.mixedEncrypt = new System.Windows.Forms.Button();
            this.mixedDecrypt = new System.Windows.Forms.Button();
            this.caesarDecrypt = new System.Windows.Forms.Button();
            this.railfenceDecrypt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.encryptedLabel = new System.Windows.Forms.TextBox();
            this.decryptedLabel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.Chartreuse;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(718, 50);
            this.title.TabIndex = 0;
            this.title.Text = ">> Encryptor / Decryptor";
            // 
            // textbox
            // 
            this.textbox.Location = new System.Drawing.Point(21, 125);
            this.textbox.Name = "textbox";
            this.textbox.Size = new System.Drawing.Size(724, 20);
            this.textbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Chartreuse;
            this.label1.Location = new System.Drawing.Point(17, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = ">> enter the text below";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Chartreuse;
            this.label2.Location = new System.Drawing.Point(17, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(283, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = ">> Encryption methods";
            // 
            // railfenceEncrypt
            // 
            this.railfenceEncrypt.Location = new System.Drawing.Point(21, 197);
            this.railfenceEncrypt.Name = "railfenceEncrypt";
            this.railfenceEncrypt.Size = new System.Drawing.Size(201, 23);
            this.railfenceEncrypt.TabIndex = 4;
            this.railfenceEncrypt.Text = "Rail fence cipher";
            this.railfenceEncrypt.UseVisualStyleBackColor = true;
            this.railfenceEncrypt.Click += new System.EventHandler(this.RailfenceEncrypt_Click);
            // 
            // caesarEncrypt
            // 
            this.caesarEncrypt.Location = new System.Drawing.Point(228, 197);
            this.caesarEncrypt.Name = "caesarEncrypt";
            this.caesarEncrypt.Size = new System.Drawing.Size(201, 23);
            this.caesarEncrypt.TabIndex = 5;
            this.caesarEncrypt.Text = "Caesar Cipher";
            this.caesarEncrypt.UseVisualStyleBackColor = true;
            this.caesarEncrypt.Click += new System.EventHandler(this.CaesarEncrypt_Click);
            // 
            // mixedEncrypt
            // 
            this.mixedEncrypt.Location = new System.Drawing.Point(435, 197);
            this.mixedEncrypt.Name = "mixedEncrypt";
            this.mixedEncrypt.Size = new System.Drawing.Size(201, 23);
            this.mixedEncrypt.TabIndex = 6;
            this.mixedEncrypt.Text = "Mixed";
            this.mixedEncrypt.UseVisualStyleBackColor = true;
            this.mixedEncrypt.Click += new System.EventHandler(this.MixedEncrypt_Click);
            // 
            // mixedDecrypt
            // 
            this.mixedDecrypt.Location = new System.Drawing.Point(435, 333);
            this.mixedDecrypt.Name = "mixedDecrypt";
            this.mixedDecrypt.Size = new System.Drawing.Size(201, 23);
            this.mixedDecrypt.TabIndex = 10;
            this.mixedDecrypt.Text = "Mixed";
            this.mixedDecrypt.UseVisualStyleBackColor = true;
            this.mixedDecrypt.Click += new System.EventHandler(this.MixedDecrypt_Click);
            // 
            // caesarDecrypt
            // 
            this.caesarDecrypt.Location = new System.Drawing.Point(228, 333);
            this.caesarDecrypt.Name = "caesarDecrypt";
            this.caesarDecrypt.Size = new System.Drawing.Size(201, 23);
            this.caesarDecrypt.TabIndex = 9;
            this.caesarDecrypt.Text = "Caesar Cipher";
            this.caesarDecrypt.UseVisualStyleBackColor = true;
            this.caesarDecrypt.Click += new System.EventHandler(this.CaesarDecrypt_Click);
            // 
            // railfenceDecrypt
            // 
            this.railfenceDecrypt.Location = new System.Drawing.Point(21, 333);
            this.railfenceDecrypt.Name = "railfenceDecrypt";
            this.railfenceDecrypt.Size = new System.Drawing.Size(201, 23);
            this.railfenceDecrypt.TabIndex = 8;
            this.railfenceDecrypt.Text = "Rail fence cipher";
            this.railfenceDecrypt.UseVisualStyleBackColor = true;
            this.railfenceDecrypt.Click += new System.EventHandler(this.RailfenceDecrypt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Chartreuse;
            this.label3.Location = new System.Drawing.Point(17, 306);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(283, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = ">> Decryption methods";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Chartreuse;
            this.label4.Location = new System.Drawing.Point(17, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 23);
            this.label4.TabIndex = 11;
            this.label4.Text = ">> Encrypted text";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Chartreuse;
            this.label6.Location = new System.Drawing.Point(17, 368);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = ">> Decrypted text";
            // 
            // encryptedLabel
            // 
            this.encryptedLabel.BackColor = System.Drawing.Color.Black;
            this.encryptedLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.encryptedLabel.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.encryptedLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.encryptedLabel.Location = new System.Drawing.Point(21, 263);
            this.encryptedLabel.Multiline = true;
            this.encryptedLabel.Name = "encryptedLabel";
            this.encryptedLabel.ReadOnly = true;
            this.encryptedLabel.Size = new System.Drawing.Size(724, 40);
            this.encryptedLabel.TabIndex = 15;
            this.encryptedLabel.TabStop = false;
            this.encryptedLabel.Text = "(NULL)";
            // 
            // decryptedLabel
            // 
            this.decryptedLabel.BackColor = System.Drawing.Color.Black;
            this.decryptedLabel.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.decryptedLabel.Font = new System.Drawing.Font("Courier New", 14.25F);
            this.decryptedLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.decryptedLabel.Location = new System.Drawing.Point(21, 394);
            this.decryptedLabel.Multiline = true;
            this.decryptedLabel.Name = "decryptedLabel";
            this.decryptedLabel.ReadOnly = true;
            this.decryptedLabel.Size = new System.Drawing.Size(724, 42);
            this.decryptedLabel.TabIndex = 16;
            this.decryptedLabel.TabStop = false;
            this.decryptedLabel.Text = "(NULL)";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(766, 461);
            this.Controls.Add(this.decryptedLabel);
            this.Controls.Add(this.encryptedLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mixedDecrypt);
            this.Controls.Add(this.caesarDecrypt);
            this.Controls.Add(this.railfenceDecrypt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.mixedEncrypt);
            this.Controls.Add(this.caesarEncrypt);
            this.Controls.Add(this.railfenceEncrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textbox);
            this.Controls.Add(this.title);
            this.Name = "main";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title;
        public System.Windows.Forms.TextBox textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button railfenceEncrypt;
        private System.Windows.Forms.Button caesarEncrypt;
        private System.Windows.Forms.Button mixedEncrypt;
        private System.Windows.Forms.Button mixedDecrypt;
        private System.Windows.Forms.Button caesarDecrypt;
        private System.Windows.Forms.Button railfenceDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox encryptedLabel;
        public System.Windows.Forms.TextBox decryptedLabel;
    }
}

