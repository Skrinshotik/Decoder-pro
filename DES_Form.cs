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
            if ((encrypted_key.Text != "") && (message_text.Text != ""))
            {
                if (encrypted_key.Text.Length == 4)
                {
                    if ((message_text.Text.Length % 8) == 0)
                    {
                        encrypted_text.Text = des.decrypt(encrypted_key.Text, message_text.Text);
                    }
                    else
                    {
                        error_text.Text = "*���������, ����� �� ������� ���������";
                        error_text.Visible = true;
                    }
                }
                else
                {
                    error_text.Text = "*������ ����� - 4 �������!";
                    error_text.Visible = true;
                }
            }
            else
            {
                error_text.Text = "*������� �� ��� ����!";
                error_text.Visible = true;
            }
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
                    error_text.Text = "*������ ����� - 4 �������!";
                    error_text.Visible = true;
                }
            }
            else
            {
                error_text.Text = "*������� �� ��� ����!";
                error_text.Visible = true;
            }
            if ((key_text.Text == "����" || key_text.Text == "����" || key_text.Text == "����") &&
                (message_text.Text == "�����" || message_text.Text == "�����" || message_text.Text == "������" ||
                message_text.Text == "������" || message_text.Text == "�����" || message_text.Text == "������"))

            {
                BackgroundImage = Image.FromFile("../../../Resources/�����������.jpg");
                BackgroundImageLayout = ImageLayout.Stretch;
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