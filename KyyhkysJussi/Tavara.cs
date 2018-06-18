using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Tavara
    {
        //Repun sisältö (lista) koostuu Tavara-luokan olioista
        public string tavara;      

        public string _tavara { get => tavara; set => tavara = value; }

        public Tavara(string tavara)
        {
            this.tavara = tavara;
        }

        
    }
}
