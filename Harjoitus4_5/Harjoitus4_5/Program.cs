using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] luku = new int[2];

            luku[0] = 1;
            luku[1] = 1;

            Console.WriteLine(luku[0]);
            Console.WriteLine(luku[1]);

            for (int j = 0; j < 9; j++)
            {

                for (int i = 0; i < 2; i++)
                {

                    luku[i] = luku[0] + luku[1];
                    Console.WriteLine(luku[i]);

                }

            }



        }    
    }
}
