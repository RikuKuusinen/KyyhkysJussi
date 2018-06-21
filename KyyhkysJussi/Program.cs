using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    class Program
    {
        
        public static UI Peli { get; set; }
        static void Main(string[] args)
        {
            UI Peli = new UI();
            Peli.AloitaPeli();
        }
    }
}
