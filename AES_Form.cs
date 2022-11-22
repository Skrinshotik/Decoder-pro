using Simias.Encryption;
using System.Text;

namespace Decoder_pro
{
    public partial class AES_Form : Form
    {
        public AES_Form()
        {
            InitializeComponent();
        }

        private static byte[] IV = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
        private void decrypt_button_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            if ((key_text.Text != "") && (message_text.Text != ""))
            {
                if (key_text.Text.Length == 16)
                {
                    //if ((message_text.Text.Length % 8) == 0)
                    //{
                        encrypted_text.Text = aes.Decrypt(message_text.Text, key_text.Text, IV);
                    //}
                    //else
                    //{
                        //error_text.Text = "*Проверьте, верно ли введено сообщение";
                        //error_text.Visible = true;
                    //}
                }
                else
                {
                    error_text.Text = "*размер ключа - 16 символов!";
                    error_text.Visible = true;
                }
            }
            else
            {
                error_text.Text = "*введены не все поля!";
                error_text.Visible = true;
            }
            /*string text = key_text.Text;
            byte[] bytes = Encoding.ASCII.GetBytes(text);
            RC5 rc = new RC5(bytes);
            text = message_text.Text;
            text = rc.Decrypt(text);
            encrypted_text.Text = text;*/
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            AES aes = new AES();
            if ((key_text.Text != "") && (message_text.Text != ""))
            {
                if (key_text.Text.Length == 16)
                {
                    if (aes.Encrypt(message_text.Text, key_text.Text, IV) != "Error")
                    {
                        encrypted_text.Text = aes.Encrypt(message_text.Text, key_text.Text, IV);
                    }
                    else
                    {
                        error_text.Text = "*проверьте, правильно ли введён ключ";
                        error_text.Visible = true;
                    }
                }
                else
                {
                    error_text.Text = "*размер ключа - 16 символов!";
                    error_text.Visible = true;
                }
            }
            else
            {
                error_text.Text = "*введены не все поля!";
                error_text.Visible = true;
            }
        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close();
        }

        private void message_text_TextChanged(object sender, EventArgs e)
        {
            error_text.Visible = false;
        }

        private void key_text_TextChanged(object sender, EventArgs e)
        {
            error_text.Visible = false;
        }

        private void key_text_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0') && (e.KeyChar <= '9') || (e.KeyChar == '-') || (e.KeyChar == '.'))
            {

                e.Handled = true;
            }
            else
            {
                return;
            }
        }
    }
}