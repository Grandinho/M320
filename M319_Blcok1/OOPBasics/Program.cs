using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();

            Circle c2 = new Circle();

            c2._diameter = 1;
            double k = c2.CircleArea();
        }
    }
}
