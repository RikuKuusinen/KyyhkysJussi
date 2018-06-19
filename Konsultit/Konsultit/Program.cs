using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Konsultit
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] konsultit = { "Nina Puhakka", "Riikka Valjakka", "Oscar Storbacka", "Jere Mörsky", "Lotta Järvinen", "Katri Kolehmainen", "Tuomas Tuominen", "Olli Piilonen", "Okku Toivola", "Mikko Kairesalo", "Anni Kaivola", "Mikko Keino", "Viljami Harjula", "Roman Tcharni", "Henni Marjomaa", "Vesa Anttila", "Ville Immonen", "Hanna-Mari Lapp", "Sara Seunavaara", "Oona Kangas", "Elli Salo", "Jussi Ojala", "Tatu Vahteri", "Silja Fagerholm ", "Sari Paavilainen", "Erika Laamanen", "Tero Tuovinen", "Aarni Koskelainen", "Riku Kuusinen", "Jukka Peltola" };

            //ArrayList lista = new ArrayList(konsultit);

            Array.Sort(konsultit);

            foreach (var item in konsultit)
            {
                Console.WriteLine(item);
            }


            List<Konsultti> konsulttilista = new List<Konsultti>();

            string[] nimenOsat;

            foreach (var k in konsultit)
            {
                nimenOsat = k.Split(' ');
                Konsultti b = new Konsultti() { Etunimi = nimenOsat[0], Sukunimi = nimenOsat[1] };
                konsulttilista.Add(b);
            }
            Console.WriteLine();

            foreach (Konsultti u in konsulttilista)
            {
                Console.WriteLine(u.Etunimi + " " + u.Sukunimi);
            }
            Console.WriteLine();

            var q = from h in konsulttilista
                        //where h.Sukunimi.Contains("nen")
                        //orderby h.Sukunimi
                        //orderby h.Etunimi descending
                    //orderby h.Etunimi.Length + h.Sukunimi.Length
                    //orderby h.Sukunimi.Contains(vowels) descending
                    orderby PalautaVokaalienLukumäärä(h.Sukunimi)
                   
                     select h;

            //Console.WriteLine(" Pisin nimi: "+q.Last().ToString());
            Console.WriteLine();

            foreach (var h in q)
            {
                Console.WriteLine(h.Etunimi + " " + h.Sukunimi  );
            }
            

           

            //Random rng = new Random();

            //int ryhmäKoko = 5;
            //int ryhmienLkm = konsulttilista.Count/ryhmäKoko;



            //for (int i = 1; i <= ryhmienLkm; i++)
            //{
            //    Console.WriteLine($"Ryhmä {i}");

            //    for (int j = 0; j < ryhmäKoko; j++)
            //    {

            //        int r = rng.Next(0, konsulttilista.Count);
            //        Console.WriteLine(konsulttilista[r].Sukunimi+", "+konsulttilista[r].Etunimi);
            //        konsulttilista.RemoveAt(r);                   
            //    }
            //}
            //Console.Write("Anna merkkijono: ");
            //string t = Console.ReadLine();

            //Console.WriteLine(t.BlankkoTrimmaus());


            //int[] arvonta = new int[30];



            //for (int a = 0; a < konsulttilista.Count; a++)
            //{

            //    arvonta[a] = rng.Next(0, 30);



            //    for (int b = 0; b < a; b++)
            //    {

            //        if (arvonta[a] == arvonta[b])
            //            a--;                    
            //    }
            //}
            //foreach (var item in arvonta)
            //{
            //    Console.WriteLine(item);

            //}
            //int[] istumajarkka = new int[30];

            //for (int i =  konsulttilista.Count ; i > 0; )
            //{
            //    istumajarkka[konsulttilista.Count] = arvonta[i];


            //}

            //foreach ( var item in istumajarkka)
            //{
            //    Console.WriteLine(istumajarkka);
            //}

        }

        private static object PalautaVokaalienLukumäärä(string sukunimi)
        {
            int lkm = 0;
            
            Char[] mj = new Char[sukunimi.Length];

            var chars = sukunimi.ToArray();

            sukunimi.Split();

            foreach (var i in sukunimi)
            {
                if (chars[i] == 'a' ||chars[i] == 'e' || chars[i] == 'i'||chars[i] == 'o'|| chars[i] == 'u'|| chars[i] == 'y'|| chars[i] == '')

            }

        }
    }
}
