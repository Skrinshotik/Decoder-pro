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

        private void DecoderPro_label_Click(object sender, EventArgs e)
        {

            XOR_Form frm = new XOR_Form();
            frm.Show();
            Hide();
            /*
             * ��� ��������� ������� �� ������� �����!!!
             */
        }

        private void sym_button_Click(object sender, EventArgs e)
        {
            Visible = false;
            Sym_Choose_Form sym_Choose_Form = new Sym_Choose_Form();
            sym_Choose_Form.Visible = true;
        }
    }
}