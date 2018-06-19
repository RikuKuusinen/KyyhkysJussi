using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeri
{
    class Alennustuote : Tuote
    {
        float Alennusprosentti;

       

        public Alennustuote(int tuoteNumero, string nimi, decimal hinta, float alennusprosentti) :base (tuoteNumero,nimi,hinta)
        {
            Tuotenumero=tuoteNumero;
            Nimi = nimi;
            Hinta = hinta;
            Alennusprosentti = alennusprosentti/100;

        }
        public override decimal LaskeHinta()
        {
            //decimal hinta = base.LaskeHinta();
            //Console.WriteLine(hinta + " " + Hinta + " " + Alennusprosentti);
            Hinta = base.Hinta * (1-Convert.ToDecimal(Alennusprosentti));
            return Hinta;
        }
        public override string ToString()
        {
            return Tuotenumero + " " + Nimi + " " + Hinta+" Hinta alennuksen jälkeen : "+LaskeHinta();
        }
    }
}
