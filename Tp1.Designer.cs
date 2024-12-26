namespace Projet2CSharp
{
    partial class frmTp1
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
            this.txtNomPrenom = new System.Windows.Forms.TextBox();
            this.btnCliquez = new System.Windows.Forms.Button();
            this.Fin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entrez votre nom et prenom SVP";
            // 
            // txtNomPrenom
            // 
            this.txtNomPrenom.Location = new System.Drawing.Point(229, 74);
            this.txtNomPrenom.Name = "txtNomPrenom";
            this.txtNomPrenom.Size = new System.Drawing.Size(269, 26);
            this.txtNomPrenom.TabIndex = 1;
            // 
            // btnCliquez
            // 
            this.btnCliquez.Location = new System.Drawing.Point(131, 160);
            this.btnCliquez.Name = "btnCliquez";
            this.btnCliquez.Size = new System.Drawing.Size(120, 45);
            this.btnCliquez.TabIndex = 2;
            this.btnCliquez.Text = "&Cliquez";
            this.btnCliquez.UseVisualStyleBackColor = true;
            this.btnCliquez.Click += new System.EventHandler(this.btnCliquez_Click);
            // 
            // Fin
            // 
            this.Fin.Location = new System.Drawing.Point(333, 160);
            this.Fin.Name = "Fin";
            this.Fin.Size = new System.Drawing.Size(120, 45);
            this.Fin.TabIndex = 3;
            this.Fin.Text = "&Fin";
            this.Fin.UseVisualStyleBackColor = true;
            this.Fin.Click += new System.EventHandler(this.Fin_Click);
            // 
            // frmTp1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 266);
            this.ControlBox = false;
            this.Controls.Add(this.Fin);
            this.Controls.Add(this.btnCliquez);
            this.Controls.Add(this.txtNomPrenom);
            this.Controls.Add(this.label1);
            this.Name = "frmTp1";
            this.Text = "Tp1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNomPrenom;
        private System.Windows.Forms.Button btnCliquez;
        private System.Windows.Forms.Button Fin;
    }
}