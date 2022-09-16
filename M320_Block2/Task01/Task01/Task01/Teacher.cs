using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Teacher : Person
    {
        public int Salary { get; set; }

        public Teacher(int id, string name, int salary) : base(id, name)
        {
            this.Salary = salary;
        }

        public override void Output()
        {
            Console.WriteLine("Lehrer {0} sagt: Es beliebt mich zu erquicken", Name);
        }
    }
}
