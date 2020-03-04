using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sem3_paw
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student(123, 'M', 22, "Gigel",
                new int[3] { 7, 9, 10 });
            Student s3 = (Student)s2.Clone();
            Console.WriteLine(s1);
            s3 = s3 + 7;
            s3 += 10;
            s3++;
            Console.WriteLine(s3);
            s2.SpuneAnNastere();
            Console.WriteLine("Media lui s2 este: " + (float)s2);
            Console.WriteLine("Media lui s3 este: " + s3.CalculeazaMedie());
            Console.WriteLine("A 2-a nota a lui s2: " + s2[1]);
            s3[3] = 5;
            Console.WriteLine(s3);

            List<Student> listaStud = new List<Student>();
            listaStud.Add(s1);
            listaStud.Add(s2);
            listaStud.Add(s3);
            listaStud.Sort();
            foreach (Student s in listaStud)
                Console.WriteLine(s);

            Form1 frm = new Form1();
            frm.ShowDialog();
        }
    }
}
