using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            char heksaDesimaali= '\x24FA';
            int luku;
            luku = Convert.ToInt32(heksaDesimaali);

            Console.WriteLine(luku);


           
        }
    }
}
