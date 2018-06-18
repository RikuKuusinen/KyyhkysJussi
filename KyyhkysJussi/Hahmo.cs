using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    class Hahmo
    {
        private string Nimi { get; set; }
        private string Rotu { get; set; }
        private string Sukupuoli { get; set; }
        public Hahmo(string Nimi, int Rotu, char Sukupuoli )
        {
            // jos joku menee hutiin syötössä, oletusrotu ihminen ja sukupuoli sukupuoleton
            string rotu;
            string sukupuoli;

            switch (Rotu)
            {
                case 1:
                    rotu = "Ihminen";
                    break;
                case 2:
                    rotu = "Örkki";
                    break;
                case 3:
                    rotu = "Haltia";
                    break;
                case 4:
                    rotu = "Kyyhkynen";
                    break;
                default:
                    rotu = "Maaginen vompatti";
                    break;
            }
            switch (Sukupuoli)
            {
                case 'm':
                    sukupuoli = "Miäs";
                    break;
                case 'n':
                    sukupuoli = "Nainen";
                    break;
                case 'x':
                    sukupuoli = "Eos";
                    break;
                case 'z':
                    sukupuoli = "Kaikki";
                    break;
                default:
                    sukupuoli = "Dönkkö";
                    break;
            }
            this.Nimi = Nimi;
            
            this.Rotu = rotu;

            this.Sukupuoli = sukupuoli;
        }
        public Hahmo(string Nimi, string Rotu, string Sukupuoli)
        {
            this.Nimi = Nimi;
            this.Rotu = Rotu;
            this.Sukupuoli = Sukupuoli;
        }
    }
}
