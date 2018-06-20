using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    class KyyhkysJussi
    {
        public int Mielenterveys { get; set; }
        public KyyhkysJussi()
        {
            Mielenterveys = 5;
        }
        public void LisääMielenterveyttä()
        {
            Mielenterveys++;
        }
        public void VähennäMielenterveyttä()
        {
            Mielenterveys--;
        }
    }
}
