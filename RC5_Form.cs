using Simias.Encryption;
using System.Text;

namespace Decoder_pro
{
    public partial class RC5_Form : Form
    {
        public RC5_Form()
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
            Program.main_form.Visible = true;
            this.Close();
        }
    }
}