using System.Text;

namespace Decoder_pro
{
    public partial class RC5_Form : Form
    {
        public RC5_Form()
        {
            InitializeComponent();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            string text = key_text.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            RC5 rc = new RC5(bytes);
            text = message_text.Text;
            text = rc.Decrypt(text);
            encrypted_text.Text = text;
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string text = key_text.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            RC5 rc = new RC5(bytes);
            text = message_text.Text;
            text = rc.Encrypt(text);
            encrypted_text.Text = text;
        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close();
        }
    }
}