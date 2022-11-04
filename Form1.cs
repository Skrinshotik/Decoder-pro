using System.Text;

namespace Decoder_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void decrypt_button_Click(object sender, EventArgs e)
        {
        }

        private void encrypt_button_Click(object sender, EventArgs e)
        {

        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {

            XOR_Form frm = new XOR_Form();
            frm.Show();
            Hide();
            /*
             * “”“ œ–Œœ»—¿“‹ ¬Œ«¬–¿“ Õ¿ √À¿¬Õ”ﬁ ‘Œ–Ã”!!!
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormVigenere frm = new FormVigenere();
            frm.Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            XOR_Form frm = new XOR_Form();
            frm.Show();
            Hide();
        }
    }
}