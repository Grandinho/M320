using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vererbung
{
    public abstract class Person
    {
        //prop
        public string m_Name { get; set; }
        public string m_Vorname { get; set; }

        //constructor
        public Person(string name, string vorname)
        {
            this.m_Name = name;
            this.m_Vorname = vorname;
        }

        public virtual void Datenausgabe()
        {
            

        } 

    }
}
