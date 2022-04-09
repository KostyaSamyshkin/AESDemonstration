namespace AESDemonstration
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblRawText = new System.Windows.Forms.Label();
            this.txtRawText = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtCryptoText = new System.Windows.Forms.TextBox();
            this.lblCryptoText = new System.Windows.Forms.Label();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRawText
            // 
            this.lblRawText.AutoSize = true;
            this.lblRawText.Location = new System.Drawing.Point(12, 15);
            this.lblRawText.Name = "lblRawText";
            this.lblRawText.Size = new System.Drawing.Size(131, 20);
            this.lblRawText.TabIndex = 0;
            this.lblRawText.Text = "Исходный текст";
            // 
            // txtRawText
            // 
            this.txtRawText.Location = new System.Drawing.Point(149, 12);
            this.txtRawText.Multiline = true;
            this.txtRawText.Name = "txtRawText";
            this.txtRawText.Size = new System.Drawing.Size(639, 188);
            this.txtRawText.TabIndex = 1;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(149, 206);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(639, 26);
            this.txtPassword.TabIndex = 2;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(76, 209);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(67, 20);
            this.lblPassword.TabIndex = 3;
            this.lblPassword.Text = "Пароль";
            // 
            // txtCryptoText
            // 
            this.txtCryptoText.Location = new System.Drawing.Point(149, 238);
            this.txtCryptoText.Multiline = true;
            this.txtCryptoText.Name = "txtCryptoText";
            this.txtCryptoText.Size = new System.Drawing.Size(639, 188);
            this.txtCryptoText.TabIndex = 5;
            // 
            // lblCryptoText
            // 
            this.lblCryptoText.AutoSize = true;
            this.lblCryptoText.Location = new System.Drawing.Point(36, 241);
            this.lblCryptoText.Name = "lblCryptoText";
            this.lblCryptoText.Size = new System.Drawing.Size(107, 20);
            this.lblCryptoText.TabIndex = 4;
            this.lblCryptoText.Text = "Шифротекст";
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDecrypt.Location = new System.Drawing.Point(794, 199);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(29, 40);
            this.btnDecrypt.TabIndex = 6;
            this.btnDecrypt.Text = "↑";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEncrypt.Location = new System.Drawing.Point(829, 199);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(29, 40);
            this.btnEncrypt.TabIndex = 7;
            this.btnEncrypt.Text = "↓";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.txtCryptoText);
            this.Controls.Add(this.lblCryptoText);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtRawText);
            this.Controls.Add(this.lblRawText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Демонстрация алгоритма шифрования AES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRawText;
        private System.Windows.Forms.TextBox txtRawText;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtCryptoText;
        private System.Windows.Forms.Label lblCryptoText;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnEncrypt;
    }
}

