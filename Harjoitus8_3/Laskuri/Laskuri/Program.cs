using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskuri
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int y;
            int summa;
                  

            Console.Write("Anna ensimmäinen luku:");
            x = Int32.Parse(Console.ReadLine());

            Console.Write("Anna toinen luku:");
            y = Int32.Parse(Console.ReadLine());

            summa = x + y;

            Console.WriteLine("Näiden summa on: "+summa);

        }
    }
}
