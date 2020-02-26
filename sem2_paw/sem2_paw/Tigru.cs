using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Tigru: Animal
    {
        private int viteza;
        private string rasa;

        public Tigru()
            : base()
        {
            viteza = 0;
            rasa = "";
        }

        public Tigru(int v, string n, float g, int vit, string r)
            : base(v, n, g)
        {
            viteza = vit;
            rasa = r;
        }

        public override string ToString()
        {
            return base.ToString()+ " si viteza "+viteza+
                " si rasa "+rasa;
        }
    }
}
