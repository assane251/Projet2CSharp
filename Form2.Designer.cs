namespace Projet2CSharp
{
    partial class frmForm2
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
            this.chkNom = new System.Windows.Forms.CheckBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.chkPrenom = new System.Windows.Forms.CheckBox();
            this.txtDateDeNaissance = new System.Windows.Forms.TextBox();
            this.chkDateDeNaissance = new System.Windows.Forms.CheckBox();
            this.txtLieuDeNaissance = new System.Windows.Forms.TextBox();
            this.chkLieuDeNaissance = new System.Windows.Forms.CheckBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.chkTel = new System.Windows.Forms.CheckBox();
            this.lstInfo = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chkNom
            // 
            this.chkNom.AutoSize = true;
            this.chkNom.Location = new System.Drawing.Point(25, 33);
            this.chkNom.Name = "chkNom";
            this.chkNom.Size = new System.Drawing.Size(68, 24);
            this.chkNom.TabIndex = 1;
            this.chkNom.Text = "Nom";
            this.chkNom.UseVisualStyleBackColor = true;
            this.chkNom.Click += new System.EventHandler(this.chkNom_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(210, 33);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(176, 26);
            this.txtNom.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(210, 93);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(176, 26);
            this.txtPrenom.TabIndex = 4;
            // 
            // chkPrenom
            // 
            this.chkPrenom.AutoSize = true;
            this.chkPrenom.Location = new System.Drawing.Point(25, 93);
            this.chkPrenom.Name = "chkPrenom";
            this.chkPrenom.Size = new System.Drawing.Size(90, 24);
            this.chkPrenom.TabIndex = 3;
            this.chkPrenom.Text = "Prenom";
            this.chkPrenom.UseVisualStyleBackColor = true;
            this.chkPrenom.Click += new System.EventHandler(this.chkPrenom_Click);
            // 
            // txtDateDeNaissance
            // 
            this.txtDateDeNaissance.Location = new System.Drawing.Point(210, 153);
            this.txtDateDeNaissance.Name = "txtDateDeNaissance";
            this.txtDateDeNaissance.Size = new System.Drawing.Size(176, 26);
            this.txtDateDeNaissance.TabIndex = 6;
            // 
            // chkDateDeNaissance
            // 
            this.chkDateDeNaissance.AutoSize = true;
            this.chkDateDeNaissance.Location = new System.Drawing.Point(25, 153);
            this.chkDateDeNaissance.Name = "chkDateDeNaissance";
            this.chkDateDeNaissance.Size = new System.Drawing.Size(170, 24);
            this.chkDateDeNaissance.TabIndex = 5;
            this.chkDateDeNaissance.Text = "Date de Naissance";
            this.chkDateDeNaissance.UseVisualStyleBackColor = true;
            this.chkDateDeNaissance.Click += new System.EventHandler(this.chkDateDeNaissance_Click_1);
            // 
            // txtLieuDeNaissance
            // 
            this.txtLieuDeNaissance.Location = new System.Drawing.Point(210, 213);
            this.txtLieuDeNaissance.Name = "txtLieuDeNaissance";
            this.txtLieuDeNaissance.Size = new System.Drawing.Size(176, 26);
            this.txtLieuDeNaissance.TabIndex = 8;
            // 
            // chkLieuDeNaissance
            // 
            this.chkLieuDeNaissance.AutoSize = true;
            this.chkLieuDeNaissance.Location = new System.Drawing.Point(25, 213);
            this.chkLieuDeNaissance.Name = "chkLieuDeNaissance";
            this.chkLieuDeNaissance.Size = new System.Drawing.Size(165, 24);
            this.chkLieuDeNaissance.TabIndex = 7;
            this.chkLieuDeNaissance.Text = "Lieu de Naissance";
            this.chkLieuDeNaissance.UseVisualStyleBackColor = true;
            this.chkLieuDeNaissance.Click += new System.EventHandler(this.chkLieuDeNaissance_Click_1);
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(210, 273);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(176, 26);
            this.txtTel.TabIndex = 10;
            // 
            // chkTel
            // 
            this.chkTel.AutoSize = true;
            this.chkTel.Location = new System.Drawing.Point(25, 273);
            this.chkTel.Name = "chkTel";
            this.chkTel.Size = new System.Drawing.Size(56, 24);
            this.chkTel.TabIndex = 9;
            this.chkTel.Text = "Tel";
            this.chkTel.UseVisualStyleBackColor = true;
            this.chkTel.Click += new System.EventHandler(this.chkTel_Click_1);
            // 
            // lstInfo
            // 
            this.lstInfo.FormattingEnabled = true;
            this.lstInfo.ItemHeight = 20;
            this.lstInfo.Location = new System.Drawing.Point(25, 327);
            this.lstInfo.Name = "lstInfo";
            this.lstInfo.Size = new System.Drawing.Size(336, 164);
            this.lstInfo.TabIndex = 10;
            // 
            // frmForm2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 522);
            this.ControlBox = false;
            this.Controls.Add(this.lstInfo);
            this.Controls.Add(this.txtTel);
            this.Controls.Add(this.chkTel);
            this.Controls.Add(this.txtLieuDeNaissance);
            this.Controls.Add(this.chkLieuDeNaissance);
            this.Controls.Add(this.txtDateDeNaissance);
            this.Controls.Add(this.chkDateDeNaissance);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.chkPrenom);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.chkNom);
            this.Name = "frmForm2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkNom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.CheckBox chkPrenom;
        private System.Windows.Forms.TextBox txtDateDeNaissance;
        private System.Windows.Forms.CheckBox chkDateDeNaissance;
        private System.Windows.Forms.TextBox txtLieuDeNaissance;
        private System.Windows.Forms.CheckBox chkLieuDeNaissance;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.CheckBox chkTel;
        private System.Windows.Forms.ListBox lstInfo;
    }
}