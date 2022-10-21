using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Probetest
{
    class Human: Animal
    {
        public string _LastName { get; set; }
        public string _FirstName { get; set; }

        public Human()
        {
            this._LastName = "not defined";
            this._FirstName = "not defined";

            this._AnimalClass = "Mamal";
            this._ScientificName = "Homo sapiens";
        }

        public Human(string lastName, string firstName)
        {
            this._LastName = lastName;
            this._FirstName = firstName;

            this._AnimalClass = "Mamal";
            this._ScientificName = "Homo sapiens";

        }

        public override string getPhoneticSound()
        {
            return "bla bla";
        }

        public override void getInfos()
        {
            base.getInfos();
            Console.WriteLine($", my name is {_FirstName} {_LastName} and i say:{getPhoneticSound()}");
        }


    }
}
