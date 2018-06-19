using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int luku1;
            int luku2;
            int summa=0;

            Console.Write("Anna kokonaisluku: ");
            luku1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Anna toinen kokonaisluku: ");
            luku2 = Convert.ToInt32(Console.ReadLine());

            if (luku1<luku2)
            {
                do
                {
                    luku1++;
                    summa += luku1;
                } while (luku1 < luku2-1);
            }

            if (luku2<luku1)
            {
                do
                {
                    luku2++;
                    summa += luku2;
                } while (luku2 < luku1-1);
            }
            Console.WriteLine("Lukujen välillä olevat luvut ovat yhteenlaskettuna: "+summa);

            
        }
    }
}
