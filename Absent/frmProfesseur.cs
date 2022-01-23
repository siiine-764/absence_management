using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Absent
{
    public partial class frmProfesseur : Form
    {
        string cs = ConfigurationManager.ConnectionStrings["db1"].ConnectionString;
        SqlConnection cn;
        DataSet ds = new DataSet();
        SqlCommand cmdProfesseur;
        SqlDataAdapter daProfesseur;
        BindingSource BsProfesseur = new BindingSource();

        SqlCommand cmdClasse;
        SqlDataAdapter daClasse;
        BindingSource BsClasse = new BindingSource();

        SqlCommand cmdStagiaire;
        SqlDataAdapter daStagiaire;
        BindingSource BsStagiaire = new BindingSource();
        public frmProfesseur()
        {
            InitializeComponent();
        }
        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice VideoCapture;
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Professeur_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
            {
                cbCamera.Items.Add(filterInfo.Name);
                cbCamera.SelectedIndex = 0;
            }

            cs = ConfigurationManager.ConnectionStrings["db1"].ConnectionString;
            cn = new SqlConnection(cs);
            cn.Open();
            cmdProfesseur = new SqlCommand("select * from Professeur", cn);
            daProfesseur = new SqlDataAdapter(cmdProfesseur);
            daProfesseur.Fill(ds, "Professeur");
            BsProfesseur.DataSource = ds;
            BsProfesseur.DataMember = "Professeur";

            txtNom.DataBindings.Add("text", BsProfesseur, "nomP");
            textprenom.DataBindings.Add("text", BsProfesseur, "prenomP");
            txtcin.DataBindings.Add("text", BsProfesseur, "cinP");
            txtMatiere.DataBindings.Add("text", BsProfesseur, "idM");


            cmdClasse = new SqlCommand("select * from Classe", cn);
            daClasse = new SqlDataAdapter(cmdClasse);
            daClasse.Fill(ds, "Classe");
            BsClasse.DataSource = ds;
            BsClasse.DataMember = "Classe";
            cbClasse.DataSource = BsClasse;
            cbClasse.DisplayMember = "nomC";
            cbClasse.ValueMember = "idC";

            cmdStagiaire = new SqlCommand("select * from Stagiaire", cn);
            daStagiaire = new SqlDataAdapter(cmdStagiaire);
            daStagiaire.Fill(ds, "Stagiaire");
            DataColumn r1 = ds.Tables["Classe"].Columns["idC"];
            DataColumn r2 = ds.Tables["Stagiaire"].Columns["idC"];
            DataRelation r = new DataRelation("fk", r1, r2);
            ds.Relations.Add(r);
            BsStagiaire.DataSource = BsClasse;
            BsStagiaire.DataMember = "fk";

            listBox1.DataSource = BsStagiaire;
            listBox1.DisplayMember = "cinS";
            listBox1.ValueMember = "cinS";


        }


        private void button3_Click(object sender, EventArgs e)
        {
            VideoCapture = new VideoCaptureDevice(FilterInfoCollection[cbCamera.SelectedIndex].MonikerString);
            VideoCapture.NewFrame += VideoCapture_newFrame;
            VideoCapture.Start();
            timer1.Start();
        }
        private void VideoCapture_newFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Professeur_FormClosed(object sender, FormClosedEventArgs e)
        {
            /*if (VideoCapture.IsRunning)
            {
                VideoCapture.Stop();
            }*/
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox1.Image);
                if (result != null)
                {
                    textCNE.Text = result.ToString();
                    timer1.Stop();
                    if (VideoCapture.IsRunning)
                    {
                        VideoCapture.Stop();
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmNewQR r = new frmNewQR();
            r.ShowDialog();
        }


        private void textCNE_TextChanged(object sender, EventArgs e)
        {
            BsStagiaire.Filter = "cinS like '%" + textCNE.Text + "%'";
            if (listBox1.SelectedItem != null)
            {
                listBox2.Items.Add(listBox1.Text);
                //listBox1.Items.Remove(listBox1.SelectedItem);
            }


            //SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["db"].ConnectionString);
            //cn.Open();
            //SqlCommand cmd = new SqlCommand("insert into seance values(@cin,@s,@c,@m)", cn);

            //cmd.Parameters.Add(new SqlParameter("@cin", ));
            //cmd.Parameters.Add(new SqlParameter("@s", ));
            //cmd.Parameters.Add(new SqlParameter("@c", ));
            //cmd.Parameters.Add(new SqlParameter("@m", ));



            //cmd.ExecuteNonQuery();

            //cn.Close();
            //cn = null;
            //cmd = null;

            //MessageBox.Show("absence ajoutée avec succes");


        }

    }
}
