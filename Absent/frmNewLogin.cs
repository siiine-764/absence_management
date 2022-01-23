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
    public partial class frmNewLogin : Form
    {
        public frmNewLogin()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            bool v = true;
            if (txtLogin.Text == "")
            {
                MessageBox.Show("login est vide !");
                txtLogin.Focus();
                v = false;
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("password est vide !");
                txtPassword.Focus();
                v = false;
            }
            

            if(v)
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into users values(@l,@p)", cn);

                cmd.Parameters.Add(new SqlParameter("@l", txtLogin.Text));
                cmd.Parameters.Add(new SqlParameter("@p", txtPassword.Text));


                cmd.ExecuteNonQuery();

                cn.Close();
                cn = null;
                cmd = null;

                MessageBox.Show("login ajoutée avec succes");

                txtLogin.Clear();
                txtLogin.Focus();
                txtPassword.Clear();
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

        private void btnValider_MouseLeave(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.Black;
            btnValider.ForeColor = Color.White;
        }

        private void btnQuitter_MouseLeave(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Black;
            btnQuitter.ForeColor = Color.White;
        }

        private void btnQuitter_MouseEnter(object sender, EventArgs e)
        {
            btnQuitter.BackColor = Color.Red;
            btnQuitter.ForeColor = Color.White;
        }

        private void txtLogin_MouseEnter(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.LightGray;
        }

        private void txtPassword_MouseEnter(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.LightGray;
        }

        private void txtLogin_MouseLeave(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.White;
        }

        private void txtPassword_MouseLeave(object sender, EventArgs e)
        {
            txtPassword.BackColor = Color.White;
        }
    }
}
