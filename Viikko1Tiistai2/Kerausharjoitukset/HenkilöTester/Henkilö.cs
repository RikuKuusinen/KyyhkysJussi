using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilöTester
{
    class Henkilö
    {
        private static int seuraavaVapaaId = 1;

        private readonly int _id;
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        
        public int Ikä { get { return DateTime.Today.Year - Syntymäpäivä.Vuosi; } }

        public Päivämäärä Syntymäpäivä { get; set; }

        public int Id { get { return _id; } }

        //public Henkilö(string etunimi , string sukunimi, int ikä)
        public Henkilö(string etunimi , string sukunimi, Päivämäärä syntymäPvm)
        {
            _id = seuraavaVapaaId++;
            Etunimi = etunimi; 
            Sukunimi = sukunimi;
            //Ikä = ikä;
            Syntymäpäivä = syntymäPvm;
        }

        public override string ToString()
        {
            return $"[{_id}] {Etunimi}, {Sukunimi} ikä: {Ikä}";
        }
    }
}
