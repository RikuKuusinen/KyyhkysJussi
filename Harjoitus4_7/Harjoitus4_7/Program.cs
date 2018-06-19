using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] taulukko = new int[10];
            int summa=0;

            for (int i =0; i<10;i++)
            {
                taulukko[i] = i + 88;
                Console.WriteLine(taulukko[i]);
            }
            Console.WriteLine();

            for (int i=0; i<10;i++)
            {

                if (taulukko[i]%2!=0)
                {
                    Console.WriteLine(taulukko[i]);
                    summa += taulukko[i];

                    
                }
                

            }

            Console.WriteLine("Summa on: " + summa);




        }
    }
}
