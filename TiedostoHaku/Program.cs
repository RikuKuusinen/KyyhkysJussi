using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TiedostoHaku
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Anna tiedostonimi!");
            }
            string hakemisto = args[0];
            string t = args[1];
            

            DirectoryInfo directoryinfo = new DirectoryInfo(hakemisto);
            directoryinfo.GetFiles();
            
            if (!Directory.Exists(hakemisto))
            {
                Console.WriteLine("Tiedostoa ei löydy! ");
                return;
            }

            FileInfo[] tiedosto = directoryinfo.GetFiles($"*{t}"); ;

            if (args.Length == 2)
            {
                string u = args[2];

                string[] files = Directory.GetFiles($"*{u}*");

                foreach (var j in hakemisto)
                {
                    Console.WriteLine($"{files}");
                }
            }

            int laskuri = 0;

            foreach (var i in tiedosto)
            {
                Console.WriteLine($"{i.Name}\t{i.Length}\t{i.LastWriteTime.ToShortDateString()}");
                laskuri++;
            }
            Console.WriteLine($"Yhteensä {laskuri} tiedostoa");
            return;
            
        
        }
    }
}
