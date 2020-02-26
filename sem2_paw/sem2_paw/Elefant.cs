using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Elefant: Animal
    {
        private int inaltime;
        private string taraOrigine;

        public Elefant()
            : base()
        {
            inaltime = 0;
            taraOrigine = "";
        }

        public Elefant(int v, string n, float g, int h, string t)
            : base(v, n, g)
        {
            inaltime = h;
            taraOrigine = t;
        }

        public override string ToString()
        {
            return base.ToString() + " si inaltimea "+inaltime+
                " si tara de origine "+taraOrigine;
            //string rezultat = "";
            //if (taraOrigine != "")
            //    rezultat += " si tara de origine " + taraOrigine;
            //else
            //    rezultat += "";
            //return rezultat;
        }
    }
}
