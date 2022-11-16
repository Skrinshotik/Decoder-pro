using System.Runtime.CompilerServices;
using System.Text;

namespace Decoder_pro
{
    public partial class Sym_Choose_Form : Form
    {
        public Sym_Choose_Form()
        {
            InitializeComponent();
        }

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {
            Program.main_form.Visible = true;
            this.Close();
        }

        private void Vigenere_button_Click(object sender, EventArgs e)
        {
            Vigenere_Form cipher_form = new Vigenere_Form();
            cipher_form.Visible = true;
            this.Close();
        }

        private void XOR_button_Click(object sender, EventArgs e)
        {
            XOR_Form cipher_form = new XOR_Form();
            cipher_form.Visible = true;
            this.Close();
        }

        private void DES_button_Click(object sender, EventArgs e)
        {
            DES_Form cipher_form = new DES_Form();
            cipher_form.Visible = true;
            this.Close();
        }

        private void RC5_button_Click(object sender, EventArgs e)
        {
            RC5_Form cipher_form = new RC5_Form();
            cipher_form.Visible = true;
            this.Close();
        }

        private void BlowFish_button_Click(object sender, EventArgs e)
        {
            BlowFish_Form cipher_form = new BlowFish_Form();
            cipher_form.Visible = true;
            this.Close();
        }

        private void AES_button_Click(object sender, EventArgs e)
        {
            AES_Form cipher_form = new AES_Form();
            cipher_form.Visible = true;
            this.Close();
        }
    }
}