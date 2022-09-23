using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung
{
    public class Politiker : Parteimitglied, lFunctions
    {
        //Membervariablen
        public double m_Lohn { get; set; }
        public string m_Rat { get; set; }
        //Konstruktoren
        public Politiker(string Name, string Vorname, double l, string p, string r): base(Name, Vorname, p) {
            this.m_Name = Name;
            this.m_Vorname = Vorname;
            this.m_Lohn = l;
            this.m_Partei = p;
            this.m_Rat = r;
        }
        public Politiker(string Name, string Vorname) : base(Name, Vorname) {
            this.m_Name = Name;
            this.m_Vorname = Vorname;
        }
        
        public override void Datenausgabe() {
            Console.Write("Name und Vorname: " + m_Name + " " + m_Vorname);
            Console.WriteLine(", Lohn:" + m_Lohn + ", Rat: " + m_Rat);
        }




    }
}
