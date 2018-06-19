using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus3_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int kokonaisluku1;
            int kokonaisluku2;
            int jakojaannos;
            

            Console.Write("Syötä kokonaisluku: ");
            kokonaisluku1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Syötä toinen kokonaisluku: ");
            kokonaisluku2 = Convert.ToInt32(Console.ReadLine());

            jakojaannos = kokonaisluku1 % kokonaisluku2;

            Console.WriteLine("Antamiesi lukujen jakojäännös on: "+jakojaannos);
        }
    }
}
