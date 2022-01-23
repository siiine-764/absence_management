
namespace Absent
{
    partial class frmNewSeance
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.dtpSeance = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.miniProjetAdoDotNetDataSet = new Absent.miniProjetAdoDotNetDataSet();
            this.classeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classeTableAdapter = new Absent.miniProjetAdoDotNetDataSetTableAdapters.ClasseTableAdapter();
            this.tableAdapterManager = new Absent.miniProjetAdoDotNetDataSetTableAdapters.TableAdapterManager();
            this.matiereTableAdapter = new Absent.miniProjetAdoDotNetDataSetTableAdapters.MatiereTableAdapter();
            this.classeComboBox = new System.Windows.Forms.ComboBox();
            this.matiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matiereComboBox = new System.Windows.Forms.ComboBox();
            this.txtTemp = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.miniProjetAdoDotNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(413, 75);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 33);
            this.button3.TabIndex = 28;
            this.button3.Text = "+";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 21;
            this.label5.Text = "Matiere :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 29);
            this.label3.TabIndex = 19;
            this.label3.Text = "Classe :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(75, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 29);
            this.label2.TabIndex = 18;
            this.label2.Text = "Temp :";
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitter.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Location = new System.Drawing.Point(257, 250);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(111, 41);
            this.btnQuitter.TabIndex = 41;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = false;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            this.btnQuitter.MouseEnter += new System.EventHandler(this.btnQuitter_MouseEnter);
            this.btnQuitter.MouseLeave += new System.EventHandler(this.btnQuitter_MouseLeave);
            // 
            // btnValider
            // 
            this.btnValider.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnValider.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnValider.ForeColor = System.Drawing.SystemColors.Control;
            this.btnValider.Location = new System.Drawing.Point(120, 250);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(111, 41);
            this.btnValider.TabIndex = 40;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            this.btnValider.MouseEnter += new System.EventHandler(this.btnValider_MouseEnter);
            this.btnValider.MouseLeave += new System.EventHandler(this.btnValider_MouseLeave);
            // 
            // dtpSeance
            // 
            this.dtpSeance.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSeance.Location = new System.Drawing.Point(147, 185);
            this.dtpSeance.Name = "dtpSeance";
            this.dtpSeance.Size = new System.Drawing.Size(260, 20);
            this.dtpSeance.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 29);
            this.label1.TabIndex = 43;
            this.label1.Text = "Date :";
            // 
            // miniProjetAdoDotNetDataSet
            // 
            this.miniProjetAdoDotNetDataSet.DataSetName = "miniProjetAdoDotNetDataSet";
            this.miniProjetAdoDotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // classeBindingSource
            // 
            this.classeBindingSource.DataMember = "Classe";
            this.classeBindingSource.DataSource = this.miniProjetAdoDotNetDataSet;
            // 
            // classeTableAdapter
            // 
            this.classeTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbsenceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasseTableAdapter = this.classeTableAdapter;
            this.tableAdapterManager.MatiereTableAdapter = this.matiereTableAdapter;
            this.tableAdapterManager.ProfesseurTableAdapter = null;
            this.tableAdapterManager.SeanceTableAdapter = null;
            this.tableAdapterManager.StagiaireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Absent.miniProjetAdoDotNetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // matiereTableAdapter
            // 
            this.matiereTableAdapter.ClearBeforeFill = true;
            // 
            // classeComboBox
            // 
            this.classeComboBox.DataSource = this.classeBindingSource;
            this.classeComboBox.DisplayMember = "nomC";
            this.classeComboBox.FormattingEnabled = true;
            this.classeComboBox.Location = new System.Drawing.Point(147, 26);
            this.classeComboBox.Name = "classeComboBox";
            this.classeComboBox.Size = new System.Drawing.Size(260, 21);
            this.classeComboBox.TabIndex = 44;
            this.classeComboBox.ValueMember = "idC";
            // 
            // matiereBindingSource
            // 
            this.matiereBindingSource.DataMember = "Matiere";
            this.matiereBindingSource.DataSource = this.miniProjetAdoDotNetDataSet;
            // 
            // matiereComboBox
            // 
            this.matiereComboBox.DataSource = this.matiereBindingSource;
            this.matiereComboBox.DisplayMember = "nomM";
            this.matiereComboBox.FormattingEnabled = true;
            this.matiereComboBox.Location = new System.Drawing.Point(147, 79);
            this.matiereComboBox.Name = "matiereComboBox";
            this.matiereComboBox.Size = new System.Drawing.Size(260, 21);
            this.matiereComboBox.TabIndex = 44;
            this.matiereComboBox.ValueMember = "idM";
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(147, 132);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(260, 20);
            this.txtTemp.TabIndex = 45;
            // 
            // frmNewSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 314);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.matiereComboBox);
            this.Controls.Add(this.classeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSeance);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewSeance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewMatiere";
            this.Load += new System.EventHandler(this.frmNewSéance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniProjetAdoDotNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.DateTimePicker dtpSeance;
        private System.Windows.Forms.Label label1;
        private miniProjetAdoDotNetDataSet miniProjetAdoDotNetDataSet;
        private System.Windows.Forms.BindingSource classeBindingSource;
        private miniProjetAdoDotNetDataSetTableAdapters.ClasseTableAdapter classeTableAdapter;
        private miniProjetAdoDotNetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private miniProjetAdoDotNetDataSetTableAdapters.MatiereTableAdapter matiereTableAdapter;
        private System.Windows.Forms.ComboBox classeComboBox;
        private System.Windows.Forms.BindingSource matiereBindingSource;
        private System.Windows.Forms.ComboBox matiereComboBox;
        private System.Windows.Forms.TextBox txtTemp;
    }
}