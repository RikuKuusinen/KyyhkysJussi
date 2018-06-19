using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirjallisuus.Kirjailija.Kirja kirja1 = new Kirjallisuus.Kirjailija.Kirja("Helvetistä itään", "Karo Hämäläinen", "Otava", 31.34);

            Kirjallisuus.Kirjailija kirjailija1 = new Kirjallisuus.Kirjailija("Karo Hämäläinen", "Huomenna", kirja1);

            kirjailija1.Tulostatiedot();
            kirja1.TulostaTiedot2();
        }
    }
}
