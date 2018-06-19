using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double luku, arvonta;
            arvonta = 45;
            Console.Write("Anna luku: ");
            luku = Convert.ToDouble(Console.ReadLine());
            int i = 1;

            while (luku != arvonta && i<5)
            {
            Console.Write("Anna luku: ");
            luku= Convert.ToDouble(Console.ReadLine());
            i++;
            }

            if (luku == arvonta)
                Console.WriteLine("Onneksi olkoon! ");
        }
    }
}
