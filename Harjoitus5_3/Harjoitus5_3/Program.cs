using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Firma
{
    public string nimi;
    public string osoite;
    public int puhelinNumero;
    public double tulot;
    public double menot;

    public void AlustaTiedot(string nimi, string osoite, int puhelinNumero, double tulot, double menot)
    {
        this.nimi = nimi;
        this.osoite = osoite;
        this.puhelinNumero = puhelinNumero;
        this.tulot = tulot;
        this.menot = menot;
    }
    //Alla tiedot kopioidaan firma olion arvot kutsuvan olion attribuutteihin.
    public Firma (Firma firma)
    {
        this.nimi = firma.nimi;
        this.osoite = firma.osoite;
        this.puhelinNumero = firma.puhelinNumero;
        this.tulot = firma.tulot;
        this.menot = firma.menot;

    }
    public Firma()
    {
        nimi = "Ei tiedossa!";
        osoite = "Ei tiedossa!";
        puhelinNumero = 0;
        tulot = 0;
        menot = 0;

    }
    public void FirmanVoitto()
    {
        double firmanVoitto=(tulot - menot) / menot * 100;

        if (firmanVoitto < 2 * menot)
            Console.WriteLine("Firmalla menee kehnosti! ");
        else if (firmanVoitto >= 3 * menot && firmanVoitto<4*menot)
            Console.WriteLine("Firmalla menee kohtalaisesti! ");
        else
        {
            Console.WriteLine("Firmalla menee hyvin! ");
        }
    }
    

}


namespace Harjoitus5_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Firma firma;
            firma = new Firma();

            firma.AlustaTiedot("If", "Niittyportti 1", 0101223340, 100000, 50000);

            firma.FirmanVoitto();

            Firma firma2 = new Firma(firma);

            firma2.AlustaTiedot("Lähitapiola", "Tapiolansolmu 3", 0200199290, 150000000, 35000);

            firma2.FirmanVoitto();
        }
    }
}
