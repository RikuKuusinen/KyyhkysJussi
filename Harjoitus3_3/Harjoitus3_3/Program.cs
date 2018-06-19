using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            double hinta;
            double alv;
            double hinta2;
                
            Console.Write("Anna tuotteen hinta: ");
            hinta = double.Parse(Console.ReadLine());

            alv = hinta * 0.22;
            hinta2 = hinta - alv;

            Console.WriteLine("Tuotteen sisältämä ALV on yhteensä: {0,9:C} ja tuotteen hinta ilman ALV:a on yhteensä: {1,9:C}",alv,hinta2);


        }
    }
}
