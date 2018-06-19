using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kertausta.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] i = new int [5];
            double summa=0;

            for(int u =0; u<5; u++)
            {
                Console.Write("Anna numero: ");
                i[u] = Convert.ToInt32(Console.ReadLine());

            }
            
            foreach (int u in i)
            {
                summa += u;
            }
            summa /= 5;

            Console.WriteLine("Keskiarvo on {0}", summa);
        }
    }
}
