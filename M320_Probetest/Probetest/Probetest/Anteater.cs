using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probetest
{
    class Anteater: Animal
    {

        public string _Name { get; set; }

       
        public Anteater()
        {
            this._Name = "not defined";
            this._ScientificName = "cyclopes didactylus";
            this._AnimalClass = "Mamal";
        }
        public Anteater(string name): base()
        {
            this._Name = name;
            this._ScientificName = "cyclopes didactylus";
            this._AnimalClass = "Mamal";
        }

        public override string getPhoneticSound()
        {
            return "Sluuuerf";
        }

        public override void getInfos()
        {
            base.getInfos();
            Console.WriteLine($", my name is {_Name} and i say:{getPhoneticSound()}");
        }

    }
}
