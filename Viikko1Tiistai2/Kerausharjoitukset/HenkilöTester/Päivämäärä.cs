using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HenkilöTester
{
    class Päivämäärä
    {
        public int Päivä { get; private set; }
        public int Kuukausi { get; private set; }
        public int Vuosi { get; private set; }

        public Päivämäärä(int pp, int kk, int vvvv)
        {
            if (pp < 1 || pp > 31)
            {
                throw new ArgumentOutOfRangeException("päivä väärin");
            }
            if (kk < 1 || kk > 12)
            {
                throw new ArgumentOutOfRangeException("kuukausi väärin");
            }
            if (vvvv < 1900  || vvvv > 2100)
            {
                throw new ArgumentOutOfRangeException("Vuosi väärin");
            }
            Päivä = pp;
            Kuukausi = kk;
            Vuosi = vvvv;
        }

        public Päivämäärä(string pp_kk_vvvv)
        {
            string[] osat = pp_kk_vvvv.Split('.');
            if (osat.Length != 3)
            {
                //throw new ArgumentOutOfRangeException("Päivämäärän muoto väärin");
                throw new PäivämääräException("Päivämäärän muoto väärin");
            }
            int.TryParse(osat[0], out int pp);
            int.TryParse(osat[1], out int kk);
            int.TryParse(osat[2], out int vvvv);
            if (pp < 1 || pp > 31)
            {
                throw new ArgumentOutOfRangeException("päivä väärin");
            }
            if (kk < 1 || kk > 12)
            {
                throw new ArgumentOutOfRangeException("kuukausi väärin");
            }
            if (vvvv < 1900 || vvvv > 2100)
            {
                throw new ArgumentOutOfRangeException("Vuosi väärin");
            }
            Päivä = pp;
            Kuukausi = kk;
            Vuosi = vvvv;
        }

        public static Päivämäärä Parse(string pvm)
        {
            return new Päivämäärä(pvm);
        }

    }
}
