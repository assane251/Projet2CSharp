namespace Projet2CSharp
{
    partial class frmVilleComboBox
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
            this.btnToutSupprimer = new System.Windows.Forms.Button();
            this.btnSupprimer = new System.Windows.Forms.Button();
            this.btnValider = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbVille = new System.Windows.Forms.ComboBox();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnToutSupprimer
            // 
            this.btnToutSupprimer.Location = new System.Drawing.Point(282, 139);
            this.btnToutSupprimer.Name = "btnToutSupprimer";
            this.btnToutSupprimer.Size = new System.Drawing.Size(131, 41);
            this.btnToutSupprimer.TabIndex = 3;
            this.btnToutSupprimer.Text = "&Tout Supprimer";
            this.btnToutSupprimer.UseVisualStyleBackColor = true;
            this.btnToutSupprimer.Click += new System.EventHandler(this.btnToutSupprimer_Click);
            // 
            // btnSupprimer
            // 
            this.btnSupprimer.Location = new System.Drawing.Point(282, 81);
            this.btnSupprimer.Name = "btnSupprimer";
            this.btnSupprimer.Size = new System.Drawing.Size(131, 41);
            this.btnSupprimer.TabIndex = 2;
            this.btnSupprimer.Text = "&Supprimer";
            this.btnSupprimer.UseVisualStyleBackColor = true;
            this.btnSupprimer.Click += new System.EventHandler(this.btnSupprimer_Click);
            // 
            // btnValider
            // 
            this.btnValider.Location = new System.Drawing.Point(282, 23);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(131, 41);
            this.btnValider.TabIndex = 1;
            this.btnValider.Text = "V&alider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Saisir une ville";
            // 
            // cbbVille
            // 
            this.cbbVille.FormattingEnabled = true;
            this.cbbVille.Location = new System.Drawing.Point(27, 66);
            this.cbbVille.Name = "cbbVille";
            this.cbbVille.Size = new System.Drawing.Size(201, 28);
            this.cbbVille.TabIndex = 9;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(282, 197);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(131, 41);
            this.btnQuitter.TabIndex = 4;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // frmVilleComboBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 265);
            this.ControlBox = false;
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.cbbVille);
            this.Controls.Add(this.btnToutSupprimer);
            this.Controls.Add(this.btnSupprimer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.label1);
            this.Name = "frmVilleComboBox";
            this.Text = "frmVilleComboBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnToutSupprimer;
        private System.Windows.Forms.Button btnSupprimer;
        private System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbVille;
        private System.Windows.Forms.Button btnQuitter;
    }
}