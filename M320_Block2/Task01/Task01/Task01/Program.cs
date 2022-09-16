using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p0 = new Student(04, "Karlotta", true);
            Person p1 = new Student(04, "Ludwig-Bernhard", true);
            Person l0 = new Teacher(04, "Lämpel", 259);
            

            List<Person> personen = new List<Person>();
            personen.Add(p0);
            personen.Add(p1);
            personen.Add(l0);
            foreach (Person p in personen)
            {
                p.Output();
            }
            Console.ReadLine();
        }
    }
}
