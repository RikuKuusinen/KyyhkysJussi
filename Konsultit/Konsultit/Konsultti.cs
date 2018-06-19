using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Konsultit
{
    class Konsultti
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }

        public Konsultti()
        {

        }
        public override string ToString()
        {
            return Etunimi+" "+Sukunimi;
        }



    }

    public static class Blankko
    {
        public static string BlankkoTrimmaus(this string s)
        {
            s = s.Replace("  ", string.Empty);
            return s;
                    
        }

    }
}
