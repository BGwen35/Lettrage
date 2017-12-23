using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Lettrage
{
    class Lettreur
    {
        public List<Valeur> liste = new List<Valeur>();
        private int profondeur = 5;
        private decimal total = 0;
        private decimal cible = 0;
        private int depart = 0;
        private int fin = 0;
        private bool termine = false;
        internal void AjouterValeur(decimal v)
        {
            liste.Add(new Valeur(v));
        }

        internal object GetTotalSerie()
        {
            decimal total = 0;
            foreach (Valeur val in liste)
            {
                total = total + val.value;
            }
            return total;
        }

        internal bool Lettrer(decimal value)
        {

            InitialiserListe();
            if (!InitiliserCalcul(value)) return false;

            if (!Recursivite(depart))
            {
                MessageBox.Show("Aucun rapprochement trouvé");
                return false;
            }

            return true;
        }

        private bool InitiliserCalcul(decimal pCible)
        {
            total = 0;
            profondeur = 5;
            cible = pCible;
            depart = 0;
            fin = liste.Count - 1;
            termine = false;

            // controle nb valeurs > 1
            if (liste.Count < 2)
            {
                MessageBox.Show("la liste doit comporter au moins 2 valeurs");
                return false;
            }

            // ctrl que la cible est atteignable : somme des valeurs positive > cible
            decimal totalTmp = 0;
            foreach (Valeur val in liste)
            {
                if (val.value > 0) totalTmp = totalTmp + val.value;
            }
            if (totalTmp < cible)
            {
                MessageBox.Show("la cible n'est pas atteignable");
                return false;
            }

            // recherche profondeur = nb valeur max nécessaire pour atteindre la cible
            List<decimal> valeursTriees = (from Valeur v in liste where v.value != 0 orderby v.value select v.value).ToList<decimal>();
            totalTmp = 0;
            profondeur = 1;
            while (totalTmp < cible && profondeur < valeursTriees.Count)
            {
                totalTmp = totalTmp + valeursTriees[profondeur-1];
                profondeur = profondeur + 1;
            }
            return true;
        }

        private void InitialiserListe()
        {
            foreach (Valeur val in liste)
            {
                val.Selected = false;
            }
        }

        private bool Recursivite(int debut)
        {

            profondeur = profondeur - 1;

            for (int i = debut; i <= fin; i++)
            {
                Valeur cell = liste[i];
                if (cell.Selected) continue;
                if (cell.value == 0) continue;

                cell.Selected = true;
                total = total + cell.value;

                if (total == cible)
                {
                    termine = true;
                    return true;
                }

                if (profondeur > 0) Recursivite(i);
                if (termine) return true;

                cell.Selected = false;
                total = total - cell.value;
            }

            profondeur = profondeur + 1;

            return false;
        }

    }
}
