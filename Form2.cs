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
    public partial class frmForm2 : Form
    {
        public frmForm2()
        {
            InitializeComponent();
        }

        private void chkNom_Click(object sender, EventArgs e)
        {
            if (chkNom.Checked)
            {
                lstInfo.Items.Add(txtNom.Text);
            }
            else
            {
                lstInfo.Items.Remove(txtNom.Text);
            }
        }

        private void chkPrenom_Click(object sender, EventArgs e)
        {
            if (chkPrenom.Checked)
            {
                lstInfo.Items.Add(txtPrenom.Text);
            }
            else
            {
                lstInfo.Items.Remove(txtPrenom.Text);
            }
        }

        private void chkDateDeNaissance_Click_1(object sender, EventArgs e)
        {
            if (chkDateDeNaissance.Checked)
            {
                lstInfo.Items.Add(txtDateDeNaissance.Text);
            }
            else
            {
                lstInfo.Items.Remove(txtDateDeNaissance.Text);
            }
        }

        private void chkLieuDeNaissance_Click_1(object sender, EventArgs e)
        {
            if (chkLieuDeNaissance.Checked)
            {
                lstInfo.Items.Add(txtLieuDeNaissance.Text);
            }
            else
            {
                lstInfo.Items.Remove(txtLieuDeNaissance.Text);
            }
        }

        private void chkTel_Click_1(object sender, EventArgs e)
        {
            if (chkTel.Checked)
            {
                lstInfo.Items.Add(txtTel.Text);
            }
            else
            {
                lstInfo.Items.Remove(txtTel.Text);
            }
        }
    }
}
