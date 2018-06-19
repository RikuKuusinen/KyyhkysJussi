using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Arkistoi
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
        
            DirectoryInfo directoryinfo = new DirectoryInfo(hakemisto);
            directoryinfo.GetFiles();

            string arkisto = "C:\\Temp\\Arkisto";

            if (!File.Exists(arkisto))
                File.Create(arkisto);



            if (args.Length == 1)
            {
                FileInfo[] tiedosto = directoryinfo.GetFiles($"*.cs*");

                //File.Copy(t.FullName, Path.Combine(tiedosto ,\t { arkisto}");

                   
            }
            
        }
    }
}

