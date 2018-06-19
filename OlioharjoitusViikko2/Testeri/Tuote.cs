using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testeri
{
    public class Tuote
    {
        public int Tuotenumero { get; set; }
        public string Nimi;

        public string _Nimi
        {
            get
            {
                return Nimi;
            }

            set
            {
                if (value.Length < 5)
                {
                    throw new ArgumentException("Nimi oli liian lyhyt! ");
                }
                else Nimi = value;
            }
        }

        public decimal Hinta;

        public decimal _Hinta
        {
            get
            {
                return Hinta;
            }
            set
            {
                if (Hinta < 0)
                {
                    throw new ArgumentException("Hinta oli tyhmä! ");
                } else Hinta=value;
            }
           
        }
         
        public Tuote()
        {

        }
        public Tuote(int tuotenumero,string nimi,decimal hinta)
        {
            Tuotenumero = tuotenumero;
            Nimi = nimi;
            Hinta = hinta;

        }

        public virtual decimal LaskeHinta()
        {
            return Hinta;
        }

        public override string ToString()
        {
            return Tuotenumero+" "+Nimi+" "+Hinta;
        }
    }
}
