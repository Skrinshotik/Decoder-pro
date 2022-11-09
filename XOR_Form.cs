using Decoder_pro;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Decoder_pro
{
    public partial class XOR_Form : Form
    {
        public XOR_Form()
        {
            InitializeComponent();
        }

        private void cifer_name_Click(object sender, EventArgs e)
        {

        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close(); 

        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (key_text.Text != "" && message_text.Text != "" ) // если лейблы с ключем и текстом не пусты
            {
                XORCipher xor = new XORCipher();    
                string x = xor.Decrypt(message_text.Text, key_text.Text); // расшифровываем текст 
                encrypted_text.Text = x;  // выводим
            }
           
            else MessageBox.Show("Введите значение ключа или текста");
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (key_text.Text != "" && message_text.Text != "" && key_text.TextLength <= message_text.TextLength) // если лейблы с ключем и текстом не пусты
            {
                XORCipher xor = new XORCipher();
                string x = xor.Encrypt(message_text.Text, key_text.Text); // шифруем текст 
                encrypted_text.Text = x; // выводим
            }
            else if (key_text.TextLength > message_text.TextLength) MessageBox.Show("Значение ключа по размерам должно быть не больше размера текста");
            else MessageBox.Show("Введите значение ключа или текста");
        }
    }
}
