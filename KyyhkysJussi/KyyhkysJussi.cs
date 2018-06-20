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
        public List<string> HaittaSanat { set; get; }
        public string[] HyötySanat { get; set; }
        public KyyhkysJussi()
        {
            Mielenterveys = 5;
            HaittaSanat = new List<string>() { "ruma", "okssu", "tyhmä", "pylly", "error", "koodi", "huono", "koodisi", "pieru"};
            HyötySanat = new string []{ "ihana", "mukava", "rakas", "kakka", "hyvä", "pulu", "kyyhky"};
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
