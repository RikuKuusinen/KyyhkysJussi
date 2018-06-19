using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilöTester
{
    class Henkilö
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public int Ikä { get; set; }

        public Henkilö(string etunimi , string sukunimi, int ikä)
        {
            Etunimi = etunimi; 
            Sukunimi = sukunimi;   
            Ikä = ikä;
        }

        public override string ToString()
        {
            return Etunimi + ", " + Sukunimi + "";
        }
    }
}
