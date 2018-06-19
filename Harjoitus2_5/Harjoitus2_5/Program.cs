using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tuotteet=new string[3];
            tuotteet[0] = "Maitopurkki";
            tuotteet[1] = "Silakka";
            tuotteet[2] = "Sipsipussi";

            float[] hinnat = new float[3];
            hinnat[0] = 1.09f;
            hinnat[1] = 5.69f;
            hinnat[2] = 2.36f;

            Console.WriteLine(tuotteet[0]+" on "+hinnat[0]+" euroa.");
            Console.WriteLine(tuotteet[1] + " on " + hinnat[1] + " euroa.");
            Console.WriteLine(tuotteet[2] + " on " + hinnat[2] + " euroa.");

        }
    }
}
