using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Student: Person
    {
        public bool IsChilled { get; set; }

        public Student(int id, string name, bool isChilled): base(id, name)
        {

        }

        public override void Output()
        {
            if (IsChilled) Console.WriteLine("Jugendlicher {0} sagt: Boaa eyy voll krasss ", Name);
            else Console.WriteLine("Jugendlicher {0} sagt: Hau ab",Name);
        }
    }
}
