using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Locatioharjoitus
{
    class Program
    {
        private static object svfi;

        static void Main(string[] args)
        {
            string[] konsultit = { "Nina Puhakka", "Riikka Valjakka", "Oscar Storbacka", "Jere Mörsky", "Lotta Järvinen", "Katri Kolehmainen", "Tuomas Tuominen", "Olli Piilonen", "Okku Toivola", "Mikko Kairesalo", "Anni Kaivola", "Mikko Keino", "Viljami Harjula", "Roman Tcharni", "Henni Marjomaa", "Vesa Anttila", "Ville Immonen", "Hanna-Mari Lapp", "Sara Seunavaara", "Oona Kangas", "Elli Salo", "Jussi Ojala", "Tatu Vahteri", "Silja Fagerholm ", "Sari Paavilainen", "Erika Laamanen", "Tero Tuovinen", "Aarni Koskelainen", "Riku Kuusinen", "Jukka Peltola" };

            Array.Sort(konsultit);                     
                    
            Thread.CurrentThread.CurrentCulture = new CultureInfo(args[0]);
             Currentculture f = new CurrentUIculture("fi-FI");        
            
            List<Konsultti> konsulttilista = new List<Konsultti>();

            string[] nimenOsat;

            foreach (var k in konsultit)
            {
                nimenOsat = k.Split(' ');
                Konsultti b = new Konsultti() { Etunimi = nimenOsat[0], Sukunimi = nimenOsat[1] };
                konsulttilista.Add(b);
            }      

            Random rng = new Random();

            Console.Write(Risotto.Kuinkamontatyyppiä);
            int ryhmäKoko = Convert.ToInt32(Console.ReadLine());
            int ryhmienLkm = konsulttilista.Count / ryhmäKoko;

            Console.WriteLine(Risotto.Millonarvottu+DateTime.Now);

            //Console.WriteLine("Arvottu{0:d} klo {0:t}", DateTime.Now);

            for (int i = 1; i <= ryhmienLkm; i++)
            {
                Console.WriteLine($"Ryhmä {i}");

                for (int j = 0; j < ryhmäKoko; j++)
                {
                    int r = rng.Next(0, konsulttilista.Count);
                    Console.WriteLine(konsulttilista[r].Sukunimi + ", " + konsulttilista[r].Etunimi);
                    konsulttilista.RemoveAt(r);
                }
                Console.WriteLine();
            }
        }
    }
}
