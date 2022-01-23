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
    public partial class frmNewProf : Form
    {
        public frmNewProf()
        {
            InitializeComponent();
        }

        private void NewProf_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'miniProjetAdoDotNetDataSet.Matiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.matiereTableAdapter.Fill(this.miniProjetAdoDotNetDataSet.Matiere);

            matiereComboBox.SelectedIndex = -1;
            matiereComboBox.SelectedIndex = 0;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNewMatiere n = new frmNewMatiere();
            n.ShowDialog();
            this.matiereTableAdapter.Fill(miniProjetAdoDotNetDataSet.Matiere);
        }


        private void btnValider_Click(object sender, EventArgs e)
        {
            bool v = true;
            if (txtNom.Text == "")
            {
                MessageBox.Show("nom est vide !");
                txtNom.Focus();
                v = false;
            }
            else if (txtPrenom.Text == "")
            {
                MessageBox.Show("prénom est vide !");
                txtPrenom.Focus();
                v = false;
            }

            else if (txtCin.Text == "")
            {
                MessageBox.Show("cin est vide !");
                txtCin.Focus();
                v = false;
            }

            if (v)
            {
                SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
                cn.Open();
                SqlCommand cmd = new SqlCommand("insert into professeur(cinP,nomP,prenomP,idM) values(@c,@n,@p,@m)", cn);

                cmd.Parameters.Add(new SqlParameter("@c", txtCin.Text));
                cmd.Parameters.Add(new SqlParameter("@n", txtNom.Text));
                cmd.Parameters.Add(new SqlParameter("@p", txtPrenom.Text));
                cmd.Parameters.Add(new SqlParameter("@m", matiereComboBox.SelectedValue));


                cmd.ExecuteNonQuery();

                cn.Close();
                cn = null;
                cmd = null;

                MessageBox.Show("professeur ajoutée avec succes");

                txtNom.Clear();
                txtNom.Focus();
                txtPrenom.Clear();
                txtCin.Clear();
                matiereComboBox.SelectedIndex = 0;

            }
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnValider_MouseEnter(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.LightGray;
            btnValider.ForeColor = Color.Black;
        }

        private void txtNom_Enter(object sender, EventArgs e)
        {
            txtNom.BackColor = Color.LightGray;
        }

        private void txtPrenom_Enter(object sender, EventArgs e)
        {
            txtPrenom.BackColor= Color.LightGray;
        }

        private void txtCin_Enter(object sender, EventArgs e)
        {
            txtCin.BackColor = Color.LightGray;
        }

        private void txtNom_Leave(object sender, EventArgs e)
        {
            txtNom.BackColor = Color.White;
        }

        private void txtPrenom_Leave(object sender, EventArgs e)
        {
            txtPrenom.BackColor = Color.White;
        }

        private void txtCin_Leave(object sender, EventArgs e)
        {
            txtCin.BackColor = Color.White;
        }
    
    }
}