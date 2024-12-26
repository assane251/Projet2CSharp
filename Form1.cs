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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("Bienvenu {0} {1}, votre email est {2}", txtPrenom.Text, txtNom.Text, txtEmail.Text));
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtNom.Focus();
        }
    }
}
