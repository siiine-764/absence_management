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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeConnecter_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db1"].ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("select * from users where Login like @l and Password like @p", cn);

            cmd.Parameters.Add(new SqlParameter("@l", textLogin.Text));
            cmd.Parameters.Add(new SqlParameter("@p", textPassword.Text));

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                frmMenu f = new frmMenu();
                this.Hide();
                f.ShowDialog();
                this.Close();
            }
            else
                lblErreur.Visible = true;

            cn.Close();
            cn = null;
            dr.Close();
            dr = null;
            cmd = null;
        }

        private void textLogin_Enter(object sender, EventArgs e)
        {
            textLogin.BackColor = Color.LightGray;
        }

        private void textLogin_Leave(object sender, EventArgs e)
        {
            textLogin.BackColor = Color.White;
        }

        private void textPassword_Enter(object sender, EventArgs e)
        {
            textPassword.BackColor = Color.LightGray;
        }

        private void textPassword_Leave(object sender, EventArgs e)
        {
            textPassword.BackColor = Color.White;
        }

        private void btnQuitter_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Red;
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Black;
        }

        private void btnSeConnecter_MouseEnter(object sender, EventArgs e)
        {
            btnSeConnecter.BackColor = Color.LightGray;
            btnSeConnecter.ForeColor = Color.Black;
        }

        private void btnSeConnecter_MouseLeave(object sender, EventArgs e)
        {
            btnSeConnecter.BackColor = Color.Black;
            btnSeConnecter.ForeColor = Color.White;
        }
    }
}