using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decoder_pro
{
    public partial class Vigenere_Form : Form
    {
        public Vigenere_Form()
        {
            
            InitializeComponent();
        }
       
        private void decrypt_button_Click(object sender, EventArgs e)
        {
            if (key_text.Text != "" && message_text.Text != "") // если лейблы с ключем и текстом не пусты
            {
                var cipher = new VigenereCipher(); 
                int language = 1; 
                if (radioButton1.Checked == true) language = 1; // выбор языка с помощью кружков
                else language = 2;
                switch (language)
                {
                    case 1:
                        cipher = new VigenereCipher();
                        encrypted_text.Text = cipher.Decrypt(message_text.Text.ToUpper(), key_text.Text.ToUpper());
                        break;
                    case 2:
                        cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
                        encrypted_text.Text = cipher.Decrypt(message_text.Text.ToUpper(), key_text.Text.ToUpper());
                        break;
                }
            }
            else MessageBox.Show("Введите значение ключа или текста");

        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {
            if (key_text.Text != "" && message_text.Text != "") // если лейблы с ключем и текстом не пусты
            {
                var cipher = new VigenereCipher();
                int language = 1;
                if (radioButton1.Checked == true) language = 1; // выбор языка с помощью кружков
                else language = 2;
                switch (language)
                {
                    case 1:
                        cipher = new VigenereCipher();
                        encrypted_text.Text = cipher.Encrypt(message_text.Text.ToUpper(), key_text.Text.ToUpper()); // шифруем текст и выводим
                        break;
                    case 2:
                        cipher = new VigenereCipher("АБВГДЕЁЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ");
                        encrypted_text.Text = cipher.Encrypt(message_text.Text.ToUpper(), key_text.Text.ToUpper()); // расшифровываем текст и выводим
                        break;         
                }                      
            }
            else MessageBox.Show("Введите значение ключа или текста");
        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close();
        }
    }
}
