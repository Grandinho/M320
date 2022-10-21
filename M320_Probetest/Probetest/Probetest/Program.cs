using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probetest
{
    class Program
    {
        static void Main(string[] args)
        {
            Anteater ae1 = new Anteater("blue elise");
            Anteater ae2 = new Anteater();

            Human hu = new Human("Meier", "Huberta");
            Animal an = new Animal("Formicidae", "Insects");

            List<Animal> animals = new List<Animal>();

            animals.Add(ae1);
            animals.Add(ae2);
            animals.Add(hu);
            animals.Add(an);

            foreach(Animal a in animals)
            {
                a.getInfos();
            }

            Console.ReadLine();
        }
    }
}
