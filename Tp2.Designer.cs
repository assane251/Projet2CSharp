namespace Projet2CSharp
{
    partial class frmTp2
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtCapital = new System.Windows.Forms.TextBox();
            this.btnCalculer = new System.Windows.Forms.Button();
            this.btnFin = new System.Windows.Forms.Button();
            this.txtTaux = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInitalisation = new System.Windows.Forms.Button();
            this.txtDuree = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAide = new System.Windows.Forms.Button();
            this.txtMontantCalcule = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Capital";
            // 
            // txtCapital
            // 
            this.txtCapital.Location = new System.Drawing.Point(184, 35);
            this.txtCapital.Name = "txtCapital";
            this.txtCapital.Size = new System.Drawing.Size(147, 26);
            this.txtCapital.TabIndex = 1;
            // 
            // btnCalculer
            // 
            this.btnCalculer.Location = new System.Drawing.Point(390, 29);
            this.btnCalculer.Name = "btnCalculer";
            this.btnCalculer.Size = new System.Drawing.Size(105, 38);
            this.btnCalculer.TabIndex = 5;
            this.btnCalculer.Text = "&Calculer";
            this.btnCalculer.UseVisualStyleBackColor = true;
            this.btnCalculer.Click += new System.EventHandler(this.btnCalculer_Click);
            // 
            // btnFin
            // 
            this.btnFin.Location = new System.Drawing.Point(390, 96);
            this.btnFin.Name = "btnFin";
            this.btnFin.Size = new System.Drawing.Size(105, 38);
            this.btnFin.TabIndex = 6;
            this.btnFin.Text = "&Fin";
            this.btnFin.UseVisualStyleBackColor = true;
            this.btnFin.Click += new System.EventHandler(this.btnFin_Click);
            // 
            // txtTaux
            // 
            this.txtTaux.Location = new System.Drawing.Point(184, 102);
            this.txtTaux.Name = "txtTaux";
            this.txtTaux.Size = new System.Drawing.Size(147, 26);
            this.txtTaux.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Taux";
            // 
            // btnInitalisation
            // 
            this.btnInitalisation.Location = new System.Drawing.Point(390, 163);
            this.btnInitalisation.Name = "btnInitalisation";
            this.btnInitalisation.Size = new System.Drawing.Size(105, 38);
            this.btnInitalisation.TabIndex = 7;
            this.btnInitalisation.Text = "&Initialisation";
            this.btnInitalisation.UseVisualStyleBackColor = true;
            this.btnInitalisation.Click += new System.EventHandler(this.btnInitalisation_Click);
            // 
            // txtDuree
            // 
            this.txtDuree.Location = new System.Drawing.Point(184, 169);
            this.txtDuree.Name = "txtDuree";
            this.txtDuree.Size = new System.Drawing.Size(147, 26);
            this.txtDuree.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Duree";
            // 
            // btnAide
            // 
            this.btnAide.Location = new System.Drawing.Point(390, 230);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(105, 38);
            this.btnAide.TabIndex = 8;
            this.btnAide.Text = "&Aide";
            this.btnAide.UseVisualStyleBackColor = true;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // txtMontantCalcule
            // 
            this.txtMontantCalcule.Enabled = false;
            this.txtMontantCalcule.Location = new System.Drawing.Point(184, 236);
            this.txtMontantCalcule.Name = "txtMontantCalcule";
            this.txtMontantCalcule.Size = new System.Drawing.Size(147, 26);
            this.txtMontantCalcule.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Montant Calcule";
            // 
            // frmTp2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 307);
            this.ControlBox = false;
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.txtMontantCalcule);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnInitalisation);
            this.Controls.Add(this.txtDuree);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnFin);
            this.Controls.Add(this.txtTaux);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculer);
            this.Controls.Add(this.txtCapital);
            this.Controls.Add(this.label1);
            this.Name = "frmTp2";
            this.Text = "Tp2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCapital;
        private System.Windows.Forms.Button btnCalculer;
        private System.Windows.Forms.Button btnFin;
        private System.Windows.Forms.TextBox txtTaux;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInitalisation;
        private System.Windows.Forms.TextBox txtDuree;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.TextBox txtMontantCalcule;
        private System.Windows.Forms.Label label4;
    }
}