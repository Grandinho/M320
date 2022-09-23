using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung
{
    public class Mitarbeiter : Person, lFunctions
    {
        //props
        public string m_Firma { get; set; }
        public double m_Lohn { get; set; }

        //Konstruktoren
        public Mitarbeiter(string Name, string Vorname) : base(Name, Vorname)
        {
            this.m_Name = Name;
            this.m_Vorname = Vorname;
        }
        public Mitarbeiter(string Name, string Vorname, double Lohn, string firma) : base(Name, Vorname)
        {
            this.m_Name = Name;
            this.m_Vorname = Vorname;
            this.m_Lohn = Lohn;
            this.m_Firma = firma;
        }
 
        public override void Datenausgabe()
        {
            Console.Write("Name und Vorname: " + m_Name + ", " + m_Vorname);
            Console.WriteLine(" Lohn:" + m_Lohn+ ", Firma:" + m_Firma);
        }



    }
}
