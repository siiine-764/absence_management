
namespace Absent
{
    partial class frmNewProf
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCin = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.btnAddMat = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.miniProjetAdoDotNetDataSet = new Absent.miniProjetAdoDotNetDataSet();
            this.matiereBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.matiereTableAdapter = new Absent.miniProjetAdoDotNetDataSetTableAdapters.MatiereTableAdapter();
            this.tableAdapterManager = new Absent.miniProjetAdoDotNetDataSetTableAdapters.TableAdapterManager();
            this.matiereComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.miniProjetAdoDotNetDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(72, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom :";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(143, 24);
            this.txtNom.Multiline = true;
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(260, 24);
            this.txtNom.TabIndex = 1;
            this.txtNom.Enter += new System.EventHandler(this.txtNom_Enter);
            this.txtNom.Leave += new System.EventHandler(this.txtNom_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Prénom :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "CIN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = "Matiere :";
            // 
            // txtCin
            // 
            this.txtCin.Location = new System.Drawing.Point(142, 126);
            this.txtCin.Multiline = true;
            this.txtCin.Name = "txtCin";
            this.txtCin.Size = new System.Drawing.Size(260, 24);
            this.txtCin.TabIndex = 9;
            this.txtCin.Enter += new System.EventHandler(this.txtCin_Enter);
            this.txtCin.Leave += new System.EventHandler(this.txtCin_Leave);
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(143, 75);
            this.txtPrenom.Multiline = true;
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(260, 24);
            this.txtPrenom.TabIndex = 10;
            this.txtPrenom.Enter += new System.EventHandler(this.txtPrenom_Enter);
            this.txtPrenom.Leave += new System.EventHandler(this.txtPrenom_Leave);
            // 
            // btnAddMat
            // 
            this.btnAddMat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddMat.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMat.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAddMat.Location = new System.Drawing.Point(409, 169);
            this.btnAddMat.Name = "btnAddMat";
            this.btnAddMat.Size = new System.Drawing.Size(46, 38);
            this.btnAddMat.TabIndex = 14;
            this.btnAddMat.Text = "+";
            this.btnAddMat.UseVisualStyleBackColor = false;
            this.btnAddMat.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnQuitter.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitter.ForeColor = System.Drawing.SystemColors.Control;
            this.btnQuitter.Location = new System.Drawing.Point(249, 233);
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
            this.btnValider.Location = new System.Drawing.Point(105, 233);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(111, 41);
            this.btnValider.TabIndex = 40;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = false;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            this.btnValider.MouseEnter += new System.EventHandler(this.btnValider_MouseEnter);
            this.btnValider.MouseLeave += new System.EventHandler(this.btnValider_MouseLeave);
            // 
            // miniProjetAdoDotNetDataSet
            // 
            this.miniProjetAdoDotNetDataSet.DataSetName = "miniProjetAdoDotNetDataSet";
            this.miniProjetAdoDotNetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // matiereBindingSource
            // 
            this.matiereBindingSource.DataMember = "Matiere";
            this.matiereBindingSource.DataSource = this.miniProjetAdoDotNetDataSet;
            // 
            // matiereTableAdapter
            // 
            this.matiereTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AbsenceTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClasseTableAdapter = null;
            this.tableAdapterManager.MatiereTableAdapter = this.matiereTableAdapter;
            this.tableAdapterManager.ProfesseurTableAdapter = null;
            this.tableAdapterManager.SeanceTableAdapter = null;
            this.tableAdapterManager.StagiaireTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Absent.miniProjetAdoDotNetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // matiereComboBox
            // 
            this.matiereComboBox.DataSource = this.matiereBindingSource;
            this.matiereComboBox.DisplayMember = "nomM";
            this.matiereComboBox.FormattingEnabled = true;
            this.matiereComboBox.Location = new System.Drawing.Point(142, 177);
            this.matiereComboBox.Name = "matiereComboBox";
            this.matiereComboBox.Size = new System.Drawing.Size(261, 21);
            this.matiereComboBox.TabIndex = 42;
            this.matiereComboBox.ValueMember = "idM";
            // 
            // frmNewProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 290);
            this.Controls.Add(this.matiereComboBox);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.btnAddMat);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.txtCin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmNewProf";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NewProf";
            this.Load += new System.EventHandler(this.NewProf_Load);
            ((System.ComponentModel.ISupportInitialize)(this.miniProjetAdoDotNetDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matiereBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCin;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Button btnAddMat;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnValider;
        private miniProjetAdoDotNetDataSet miniProjetAdoDotNetDataSet;
        private System.Windows.Forms.BindingSource matiereBindingSource;
        private miniProjetAdoDotNetDataSetTableAdapters.MatiereTableAdapter matiereTableAdapter;
        private miniProjetAdoDotNetDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox matiereComboBox;
    }
}