using System;
using System.Text;
using System.Windows.Forms;

namespace AESDemonstration
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void btnEncrypt_Click(object sender, EventArgs e) // Зашифровать текст
        {
            txtCryptoText.Text = AESUtils.Encrypt(txtRawText.Text, txtPassword.Text);
            
            txtRawText.Text = "";
        }

        private void btnDecrypt_Click(object sender, EventArgs e) // Расшифровать текст
        {
            txtRawText.Text = AESUtils.Decrypt(txtCryptoText.Text, txtPassword.Text);
            
            txtCryptoText.Text = "";
        }
    }
}
