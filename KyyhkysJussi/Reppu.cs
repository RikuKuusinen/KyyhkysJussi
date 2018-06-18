using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KyyhkysJussi
{
    class Reppu 
    {
        //Tähän luodaan reppu, jonka ominaisuuksiin kuuluu lisätä, säilyttää ja luovuttaa tavaroita.
        //Tehdään lista, johon tulee (objekti) tavaroita. Repussa on myös rahaa, joka on int.

        public List<Tavara> tavarat = new List <Tavara>();

        public void LisaaTavara(Tavara t)
        {
            tavarat.Add(t);
        }
        
       

    }
}
