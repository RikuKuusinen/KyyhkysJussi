using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarkistin
{
    public class Luokka
    {
        public bool HeTuOk(string hetu)
        {
            string pvm;
            char välimerkki;
            string numero;
            char tarkistusmerkki;
            string tMerkit = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            hetu = hetu.Trim();
            if (hetu.Length != 11) { return false; }
            pvm = hetu.Substring(0, 6);
            string paiva = hetu[0].ToString() + hetu[1].ToString();
            //int pv = Convert.ToInt32(paiva);
            if (int.Parse(paiva) > 31)
            {
                return false;
            }
            
            string kuukaus = hetu[2].ToString() + hetu[3].ToString();
            //int kk = Convert.ToInt32(paiva);
            if (int.Parse(kuukaus) > 12)
            {
                return false;
            }
            välimerkki = hetu[6];
            numero = hetu.Substring(7, 3);
            tarkistusmerkki = hetu[10];
            int i = 0;
            if (!int.TryParse(numero, out i)) { return false; }
            if (välimerkki != '-' && välimerkki != '+' && välimerkki != 'A')
            {
                return false;
            }
            if (!int.TryParse(numero, out i)) { return false; }
            i = int.Parse(pvm + numero) % 31;
            if (tMerkit[i] != tarkistusmerkki)
            {
                return false;
            }
            return true;
        }
    }
}
