using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_8
{
    class Program
    {
        static void Main(string[] args)
        {
                    
            string merkkijono1;
            string merkkijono2;
            long merkkiluku1, merkkiluku2;
            long tulos;
                               
            Console.Write("Anna ensimmäinen luku: ");
            merkkijono1 = Console.ReadLine();    

            merkkiluku1 = Convert.ToInt64(merkkijono1, 2);

            Console.Write("Anna toinen luku: ");
            merkkijono2 = Console.ReadLine();

            merkkiluku2 = Convert.ToInt64(merkkijono2, 2);

            tulos = merkkiluku1 ^ merkkiluku2;

            string tulos1 = Convert.ToString(tulos, 2);

            Console.WriteLine(tulos1);

            






        



        }
    }
}
