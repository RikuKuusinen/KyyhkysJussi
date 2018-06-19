using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_6
{
    class Program
    {
        static void Main(string[] args)
        {
            int summa = 0;
            while (summa < 100) 
            {
                Console.Write("Anna reaaliluku: ");

                int reaaliluku = Convert.ToInt32(Console.ReadLine());
                summa += reaaliluku;

                if (summa > 100)
                {
                    Console.WriteLine("Raja on ylitetty! ");
                    break;
                }

                Console.WriteLine("Näiden yhteissumma: "+summa);

            }  

           



        
        }
    }
}
