using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            decimal b;

            Console.Write("Kirjoita arvosana: ");
            b = Convert.ToDecimal(Console.ReadLine());

            a = b<4? "Opiskelija jää luokalle." : "Opiskelija pääsee luokalta! ";

            Console.WriteLine("Arvosana: " + b+"\n" + a);
        }
    }
}
