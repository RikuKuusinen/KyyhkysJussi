using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal [] tuoteHinta = new decimal[3];
            int[] tuoteLkm = new int[3];
            decimal[] tuoteYhtHinta = new decimal[3];

            tuoteHinta[0] = 17.89m;
            tuoteHinta[1] = 16.34m;
            tuoteHinta[2] = 13.24m;

            tuoteLkm[0] = 1;
            tuoteLkm[1] = 4;
            tuoteLkm[2] = 8;

            tuoteYhtHinta[0] = tuoteHinta[0] * tuoteLkm[0];
            tuoteYhtHinta[1] = tuoteHinta[1] * tuoteLkm[1];
            tuoteYhtHinta[2] = tuoteHinta[2] * tuoteLkm[2];

            Console.WriteLine("Villapaita, yhteishinta: "+tuoteYhtHinta[0]+" euroa.");
            Console.WriteLine("Lemmikkihiiri, yhteishinta: "+tuoteYhtHinta[1]+" euroa.");
            Console.WriteLine("Ralliautolelu, yhteishinta: "+tuoteYhtHinta[2]+ "euroa.");


        }
    }
}
