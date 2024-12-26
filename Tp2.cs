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
    public partial class frmTp2 : Form
    {
        public frmTp2()
        {
            InitializeComponent();
        }

        private void btnCalculer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCapital.Text) ||
                string.IsNullOrWhiteSpace(txtTaux.Text) ||
                string.IsNullOrWhiteSpace(txtDuree.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                double capital = Convert.ToDouble(this.txtCapital.Text);
                double taux = Convert.ToDouble(this.txtTaux.Text);
                double duree = Convert.ToDouble(this.txtDuree.Text);
                double interet = capital * taux * duree / 100;
                double montant = capital + interet;
                txtMontantCalcule.Text = montant.ToString();
            }
        }

        private void btnFin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMontantCalcule.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs afin de procéder au calcul du montant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Le montant total est de " + txtMontantCalcule.Text, "Montant total", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
            }
        }

        private void btnInitalisation_Click(object sender, EventArgs e)
        {
            txtCapital.Text = string.Empty;
            txtTaux.Text = string.Empty;
            txtDuree.Text = string.Empty;
            txtMontantCalcule.Text = string.Empty;
            txtCapital.Focus();
        }

        private void btnAide_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Calcul d'un montant avec intérêts :\n\n" +
                "   Saisir un capital.\n" +
                "   Saisir un taux (en pourcentage).\n" +
                "   Saisir une durée (en années).\n\n" +
                "Resultat = montant remboursé avec les intérêts.",
                "Aide - Calcul du montant",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

    }
}
