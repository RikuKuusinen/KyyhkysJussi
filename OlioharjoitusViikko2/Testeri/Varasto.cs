using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Testeri
{
    class Varasto
    {
        public event EventHandler VarastonSisältöMuuttunut;
        public List<Tuote> Tuotteet { get; private set; }
        public string VarastonNimi { get; set; }
        public Varasto(string nimi)
        {
            VarastonNimi = nimi;
            Tuotteet = new List<Tuote>();
        }
        public void LisääTuote(Tuote t)
        {
            if (VarastonSisältöMuuttunut != null)
            {
                VarastonSisältöMuuttunut(this, EventArgs.Empty);
            }
            Tuotteet.Add(t);
        }
        public bool PoistaTuote(int tuoteNumero)
        {
            Tuote t = null;
            foreach (var item in Tuotteet)
            {
                if (item.Tuotenumero == tuoteNumero)
                {
                    t = item;
                    break;
                }

            }
            if (t == null)
            {
                return false;
            }
            else
            {
                Tuotteet.Remove(t);
                return true;
            }

        }
        public bool PoistaTuote(Tuote t)
        {
            if (Tuotteet.Contains(t))
            {
                Tuotteet.Remove(t);

                if(VarastonSisältöMuuttunut!= null)
                {
                    VarastonSisältöMuuttunut(this, EventArgs.Empty);
                }
                return true;
            }
            else return false;
        }
        public decimal VarastonArvo()
        {
            decimal summa = 0m;

            foreach (var item in Tuotteet)
            {

                summa += item.Hinta;           
                                    

            }
            return summa;

        }
        

        

        
            

        

    }
}
