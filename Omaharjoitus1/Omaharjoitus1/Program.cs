using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omaharjoitus1
{
    class Program
    {
        static void Main(string[] args)
        {

            String etunimi;
            String sukunimi;
            int ika;

            Console.WriteLine("Anna etunimi:");
            etunimi=Console.ReadLine();

            Console.WriteLine("Anna sukunimi:");
            sukunimi = Console.ReadLine();

            Console.WriteLine("Kuinka vanha olet?");
            ika = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Nimesi on "+etunimi+" "+sukunimi);
            Console.WriteLine("Olet "+ ika +" vuotta vanha.");


            






        }
    }
}
