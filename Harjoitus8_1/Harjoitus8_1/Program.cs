using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ITuote
{
    void HaeTuote();
    double LaskeYhteisArvo
    {
        get;
    }

}
public class Tuote : ITuote
{
    string tuotteenNimi;
    double yksikkoHinta;
    int lukumaara;

    public void Alustatiedot(string tuotteenNimi, double yksikkoHinta, int lukumaara)
    {
        this.tuotteenNimi = tuotteenNimi;
        this.yksikkoHinta = yksikkoHinta;
        this.lukumaara = lukumaara;

    }
    public Tuote()
    {
        tuotteenNimi = "Ei tiedossa!";
        yksikkoHinta = 0;
        lukumaara = 0;

    }

    public void HaeTuote()
    {
        if (this.tuotteenNimi.Equals(tuotteenNimi))
            Console.WriteLine(this.tuotteenNimi);
        else
            Console.WriteLine("null");

    }
    public double LaskeYhteisArvo
    {
        get
        {
            return (yksikkoHinta * lukumaara);
        }
    }
    public void TulostaTiedot()
    {
        Console.WriteLine("\nTuotteen nimi: "+tuotteenNimi);
        Console.WriteLine("Tuotteen hinta: "+yksikkoHinta);
        Console.WriteLine("Tuotteiden lukumäärä: "+lukumaara);
        Console.WriteLine("Tuotteet yhteenlaskettuna: "+LaskeYhteisArvo+"\n");

    }

}

namespace Harjoitus8_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Tuote[] tuote = new Tuote[3];

            tuote[0] = new Tuote();
            tuote[1] = new Tuote();
            tuote[2] = new Tuote();

            tuote[0].Alustatiedot("Munakoiso",2.30,2);
            tuote[1].Alustatiedot("Maitopurkki", 1.20, 4);
            tuote[2].Alustatiedot("Avokado", 2.56, 3);

            tuote[0].TulostaTiedot();
            tuote[1].TulostaTiedot();
            tuote[2].TulostaTiedot();

            tuote[0].HaeTuote();
           
        }
    }
}
