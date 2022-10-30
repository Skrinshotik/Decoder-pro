using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Text;

namespace Decoder_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void button1_Click(object sender, EventArgs e)
        {
            var x = new XORCipher();
            var message = textBox1.Text;
            var pass = textBox2.Text;
            var encryptedMessageByPass = x.Encrypt(message, pass);
            textBox3.Text = encryptedMessageByPass;
            textBox4.Text = x.Decrypt(encryptedMessageByPass, pass);
        }

        public class XORCipher
        {
            //генератор повторений пароля
            private string GetRepeatKey(string s, int n)
            {
                var r = s;
                while (r.Length < n)
                {
                    r += r;
                }

                return r.Substring(0, n);
            }
            //метод шифрования/дешифровки
            private string Cipher(string text, string secretKey)
            {
                var currentKey = GetRepeatKey(secretKey, text.Length);
                var res = string.Empty;
                for (var i = 0; i < text.Length; i++)
                {
                    res += ((char)(text[i] ^ currentKey[i])).ToString();
                }

                return res;
            }

            //шифрование текста
            public string Encrypt(string plainText, string password)
                => Cipher(plainText, password);

            //расшифровка текста
            public string Decrypt(string encryptedText, string password)
                => Cipher(encryptedText, password);
        }

        public void button2_Click(object sender, EventArgs e)
        {
            var x = new XORCipher();
            var message = textBox1.Text;
            var pass = textBox2.Text;
            var encryptedMessageByPass = x.Encrypt(message, pass);
            
        }
    }
}