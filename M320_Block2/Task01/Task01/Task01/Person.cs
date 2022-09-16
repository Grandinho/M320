using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task01
{
    class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Person(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public virtual void Output()
        {
            Console.WriteLine("I'm a person");
        }
    }
}
