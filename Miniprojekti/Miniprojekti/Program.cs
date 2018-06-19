using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Miniprojekti
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rng = new Random();
            int mones = 1;
            

            for (int i = mones; i < 11; i++)
            {
                rng.Next(0, 20);
                Console.WriteLine("Kysymys "+mones+" on:" /*+ kysymys*/);
                mones++;
            }
        
        }
    }
}
