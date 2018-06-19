using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KulkuValine
{
    protected string tyyppi;
    protected string merkki;
    protected int vuosiMalli;
    protected double hinta;

    public KulkuValine (string tyyppi, string merkki,int vuosiMalli, double hinta)
    {
        this.tyyppi = tyyppi; 
        this.merkki = merkki;
        this.vuosiMalli = vuosiMalli;
        this.hinta = hinta;
    }
    public KulkuValine()
    {
        tyyppi = "Ei tiedossa!";
        merkki = "Ei tiedossa!";
        vuosiMalli = 0;
        hinta = 0;
    }
    public virtual void TulostaTiedot()
    {
        Console.WriteLine("Auton tiedot: " + "\n---------------");
        Console.WriteLine("Ajoneuvon tyyppi: "+tyyppi);
        Console.WriteLine("Ajoneuvon merkki: " + merkki);
        Console.WriteLine("Ajoneuvon vuosimalli: " + vuosiMalli);
        Console.WriteLine("AJoneuvon hinta: " + hinta+"\n");

    }


}

class Auto : KulkuValine
{
    protected int koneenKoko;
    protected string malli;
    protected int ovienLkm;

    public Auto() : base()
    {
        koneenKoko = 0;
        malli = "Ei tiedossa! ";
        ovienLkm = 0;

    }
    public void AlustaTiedot(int koneenKoko, string malli, int ovienLkm)  

{
        this.koneenKoko = koneenKoko;
        this.malli = malli;
        this.ovienLkm = ovienLkm;

    }
    public override void TulostaTiedot()
    {
        Console.WriteLine("Auton lisätiedot: ");
        Console.WriteLine("--------------");
        
        Console.WriteLine("Koneen koko: " + koneenKoko +" litraa");
        Console.WriteLine("Ajoneuvon malli: " + malli);
        Console.WriteLine("Ovien lukumäärä: " + ovienLkm);

    }
}

namespace Harjoitus7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            KulkuValine kulkuvaline = new KulkuValine("Auto","Audi",2005,10500);

            kulkuvaline.TulostaTiedot();

            Auto auto = new Auto();
            auto.AlustaTiedot(2, "A7", 4);

            auto.TulostaTiedot();
        }
    }
}
