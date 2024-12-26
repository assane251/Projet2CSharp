using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projet2CSharp
{
    public partial class frmTp1 : Form
    {
        public frmTp1()
        {
            InitializeComponent();
        }

        private void btnCliquez_Click(object sender, EventArgs e)
        {
            if (txtNomPrenom.Text.Length != 0)
            {
                txtNomPrenom.Enabled = false;
                btnCliquez.Enabled = false;
            } 
            else
            {
                MessageBox.Show("Veuillez saisir votre nom et prénom");
                return;
            }
            
        }

        private void Fin_Click(object sender, EventArgs e)
        {
            if (btnCliquez.Enabled == false)
            {
                MessageBox.Show("Merci " + txtNomPrenom.Text + " d'avoir utilisé notre application");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("Veuillez saisir votre nom et prénom");
                return;
            }
        }
    }
}
