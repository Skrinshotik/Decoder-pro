using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Decoder_pro
{
    public partial class RSA_Form : Form
    {
        public RSA_Form()
        {
            InitializeComponent();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            string message = message_text.Text;
            string key1 = key1_text.Text;
            string key2 = key2_text.Text;
            List<string> mess = new List<string>{message};

            encrypted_text.Text = rsa.Decipher(mess, key1, key2);
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            List<string> mess = new List<string>();
            RSA rsa = new RSA();
            string message = message_text.Text;
            string key1 = key1_text.Text;
            string key2 = key2_text.Text;

            mess = rsa.Encrypt(message, key1, key2);
            for (int i = 0; i < mess.Count; i++)
            {
                encrypted_text.Text += mess[i];
            }
        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close();
        }
    }
}