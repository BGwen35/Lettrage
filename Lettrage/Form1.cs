using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lettrage
{
    public partial class Form1 : Form
    {

        Lettreur lettreur = new Lettreur();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLettrage_Click(object sender, EventArgs e)
        {
            lblAvancement.Text = "Lettrage en cours...";
            txtResultat.Clear();

            if (lettreur.Lettrer(txtCible.Value))
            {

                StringBuilder strings = new StringBuilder();
                foreach (Valeur val in lettreur.liste)
                {
                    if (val.Selected)
                    {
                        strings.AppendLine("                   > " + val.value.ToString());
                    }
                    else
                    {
                        strings.AppendLine(val.value.ToString());
                    }
                }
                txtResultat.Text = strings.ToString();
            }

            lblAvancement.Text = "Lettrage terminé !";
        }

        private void txtListe_TextChanged(object sender, EventArgs e)
        {
            InitialiserLettreur();
        }

        private void InitialiserLettreur()
        {
            lettreur.liste.Clear();

            foreach (string item in txtListe.Lines)
            {
                if (string.IsNullOrEmpty(item.Trim())) continue;
                try
                {
                    lettreur.AjouterValeur(Convert.ToDecimal(item));
                }
                catch (Exception)
                {
                    lettreur.AjouterValeur(0);
                }

            }

            txtTotalListe.Text = lettreur.GetTotalSerie().ToString();

            if (lettreur.liste.Count > 0)
            {
                btnLettrage.Enabled = true;
                lblAvancement.Text = "";
            }
            else {
                btnLettrage.Enabled = false;
                lblAvancement.Text = "<- renseigner la liste";
            }
        }
    }

}
