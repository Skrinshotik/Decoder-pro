using Simias.Encryption;
using System.Text;

namespace Decoder_pro
{
    public partial class DES_Form : Form
    {
        public DES_Form()
        {
            InitializeComponent();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            DES des = new DES();
            if ((key_text.Text != "") && (message_text.Text != ""))
            {
                if (key_text.Text.Length == 4)
                {
                    if ((message_text.Text.Length % 8) == 0)
                    {
                        encrypted_text.Text = des.decrypt(key_text.Text, message_text.Text);
                    }
                    else
                    {
                        error_text.Text = "*Проверьте, верно ли введено сообщение";
                        error_text.Visible = true;
                    }
                }
                else
                {
                    error_text.Text = "*размер ключа - 4 символа!";
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
            DES des = new DES();
            if ((key_text.Text != "") && (message_text.Text != ""))
            {
                if (key_text.Text.Length == 4)
                {
                    encrypted_text.Text = des.encrypt(key_text.Text, message_text.Text);
                    encrypted_key.Text = des.encrypt_key(key_text.Text, message_text.Text);
                }
                else
                {
                    error_text.Text = "*размер ключа - 4 символа!";
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
    }
}