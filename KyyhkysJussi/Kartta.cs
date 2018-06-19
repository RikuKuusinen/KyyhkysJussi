using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    class Kartta //Anni
    {
        // taulukko [x, y] 
        // sisältää olion, jossa muokattavat ja staattiset huoneen ominaisuudet
        // esineet, asiat joiden kanssa vuorovaikutetaan
        // - huoneen kuvaus (muuttuva , jos esineitä viedään pois tms.)
        // - avainsanat huoneelle

        public Kartta(Huone huone)
        {

        }

        // Huone[,] kartta = new Huone[1, 2];
        Kartta[,] maailma = new Kartta[1, 2];

        //maailma[0,0]= lähtöruutuun;
        //maailma[0,1]=itään;
         
    }
}
