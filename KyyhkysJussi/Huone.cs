using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Huone //Anni
    {
        string huoneenNimi;

        public Huone(string huoneenNimi)
        {
            this.huoneenNimi = huoneenNimi;
            List<Tavara> huoneenTavarat = new List<Tavara>();
        }
        public Huone lähtöruutuun = new Huone("lähtöruutu");
        public Huone itään = new Huone("itä");
    }
}
