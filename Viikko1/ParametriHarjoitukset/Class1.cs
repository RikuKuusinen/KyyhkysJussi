using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametriHarjoitukset
{
    public class TestiPenkki
    {
        string etuNimi, sukuNimi;
        

        public string Nimikuntoon(string etuNimi, string sukuNimi)
        {
            char ekaKirjain = etuNimi.Trim()[0];
            char tokaKirjain = sukuNimi.Trim()[0];
            ekaKirjain=char.ToUpper(ekaKirjain);
            tokaKirjain=char.ToUpper(tokaKirjain);
            string etuNiminen = ekaKirjain + etuNimi.Substring(1).ToLower();
            string sukuNiminen = tokaKirjain + sukuNimi.Substring(1).ToLower();
            etuNimi = etuNiminen;
            sukuNimi = sukuNiminen;

            return (etuNimi +", "+sukuNimi);
                       
        }

        public string Nimikuntoon(string nimi)
        {
            return etuNimi+", "+sukuNimi;
        }
    }
}
