using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class KulkuValine
{
    protected string tyyppi;
    protected string merkki;
    protected int vuosiMalli;
    protected double hinta;

    public KulkuValine(string tyyppi, string merkki, int vuosiMalli, double hinta)
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
    public KulkuValine(KulkuValine kulkuvaline)
    {
        tyyppi = kulkuvaline.tyyppi;
        merkki = kulkuvaline.merkki;
        vuosiMalli = kulkuvaline.vuosiMalli;
        hinta = kulkuvaline.hinta;

    }
    public virtual void TulostaTiedot()
    {
        Console.WriteLine("Auton tiedot: " + "\n---------------");
        Console.WriteLine("Ajoneuvon tyyppi: " + tyyppi);
        Console.WriteLine("Ajoneuvon merkki: " + merkki);
        Console.WriteLine("Ajoneuvon vuosimalli: " + vuosiMalli);
        Console.WriteLine("AJoneuvon hinta: " + hinta + "\n");

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
    public Auto(string tyyppi, string merkki, int vuosimalli, double hinta, int koneenKoko, string malli, int ovienLkm)
        : base(tyyppi, merkki, vuosimalli, hinta)

    {
        this.koneenKoko = koneenKoko;
        this.malli = malli;
        this.ovienLkm = ovienLkm;

    }
    public Auto(Auto auto)
    {
        koneenKoko = auto.koneenKoko;
        malli = auto.malli;
        ovienLkm = auto.ovienLkm;

    }
    //public override void TulostaTiedot()
    //{
    //    Console.WriteLine("Auton tiedot: " + "\n---------------");
    //    Console.WriteLine("Ajoneuvon tyyppi: " + tyyppi);
    //    Console.WriteLine("Ajoneuvon merkki: " + merkki);
    //    Console.WriteLine("Ajoneuvon vuosimalli: " + vuosiMalli);
    //    Console.WriteLine("AJoneuvon hinta: " + hinta + "\n");
    //    Console.WriteLine("Auton lisätiedot: ");
    //    Console.WriteLine("--------------");

    //    Console.WriteLine("Koneen koko: " + koneenKoko + " litraa");
    //    Console.WriteLine("Ajoneuvon malli: " + malli);
    //    Console.WriteLine("Ovien lukumäärä: " + ovienLkm);

    //}


    public override string ToString()
    {
        return "Ovien lukumäärä: " + ovienLkm;
    }

    public override bool Equals(object obj)
    {
        if (this.koneenKoko == ((Auto)obj).koneenKoko)
            return true;
        else return false;

    }

}
class KuormaAuto : Auto
{
    double kuormanPaino;
    double kulutusPerKg;
    double kulutus;

    public KuormaAuto(string tyyppi, string merkki,int vuosiMalli,double hinta,int koneenKoko, string malli, int ovienLkm,double kuormanPaino,double kulutusPerKg)
        : base (tyyppi,merkki,vuosiMalli,hinta,koneenKoko,malli,ovienLkm)
    {
        this.kuormanPaino = kuormanPaino;
        this.kulutusPerKg = kulutusPerKg;
    }

    public double LaskeKulutus()
    {
        kulutus = kuormanPaino * kulutusPerKg;
        return kulutus;
        
    }
    public static bool operator == (KuormaAuto kuormaAuto,KuormaAuto kuormaAuto2)
    {
        if (kuormaAuto.hinta == kuormaAuto2.hinta)
            return true;
        else
            return false;
    }
    public static bool operator !=(KuormaAuto kuormaAuto, KuormaAuto kuormaAuto2)
    {
        if (kuormaAuto.hinta != kuormaAuto2.hinta)
            return true;
        else
            return false;
    }
    public override int GetHashCode()
    {
        return base.GetHashCode();
    }
    public static bool operator < (KuormaAuto kuormaAuto, KuormaAuto kuormaAuto2)
    {
        if (kuormaAuto.kulutus < kuormaAuto2.kulutus)
            return true;
        else
            return false;
    
    }
    public static bool operator >(KuormaAuto kuormaAuto, KuormaAuto kuormaAuto2)
    {
        if (kuormaAuto.kulutus > kuormaAuto2.kulutus)
            return true;
        else
            return false;

    }
    public static KuormaAuto operator ++ (KuormaAuto kuormaAuto)
    {
        kuormaAuto.hinta += 100;
        return kuormaAuto;
    }
    public static KuormaAuto operator --(KuormaAuto kuormaAuto)
    {
        kuormaAuto.hinta -= 50;
        return kuormaAuto;
    }

    public void TulostaAsioita()
    {
        Console.WriteLine("Auton tiedot: " + "\n---------------");
        Console.WriteLine("Ajoneuvon tyyppi: " + tyyppi);
        Console.WriteLine("Ajoneuvon merkki: " + merkki);
        Console.WriteLine("Ajoneuvon vuosimalli: " + vuosiMalli);
        Console.WriteLine("AJoneuvon hinta: " + hinta + "\n");
        Console.WriteLine("Auton lisätiedot: ");
        Console.WriteLine("--------------");

        Console.WriteLine("Koneen koko: " + koneenKoko + " litraa");
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
            KuormaAuto kuormaAuto = new KuormaAuto("Kuorma-auto", "Mercedes-Benz", 1987, 23400, 6, "Joku kuorma-auton malli", 2, 4000, 0.00256);

            KuormaAuto kuormaAuto2 = new KuormaAuto("Kuorma-auto", "Toyota", 2000, 34899, 7, "Leväperä", 2, 6000, 0.00198);
            kuormaAuto.TulostaAsioita();

            Console.WriteLine("Auton kulutus on: " + kuormaAuto.LaskeKulutus() + " satasella.");

            kuormaAuto2.TulostaAsioita();

            Console.WriteLine("Auton kulutus on: " + kuormaAuto2.LaskeKulutus() + " satasella.\n");

            Console.WriteLine("Onko kuorma-autot samanlaisia? " + (kuormaAuto == kuormaAuto2));
            Console.WriteLine("Onko kuorma-autot erilaisia? " + (kuormaAuto != kuormaAuto2));
            Console.WriteLine("Onko 1 kuorma-auton kulutus pienempi kuin toisen? " + (kuormaAuto < kuormaAuto2));
            Console.WriteLine("Onko 1 kuorma-auton kulutus suurempi kuin toisen? "+(kuormaAuto > kuormaAuto2));
            kuormaAuto++;
            Console.WriteLine("Mersun hinta ++ operaattorin jälkeen: " );
            kuormaAuto.TulostaAsioita();
            kuormaAuto2--;
            Console.WriteLine("Toyotan hinta -- operaattorin jälkeen: ");
            kuormaAuto2.TulostaAsioita();




        }
    }
}
