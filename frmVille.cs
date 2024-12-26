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
    public partial class frmVille : Form
    {
        public frmVille()
        {
            InitializeComponent();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            lstVille.Items.Add(txtVille.Text);
            txtVille.Text = string.Empty;
            txtVille.Focus();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        { 
            lstVille.Items.RemoveAt(lstVille.SelectedIndex);
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
