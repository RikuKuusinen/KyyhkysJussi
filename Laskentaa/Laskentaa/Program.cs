using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskentaa
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Anna luku: ");
                int luku = Convert.ToInt32(Console.ReadLine());
                int kerroin = 1;
                int summa = 0;

                for (int i = 0; i < 10; i++)
                {
                    summa = luku * kerroin;
                    Console.WriteLine(kerroin + " * " + luku + " = " + summa);
                    kerroin++;
                }

            }
            catch
            {
                Console.WriteLine("Yritä antaa kokonaisluku ens kerralla niin koko homma ei kaadu! ");
            }
        }
    }
}
