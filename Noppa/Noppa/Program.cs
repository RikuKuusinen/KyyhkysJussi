using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Noppa
{
    class Program
    {
        static void Main(string[] args)
        {
            string jatko;
           
            do
            {
                int summa = 0;
                Console.Write("Kuinkas monta kertaa heitetään? :D ");
                int heitot=Convert.ToInt32(Console.ReadLine());
                int [] luku= new int [heitot];
                int i;
                Random rng = new Random();

                for ( i = 0; i < heitot; i++)
                {
                    
                    luku[i] = rng.Next(1, 7);
                    Console.WriteLine("Nopan luku: " + luku[i]);
                    summa += luku[i];

                }
                Console.WriteLine("Noppien yhteenlaskettu summa on: " + summa);
                Console.WriteLine("Voittaaksesi sinun pitäisi saada yli " + heitot * 3);
                


                if (summa > 3*heitot)
                {
                    Console.WriteLine("Voitit!");
                }
                else
                {
                    Console.WriteLine("Hävisit!");
                }
                Console.Write("Haluatko heittää uudelleen? k/e\n");
                jatko = Console.ReadLine();
            } while (jatko == "k");
         
            
            

        }
    }
}
