using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] i = new int [5];
            int summa=0;
            int keskiarvo;

            for (int a = 0; a < 5; a++)
            {
                Console.Write("Kirjoita kokonaisluku: ");
                i[a] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine();

            foreach (int j in i)
            {
            
                summa += j;
                
            }
            keskiarvo = summa / 5;

            Console.WriteLine("Keskiarvo on: " + keskiarvo);






        }
    }
}
