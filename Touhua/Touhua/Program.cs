using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Touhua
{
    class Program
    {
        static void Main(string[] args)
        {
            string tiedosto = "C:\\Temp\\muistio.txt";

            if (!File.Exists(tiedosto))
                File.Create(tiedosto);

            Console.WriteLine("Onko tiedosto olemassa: " + File.Exists(tiedosto));
        }
    }
}
