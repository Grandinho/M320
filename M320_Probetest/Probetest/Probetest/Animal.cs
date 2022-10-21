using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probetest
{
    class Animal
    {
        public string _AnimalClass { get; set; }
        public string _ScientificName { get; set; }

        public Animal()
        {
   
        }
        public Animal(string scientificName, string animalClass)
        {
            this._AnimalClass = animalClass;
            this._ScientificName = scientificName;
        }

        public virtual string getPhoneticSound()
        {
            return "";
        }

        public virtual void getInfos()
        {
            Console.Write($"Hi my Scientific name is {_ScientificName}, my Animal class is {_AnimalClass}");
        }
    }
}
