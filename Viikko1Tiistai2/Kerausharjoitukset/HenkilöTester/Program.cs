using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilöTester
{
    class Program
    {
        static void Main(string[] args)
        {
            //Henkilö h = new Henkilö("aku", "ankka", 313);
            //string s = h.ToString();
            //Console.WriteLine(s);

            //Henkilö[] hlot = {new Henkilö ("Jaska","Jokunen", 21),
            //    new Henkilö("Maija","Meikäläinen", 28),
            //    new Henkilö("John","Doe", 55),
            //    new Henkilö("John","Deere", 21),
            //    new Henkilö("Musta","Naamio", 355)};
            Henkilö[] hlot = {new Henkilö ("Jaska","Jokunen", Päivämäärä.Parse("2.2.2001")),
                new Henkilö("Maija","Meikäläinen", new Päivämäärä(22, 3, 1988)),
                new Henkilö("John","Doe", new Päivämäärä("3.4.1967")),
                new Henkilö("John","Deere", Päivämäärä.Parse("1.1.1990")),
                new Henkilö("Musta","Naamio", new Päivämäärä(1, 2, 1933))
            };
            foreach (var h in hlot)
            {
                Console.WriteLine(h);
            }
        }
    }
}
