using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku = 1;

            Console.WriteLine(luku);

            for (int i = 1; i < 20; i++) 
            {
                Console.WriteLine(luku);
                luku += luku;
                

            }
        }
    }
}
