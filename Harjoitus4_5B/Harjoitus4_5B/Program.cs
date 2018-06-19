using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_5B
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int[20];

            luku[0] = 1;
            luku[1] = 1;

            Console.WriteLine(luku[0]+"\n" +luku[1]);

            for (int i = 2; i < 20; i++) 
            {
                luku[i] = luku[i-1] + luku[i-2];
                Console.WriteLine(luku[i]);

            }
        }
    }
}
