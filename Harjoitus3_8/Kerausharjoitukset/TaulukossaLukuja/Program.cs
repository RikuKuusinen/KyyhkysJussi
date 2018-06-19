using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaulukossaLukuja
{
    class Program
    {
        static void Main(string[] args)
        {
            double d;
            int[] luvut = new int[100];
            Random r = new Random();
            for (int i = 0; i < luvut.Length; i++)
            {
                luvut[i] = r.Next(1001);
            }
            int summa = 0;
            int minimi = luvut[0];
            int maksimi = luvut[0];
            //summa = luvut.Sum();

            foreach (var i in luvut)
            {
                summa += i;
                if (minimi > i)
                {
                    minimi = i;
                }
                if (maksimi < i)
                {
                    maksimi = i;
                }
            }
            Console.WriteLine("Summa " + summa.ToString("C"));
            Console.WriteLine("Summa {0:C}", summa);
            Console.WriteLine(string.Format("Summa {0:C}", summa));
            Console.WriteLine($"Summa {summa:C}");


            Console.WriteLine($"Keskiarvo {summa / luvut.Length}");
            Console.WriteLine($"Minimi {minimi}");
            Console.WriteLine($"Maksimi {maksimi}");
        }
    }
}
