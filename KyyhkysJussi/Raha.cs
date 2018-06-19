using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Raha // Elli + Henni
    {
        //Tähän luokkaan luodaan rahan ominaisuudet, joita kutsutaan tarvittaessa mainissa.

        public int raha = 0;

        public int _raha { get => raha; set => raha = value; }

        public Raha(int raha)
        {
            this.raha = raha;
        }
        //Näillä metodeilla muutetaan rahan arvoa pelin edetessä 

        public int VahennaRaha(int luku)
        {
            return raha + luku;
        }
        public int LisaaRaha (int luku)
        {
            return raha - luku;
        }
        // Tätä metodia kutsutaan Reppu-luokasta
        public void NaytaRaha()
        {
           Console.WriteLine("$Sinulla on: {0} rahakolikkoa",raha);
        }
    }
}
