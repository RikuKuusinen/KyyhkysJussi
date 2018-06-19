using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Locatioharjoitus
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
            return Sukunimi + ", " + Etunimi;
        }
    }
}
