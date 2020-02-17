using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem1_paw
{
    class Student
    {
        int cod;
        private string nume;
        public int varsta;
        protected float medie;

        public Student()
        {
            this.cod = 0;
            this.nume = "Anonim";
            this.varsta = 0;
            this.medie = 0.0f;
        }

        public Student(int c, string n, int v, float m)
        {
            cod = c;
            nume = n;
            varsta = v;
            medie = m;
        }

        public Student(Student s)
        {
            cod = s.cod;
            nume = s.nume;
            varsta = s.varsta;
            medie = s.medie;
        }

        public string Nume
        {
            get { return nume; }
            set { if (value != null) nume = value; }
        }

        public void afisare()
        {
            Console.WriteLine("Studentul {0} are codul {1}, varsta {2} si media {3}",
                nume, cod, varsta, medie);
        }
    }
}
