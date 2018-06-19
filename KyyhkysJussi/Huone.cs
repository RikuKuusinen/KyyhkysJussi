using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace KyyhkysJussi



{
    public class Huone //Anni, Henni
    {
        //string huoneenNimi;
        public string HuoneenKuvaus { get; set; }
        public List<Tavara> huoneenTavarat { get; set; }
        public List<Sanat> avainSanat { get; set; }




        public Huone(string huoneenKuvaus)
        {
            this.HuoneenKuvaus = huoneenKuvaus;
            huoneenTavarat = new List<Tavara>();
            avainSanat = new List<Sanat>();
        }


        //Huone huone1 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone1.txt"))
        //{
        //    huoneenTavarat = new List<Tavara>()
        //    {
        //        new Tavara("Vasara"),
        //        new Tavara("Kirves")
        //    },
        //    avainSanat = new List<Sanat>()
        //    {
        //    new Sanat("Ikkuna"),
        //    new Sanat("Pöytä")
        //    }
        //};

        //Huone huone2 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone2.txt"));

        //Huone huone3 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone3.txt"));

        //Huone huone4 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone4.txt"));

        //Huone huone5 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone5.txt"));

        //Huone huone6 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone6.txt"));

        //Huone huone7 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone7.txt"));

        //Huone huone8 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone8.txt"));

        //Huone huone9 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone9.txt"));

        //Huone huone10 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone10.txt"));

        //public Huone huone11 = new Huone("Olet kotimökissäsi. Ovi on etelässä.");

        //Huone huone12 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone12.txt"));

        //Huone huone13 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone13.txt"));

        //Huone huone14 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone14.txt"));

        //public Huone huone15 = new Huone("Olet ulkona. Lohikäärme kääntyy tuijottamaan sinua.");

        //Huone huone16 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Huone16.txt"));

        //Huone huone999 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Salahuone.txt"));

        //Huone huone666 = new Huone(File.ReadAllText(@"C:\work\Academy\Tehtävät\Viikko4\KyyhkysJussi-master\KyyhkysJussi\Tulimeri.txt"));


        //public Dictionary<string, string> openWith = new Dictionary<string, string>();
        string HuoneenNimi { get; set; }
        int huoneenNumero;
        public Huone(int huoneenNumero, string huoneenNimi)
        {
            this.huoneenNumero = huoneenNumero;
            HuoneenNimi = huoneenNimi;
            List<Tavara> huoneenTavarat = new List<Tavara>();
        }

        public int huoneNyt(Huone huone)
        {
            return huone.huoneenNumero;
        }
       // Huone huone1 = new Huone(1, "eka huone");
       // Dictionary<int, Huone> huoneita = new Dictionary<int, Huone>();

        //openWith.Add("mo","i");
        //huoneita.Add(1, huone1);




        //    public Dictionary<string, string> openWith = new Dictionary<string, string>();
        //    string HuoneenNimi { get; set; }
        //    int huoneenNumero;
        //    public Huone(int huoneenNumero, string huoneenNimi)
        //    {
        //        this.huoneenNumero = huoneenNumero;
        //        HuoneenNimi = huoneenNimi;
        //        List<Tavara> huoneenTavarat = new List<Tavara>();
        //    }

        //    public int huoneNyt(Huone huone)
        //    {
        //        return huone.huoneenNumero;
        //    }
        //    Huone huone1 = new Huone(1, "eka huone");
        //    Dictionary<int, Huone> huoneita = new Dictionary<int, Huone>();

        //    openWith.Add("mo","i");
        //    huoneita.Add(1, huone1);
    }
}
