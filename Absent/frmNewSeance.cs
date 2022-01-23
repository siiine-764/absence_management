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
    public partial class frmNewSeance : Form
    {
        public frmNewSeance()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmNewMatiere m = new frmNewMatiere();
            m.ShowDialog();
            this.matiereTableAdapter.Fill(miniProjetAdoDotNetDataSet.Matiere);
        }

        private void classeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.classeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.miniProjetAdoDotNetDataSet);

        }

        private void frmNewSéance_Load(object sender, EventArgs e)
        {
            // TODO: cette ligne de code charge les données dans la table 'miniProjetAdoDotNetDataSet.Seance'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            //this.seanceTableAdapter.Fill(this.miniProjetAdoDotNetDataSet.Seance);
            // TODO: cette ligne de code charge les données dans la table 'miniProjetAdoDotNetDataSet.Matiere'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.matiereTableAdapter.Fill(this.miniProjetAdoDotNetDataSet.Matiere);
            // TODO: cette ligne de code charge les données dans la table 'miniProjetAdoDotNetDataSet.Classe'. Vous pouvez la déplacer ou la supprimer selon les besoins.
            this.classeTableAdapter.Fill(this.miniProjetAdoDotNetDataSet.Classe);

        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            cn.Open();
            SqlCommand cmd = new SqlCommand("insert into seance values(@c,@m,@t,@d)", cn);

            cmd.Parameters.Add(new SqlParameter("@c", classeComboBox.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@m", matiereComboBox.SelectedValue));
            cmd.Parameters.Add(new SqlParameter("@t", txtTemp.Text));
            cmd.Parameters.Add(new SqlParameter("@d", dtpSeance.Text));


            cmd.ExecuteNonQuery();

            cn.Close();
            cn = null;
            cmd = null;

            MessageBox.Show("séance ajoutée avec succes");

            txtTemp.Clear();
            dtpSeance.Value = DateTime.Today;

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
            btnValider.BackColor = Color.Gray;
            btnValider.ForeColor = Color.White;
        }

        private void btnValider_MouseLeave(object sender, EventArgs e)
        {
            btnValider.BackColor = Color.Black;
            btnValider.ForeColor = Color.White;
        }
    }
}
