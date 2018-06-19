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
        Console.WriteLine("\nTuotteen nimi: " + tuotteenNimi);
        Console.WriteLine("Tuotteen hinta: " + yksikkoHinta);
        Console.WriteLine("Tuotteiden lukumäärä: " + lukumaara);
        Console.WriteLine("Tuotteet yhteenlaskettuna: " + LaskeYhteisArvo + "\n");

    }

}
public interface IAsiakas
{
    void HaeAsiakas();

    double LaskeBonus
    {
        get;
    }
}
public class Asiakas : IAsiakas
{
    string nimi;
    double ostokset;

    public void AsiakasPohjaa(string nimi, double ostokset)
    {
        this.nimi = nimi;
        this.ostokset = ostokset;
    }
    public Asiakas()
    {
        nimi = "Ei tiedossa! ";
        ostokset = 0;
        
    }
    //public virtual string ToString()
    //{
    //    return this.nimi;
    //}
    public void HaeAsiakas()
    {
        if (this.nimi.Equals(nimi))
            Console.WriteLine(this.nimi);
        else
            Console.WriteLine("null");
    }
    public double LaskeBonus
    {
        get
        {
            if (ostokset <= 1000)
                return (ostokset * 0.02);
            else if (ostokset > 1000 && ostokset <= 2000)
                return (ostokset * 0.03);
            else
                return (ostokset * 0.05);
        }
    }
    public void TulostaUlos()
    {
        Console.WriteLine("\nAsiakkaan nimi: "+nimi);
        Console.WriteLine("Asiakkaan ostokset: "+ostokset+" euroa.");
        Console.WriteLine("Josta bonus: "+LaskeBonus);
        Console.WriteLine("Ostokset bonusten kanssa: " + (ostokset - LaskeBonus)+"\n");
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

            tuote[0].Alustatiedot("Munakoiso", 2.30, 2);
            tuote[1].Alustatiedot("Maitopurkki", 1.20, 4);
            tuote[2].Alustatiedot("Avokado", 2.56, 3);

            tuote[0].TulostaTiedot();
            tuote[1].TulostaTiedot();
            tuote[2].TulostaTiedot();

            Asiakas[] asiakas = new Asiakas[3];

            asiakas[0] = new Asiakas();
            asiakas[1] = new Asiakas();
            asiakas[2] = new Asiakas();

            asiakas[0].AsiakasPohjaa("Toni Nygrén", 4590);
            asiakas[1].AsiakasPohjaa("Elli Salo", 890);
            asiakas[2].AsiakasPohjaa("Heikki Salo", 1560);

            asiakas[0].TulostaUlos();
            asiakas[1].TulostaUlos();
            asiakas[2].TulostaUlos();


        }
    }
}
