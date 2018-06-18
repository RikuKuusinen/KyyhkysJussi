using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Sanat
    {
        public string sana;

        public string _sana { get => sana; set => sana = value; }

        public Sanat(string sana)
        {
            this.sana = sana;
        }
    }
}
