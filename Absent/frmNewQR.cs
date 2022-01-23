using QRCoder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Absent
{
    public partial class frmNewQR : Form
    {
        public frmNewQR()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtCin.Text == "")
                MessageBox.Show("cin est vide !");
            else
            {
                QRCodeGenerator qr = new QRCodeGenerator();
                QRCodeData data = qr.CreateQrCode(txtCin.Text, QRCodeGenerator.ECCLevel.Q);
                QRCode code = new QRCode(data);
                pictureBox1.Image = code.GetGraphic(50);
            }
        }

        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Red;
            btnQuitter.ForeColor = Color.White;
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Black;
            btnQuitter.ForeColor = Color.White;
        }

        private void btnValider_MouseEnter(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.LightGray;
            btnValider.ForeColor = Color.Black;
        }

        private void btnValider_MouseLeave(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.Black;
            btnValider.ForeColor = Color.White;
        }
    }
}
