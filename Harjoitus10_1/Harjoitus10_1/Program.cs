using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Harjoitus10_1
{
    class Program
    {
        static void Main(string[] args)
        {
            long koko = 0;

            Console.WriteLine("Anna tiedoston nimi: (Huomioi että tiedostossa olevat poikkiviivat on tuplattava!)");
            string tiedosto = Console.ReadLine();

            DirectoryInfo directoryInfo = new DirectoryInfo(tiedosto);

            if (File.Exists(tiedosto))
            {
                koko = tiedosto.Length;
                Console.WriteLine("Tiedoston allaolevien asioiden koko yhteensä: " + koko);


            }
            else

                directoryInfo.Create();
            Console.WriteLine("Tiedoston luontiaika: "+ directoryInfo.CreationTime);








        }
    }
}
