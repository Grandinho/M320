using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Vererbung
{
    public class Funktionen
    {

        public static void Lohnerhoehung(lFunctions obj, double d)
        {
            double dAlterLohn = obj.m_Lohn;
            double dNeuerLohn = dAlterLohn / 100 * (100 + d);
            obj.m_Lohn = dNeuerLohn;
        }

    }
}
