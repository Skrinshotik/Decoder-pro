using Simias.Encryption;
using System.Runtime.CompilerServices;
using System.Text;

namespace Decoder_pro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            Program.main_form = this;
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
            /*
             * “”“ œ–Œœ»—¿“‹ ¬Œ«¬–¿“ Õ¿ √À¿¬Õ”ﬁ ‘Œ–Ã”!!!
             */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Visible = false;
            FormVigenere frm = new FormVigenere();
            frm.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Visible = false;
            XOR_Form frm = new XOR_Form();
            frm.Visible = true;
        }
    }
}