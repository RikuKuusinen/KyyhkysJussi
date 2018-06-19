using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float numero1;
            float numero2;
            float summa;
            float erotus;
            float kertolasku;
            float osamaara;


            Console.Write("Syötä jokin numero: ");
            numero1=float.Parse(Console.ReadLine());

            Console.Write("Syötä toinen numero vielä: ");
            numero2 = float.Parse(Console.ReadLine());

            //Tämän jälkeen numeroille suoritetaan perusaritmeettiset operaatiot.

            summa = numero1 + numero2;
            erotus = numero1 - numero2;
            kertolasku = numero1 * numero2;
            osamaara = numero1 / numero2;
            

            Console.WriteLine("Näiden lukujen summa on: {0,9:f2}",summa);
            Console.WriteLine("Näiden lukujen erotus on: {0,9:f2}",erotus);
            Console.WriteLine("Nämä luvut kerrottuna ovat: {0,9:f2}",kertolasku);
            Console.WriteLine("Näiden lukujen osamäärä on: {0,9:f2}",osamaara);



        }
    }
}
