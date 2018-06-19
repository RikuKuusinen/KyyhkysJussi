using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double luku1;
            double luku2;
            bool vertailuntulos;
        
            Console.Write("Annahan yksi luku: ");
            luku1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Annahan toinen luku: ");
            luku2 = Convert.ToDouble(Console.ReadLine());

            vertailuntulos = luku1 > luku2;
            Console.WriteLine("Oliko ensimmäinen luku suurempi kuin toinen luku? "+vertailuntulos);

            vertailuntulos = luku1 == luku2;
            Console.WriteLine("Oliko luvut yhtäsuuria? " + vertailuntulos);

            vertailuntulos = luku1 < luku2;
            Console.WriteLine("Oliko ensimmäinen luku pienempi kuin toinen luku? "+vertailuntulos);



        }
    }
}
