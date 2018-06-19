using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Henkilö
    {
        public string Etunimi;
        public string Sukunimi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Henkilö h = new Henkilö();
            h.Etunimi = "Aku";
            h.Sukunimi = "Ankka";
            Console.WriteLine(h.Etunimi+h.Sukunimi);

        }
    }
}



