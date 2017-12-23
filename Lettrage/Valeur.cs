using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lettrage
{
    class Valeur
    {
        public decimal value = 0;
        public bool Selected = false;

        public Valeur(decimal v)
        {
            this.value = v;
        }
    }
}
