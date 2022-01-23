using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace Absent
{
    public partial class frmNewClasse : Form
    {
        public frmNewClasse()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            if (txtNomClasse.Text == "")
                lblErreur.Visible = true;
            else
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into classe values(@n)", cn);

                cmd.Parameters.Add(new SqlParameter("@n", txtNomClasse.Text));

                cmd.ExecuteNonQuery();

                cn.Close();
                cn = null;
                cmd = null;

                lblErreur.Visible = false;
                MessageBox.Show("classe ajoutée avec succes");

                txtNomClasse.Clear();
                txtNomClasse.Focus();
            }
        }


        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_MouseEnter(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.LightGray;
            btnValider.ForeColor = Color.Black;
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

        private void btnValider_MouseLeave(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.Black;
            btnValider.ForeColor = Color.White;
        }

        private void txtNomClasse_MouseLeave(object sender, EventArgs e)
        {
            txtNomClasse.BackColor = Color.White;
        }

        private void txtNomClasse_MouseEnter(object sender, EventArgs e)
        {
            txtNomClasse.BackColor = Color.LightGray;
            lblErreur.Visible = false;
        }

       
    }
}
