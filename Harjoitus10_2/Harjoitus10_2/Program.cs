using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harjoitus10_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto2 = Directory.GetCurrentDirectory();
            Console.WriteLine("Nykyisen työhakemiston nimi: "+Directory.GetCurrentDirectory());


            Console.Write("Anna uuden hakemiston nimi mihin sisältö siirretään: ");
            string tiedosto = Console.ReadLine();

            Directory.Move(tiedosto2,tiedosto);
            


            Console.WriteLine("Tiedoston sisältö: ");

        }
    }
}
