using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string b;
            int k;

            Console.Write("Syötä kokonaisluku: ");
            k = Convert.ToInt32(Console.ReadLine());

            b = k > 0 ? "Jaa" : "Ei";
            Console.WriteLine(b);


        }
    }
}
