using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace szyfr_plotowy
{
    public partial class frm_RailFenceCyfer : Form
    {
        public string Rail { get; set; }
        public string PlainText { get; set; }
        public string CipherText { get; set; }

        readonly IRailCipher _railcipher;

        public frm_RailFenceCyfer(IRailCipher railCipher)
        {
            InitializeComponent();

            _railcipher = railCipher;
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            Rail = txbRail.Text;
            PlainText = rtbPlaintext.Text;
            

            if (!string.IsNullOrWhiteSpace(Rail) && int.Parse(Rail) >= 2 && !string.IsNullOrWhiteSpace(PlainText))
            {
                rtbCiphertext.Text = _railcipher.Encrypt(int.Parse(Rail), PlainText);
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            Rail = txbRail.Text;
            CipherText = rtbCiphertext.Text;

            if (!string.IsNullOrWhiteSpace(Rail) && int.Parse(Rail) >= 2 && !string.IsNullOrWhiteSpace(CipherText))
            {
                rtbPlaintext.Text = _railcipher.Decrypt(int.Parse(Rail), CipherText);
            }

        }
    }
}
