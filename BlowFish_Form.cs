using Simias.Encryption;
using System.Text;

namespace Decoder_pro
{
    public partial class BlowFish_Form : Form
    {
        public BlowFish_Form()
        {
            InitializeComponent();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            string text = key_text.Text;
            Blowfish blowfish = new Blowfish(text);
            text = message_text.Text;
            text = blowfish.Encipher(text);
            encrypted_text.Text = text;
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            string text = key_text.Text;
            Blowfish blowfish = new Blowfish(text);
            text = message_text.Text;
            text = blowfish.Decipher(text);
            encrypted_text.Text = text;
        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close();
        }
    }
}