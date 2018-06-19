using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeri
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote t1 = new Tuote();
            t1.Tuotenumero = 1001;
            t1.Nimi = "Jatkojohto";
            t1.Hinta = 100.00m;
            Tuote t2 = new Tuote(1002, "Hiiri", 9.99M);
            Tuote t3 = new Tuote() { Tuotenumero = 3010, Nimi = "Mukiteline", Hinta = 19.99M };
            Console.WriteLine(t1);
            Console.WriteLine(t2);
            Console.WriteLine(t3);
            Console.WriteLine();

            Varasto v = new Varasto("Keskusvarasto");
            v.VarastonSisältöMuuttunut += V_VarastonSisältöMuuttunut;
            v.LisääTuote(t1);
            v.LisääTuote(t2);
            v.LisääTuote(t3);
            foreach (var t in v.Tuotteet)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine();

            Console.WriteLine("Varaston arvo on: " + v.VarastonArvo());

            Console.WriteLine();

            v.PoistaTuote(1002);

            v.PoistaTuote(t1);

            foreach (var t in v.Tuotteet)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("Varaston arvo on: " + v.VarastonArvo());

            Alennustuote g1 = new Alennustuote(2345, "Tamagotchi", 100.0m, 80.0f);
            v.LisääTuote(g1);
            Console.WriteLine();
            Console.WriteLine(g1);

            
        }

        private static void V_VarastonSisältöMuuttunut(object sender, EventArgs e)
        {
            Console.WriteLine("Varaston sisältö muuttunut! ");
            //throw new NotImplementedException();
           
        }
    }
}
