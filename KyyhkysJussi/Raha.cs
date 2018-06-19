using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Raha
    {
        //Tähän luokkaan luodaan rahan ominaisuudet, joita kutsutaan tarvittaessa mainissa.

        public int raha = 0;

        public int _raha { get => raha; set => raha = value; }

        public Raha(int raha)
        {
            this.raha = raha;
        }
        //Tällä metodilla muutetaan rahan arvoa pelin edetessä ja tätä metodia kutsutaan Reppu-luokasta

        public int vahennaRaha(int luku)
        {
            return raha + luku;
        }
        public int lisaaRaha (int luku)
        {
            return raha - luku;
        }
        public override string ToString()
        {
            return "Sinulla on: " + raha.ToString() ;
        }
    }
}
