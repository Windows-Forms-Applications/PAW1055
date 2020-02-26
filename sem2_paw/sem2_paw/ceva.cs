using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem2_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Varsta = 12;
            Console.WriteLine(a1.Varsta);
            Console.WriteLine(a1.ToString());

            Animal a2 = new Animal(12, "Azorel", 23.5f);
            Animal a3 = (Animal)a2.Clone();
            a3.Varsta = 10;
            a3.Nume = "Grivei";

            Elefant e1 = new Elefant(50, "Dumbo", 230, 2, "India");
            Tigru t1 = new Tigru(23, "Sherkan", 100, 80, "bengalez");

            Zoo z1 = new Zoo();
            z1.ListaAnimale.Add(a1);
            z1.ListaAnimale.Add(a2);
            z1.ListaAnimale.Add(a3);
            z1.ListaAnimale.Add(e1);
            z1.ListaAnimale.Add(t1);
            Console.WriteLine(z1);

            Zoo z2 = (Zoo)z1.Clone();
            z2.Denumire += " copie";
            foreach (Animal a in z2.ListaAnimale)
                a.Nume += " copie";
            z1.ListaAnimale.Sort();
            Console.WriteLine(z1);
            z2.ListaAnimale.Sort();
            Console.WriteLine(z2);

            Animal[] vectAnimale = new Animal[5] { a1, a2, a3, e1, t1 };
            Animal[] copie = (Animal[])vectAnimale.Clone();
        }
    }
}
