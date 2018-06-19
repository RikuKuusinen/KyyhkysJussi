using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus4_9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] lapanen = {'a','b','c','d','e','f','g','h','i','j'};
            char[] sukka = { 'a', 'v', 'c', 'y', 'e', 'r', 'g', 'h', 't', 'i'};

            for (int i =1; i<10; i++)
            {
                if (lapanen[i] == sukka[i])
                {
                    
                }
                else
                {
                    Console.Write("Nämä erosivat taulukoissa: "+sukka[i]);
                    Console.WriteLine(lapanen[i]);
                }
            }

        }
    }
}
