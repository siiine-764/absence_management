
namespace Absent
{
    partial class frmMenu
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
            this.btnNewQr = new System.Windows.Forms.Button();
            this.btnScanner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewQr
            // 
            this.btnNewQr.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNewQr.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewQr.ForeColor = System.Drawing.SystemColors.Control;
            this.btnNewQr.Location = new System.Drawing.Point(12, 12);
            this.btnNewQr.Name = "btnNewQr";
            this.btnNewQr.Size = new System.Drawing.Size(275, 37);
            this.btnNewQr.TabIndex = 40;
            this.btnNewQr.Text = "New Qr";
            this.btnNewQr.UseVisualStyleBackColor = false;
            this.btnNewQr.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnScanner
            // 
            this.btnScanner.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnScanner.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanner.ForeColor = System.Drawing.SystemColors.Control;
            this.btnScanner.Location = new System.Drawing.Point(12, 55);
            this.btnScanner.Name = "btnScanner";
            this.btnScanner.Size = new System.Drawing.Size(275, 34);
            this.btnScanner.TabIndex = 41;
            this.btnScanner.Text = "Scanner";
            this.btnScanner.UseVisualStyleBackColor = false;
            this.btnScanner.Click += new System.EventHandler(this.btnScanner_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Gabriola", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(12, 156);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(275, 34);
            this.button1.TabIndex = 42;
            this.button1.Text = "Fermer";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 208);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnScanner);
            this.Controls.Add(this.btnNewQr);
            this.Name = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNewQr;
        private System.Windows.Forms.Button btnScanner;
        private System.Windows.Forms.Button button1;
    }
}