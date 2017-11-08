namespace EncryptionDecryption
{
    partial class Form1
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
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.Value = new System.Windows.Forms.Label();
            this.Encrypt = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Label();
            this.decrypttxt = new System.Windows.Forms.TextBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.encrypttxt = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Location = new System.Drawing.Point(246, 83);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(75, 23);
            this.btnEncrypt.TabIndex = 0;
            this.btnEncrypt.Text = "Encrypt";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click_1);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Location = new System.Drawing.Point(246, 112);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(75, 23);
            this.btnDecrypt.TabIndex = 1;
            this.btnDecrypt.Text = "Decrypt";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click_1);
            // 
            // Value
            // 
            this.Value.AutoSize = true;
            this.Value.Location = new System.Drawing.Point(12, 8);
            this.Value.Name = "Value";
            this.Value.Size = new System.Drawing.Size(59, 13);
            this.Value.TabIndex = 2;
            this.Value.Text = "Enter Text:";
            // 
            // Encrypt
            // 
            this.Encrypt.AutoSize = true;
            this.Encrypt.Location = new System.Drawing.Point(25, 34);
            this.Encrypt.Name = "Encrypt";
            this.Encrypt.Size = new System.Drawing.Size(46, 13);
            this.Encrypt.TabIndex = 3;
            this.Encrypt.Text = "Encrypt:";
            // 
            // Decrypt
            // 
            this.Decrypt.AutoSize = true;
            this.Decrypt.Location = new System.Drawing.Point(24, 60);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(47, 13);
            this.Decrypt.TabIndex = 4;
            this.Decrypt.Text = "Decrypt:";
            // 
            // decrypttxt
            // 
            this.decrypttxt.Location = new System.Drawing.Point(77, 57);
            this.decrypttxt.Name = "decrypttxt";
            this.decrypttxt.Size = new System.Drawing.Size(244, 20);
            this.decrypttxt.TabIndex = 5;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(77, 5);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(244, 20);
            this.txtValue.TabIndex = 6;
            // 
            // encrypttxt
            // 
            this.encrypttxt.Location = new System.Drawing.Point(77, 31);
            this.encrypttxt.Name = "encrypttxt";
            this.encrypttxt.Size = new System.Drawing.Size(244, 20);
            this.encrypttxt.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(15, 83);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 23);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save Encrypted Text";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 146);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.encrypttxt);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.decrypttxt);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.Encrypt);
            this.Controls.Add(this.Value);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Encrypt&Decrypt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label Value;
        private System.Windows.Forms.Label Encrypt;
        private System.Windows.Forms.Label Decrypt;
        private System.Windows.Forms.TextBox decrypttxt;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.TextBox encrypttxt;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

