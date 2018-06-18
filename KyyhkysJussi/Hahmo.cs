using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Hahmo
    {
        internal string Nimi { get; set; }
        internal string Rotu { get; set; }
        internal string Sukupuoli { get; set; }



        public Hahmo(string Nimi, string Rotu, string Sukupuoli)
        {

            this.Nimi = Nimi;

            this.Rotu = Rotu;

            this.Sukupuoli = Sukupuoli;
        }

        public override string ToString()
        {
            return Nimi + " " + Rotu + " " + Sukupuoli;
        }

    }
}