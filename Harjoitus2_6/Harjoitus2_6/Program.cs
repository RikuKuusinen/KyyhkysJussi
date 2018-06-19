using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2_6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal [] [] mittaustulokset = new decimal[3][];
            mittaustulokset[0] = new decimal[1];
            mittaustulokset[1] = new decimal[3];
            mittaustulokset[2] = new decimal[2];

            mittaustulokset[0][0] = 3.445m;
            mittaustulokset[1][0] = -4.588m;
            mittaustulokset[1][1] = 8.98653m;
            mittaustulokset[1][2] = 10.984776m;
            mittaustulokset[2][0] = 7.98763m;
            mittaustulokset[2][1] = 11.92876m;

            Console.WriteLine(mittaustulokset[0][0]);
            Console.WriteLine(mittaustulokset[1][0]+" "+mittaustulokset[1][1]+" "+mittaustulokset[1][2]);
            Console.WriteLine(mittaustulokset[2][0]+" "+mittaustulokset[2][1]);


        }
    }
}
