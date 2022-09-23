using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung
{
    public class Parteimitglied : Person
    {
        //Prop
        public string m_Partei { get; set; }

        //Konstruktoren
        public Parteimitglied(string Name, string Vorname, string partei) : base(Name, Vorname) {
            this.m_Name = Name;
            this.m_Vorname = Vorname;
            this.m_Partei = partei;
        }
        public Parteimitglied(string Name, string Vorname) : base(Name, Vorname)
        {
            this.m_Name = Name;
            this.m_Vorname = Vorname;
        }
        //Methoden
        public override void Datenausgabe()  {
            Console.Write("Name und Vorname: " + m_Name + " " + m_Vorname);
            Console.WriteLine(", Partei:" + m_Partei);
        }
    }
}
