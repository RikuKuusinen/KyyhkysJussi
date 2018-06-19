using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Silmukat
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();


            int[] luvut = new int[100];
            
            int summa =0;


            for (int i = 0; i < luvut.Length; i++)
            {
                luvut[i] = rng.Next(1, 1001);
                Console.WriteLine(luvut[i]);
                summa += luvut[i];
            }

            int minimi = luvut[0];
            int maksimi = luvut[0];
            

            foreach(var i in luvut)
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
            
            Console.WriteLine("\nLuvut yhteenlaskettuna: " + summa);
            Console.WriteLine("Keskiarvo on: "+summa/luvut.Length);
            Console.WriteLine("Minimi on: {minimi}", minimi);
            Console.WriteLine("Maksimi on: {maksimi},", maksimi);

            

        }
    }
}
