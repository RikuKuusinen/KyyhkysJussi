using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kerroin_lisätehtävä2
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
                int summa = 1;

                for (int i = 0; i < luku; i++)
                {
                    Console.Write(kerroin + " * ");
                    summa *= kerroin++;
                                                           
                    
                }
                Console.WriteLine("Summa on : "+summa);

            }
            catch
            {
                Console.WriteLine("Yritä antaa kokonaisluku ens kerralla niin koko homma ei kaadu! ");
            }
        }
    }
}
