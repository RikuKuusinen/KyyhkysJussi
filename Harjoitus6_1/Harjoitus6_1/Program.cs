using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Kirja
{
    public string nimi;
    public string kirjailija;
    public string kustantaja;
    public double hinta;
    public static string teemanNimi;

    public void Alustatiedot(string nimi,string kirjailija, string kustantaja,double hinta, string teemanNimi2)
    {
        this.nimi = nimi;
        this.kirjailija = kirjailija;
        this.kustantaja = kustantaja;
        this.hinta = hinta;
        teemanNimi = teemanNimi2;
        
        
    }
    public Kirja (Kirja kirja)
    {
        nimi = kirja.nimi;
        kirjailija = kirja.kirjailija;
        kustantaja = kirja.kustantaja;
        hinta = kirja.hinta;
    }
    public Kirja()
    {
        nimi = "Ei tiedossa! ";
        kirjailija = "Ei tiedossa! ";
        kustantaja = "Ei tiedossa! ";
        hinta = 0;
        teemanNimi = "Ei tiedossa! ";
    }
    public void TulostaTiedot()
    {
        Console.WriteLine("Kirjan tiedot: ");
        Console.WriteLine("Kirjailija: " + kirjailija);
        Console.WriteLine("Kustantaja: " + kustantaja);
        Console.WriteLine("Kirjan hinta: " + hinta);
        Console.WriteLine("Kirjan teema: " + teemanNimi);
    }
    public void HaeKirja(Kirja kirja)
    {
        if (this.nimi.Equals(kirja.nimi))
            TulostaTiedot();
        else
        {
            Console.WriteLine("Kirjaa ei löytynyt! ");
        }
    }
    public static void VaihdaTeema()
    {
        teemanNimi = "Kauhukirjallisuus";
    }


}

namespace Harjoitus6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirja kirja;
            kirja = new Kirja();

            kirja.Alustatiedot("Taivas ja helvetti", "Karo Hämäläinen", "One on one Publishing Oy", 31.53, "Tietokirjallisuus");

            Kirja kirja2 = new Kirja();

            kirja2.Alustatiedot("Taivas ja helvetti", "Karo Hämäläinen", "One on one Publishing Oy", 31.53, "Tietokirjallisuus");

            Kirja kirja3 = new Kirja();

            kirja3.Alustatiedot("Arvosijoittaja", "Jukka Oksaharju", "Oksaharju Capital Oy", 21.45, "Tietokirjallisuus");

            kirja.HaeKirja(kirja2);

            Console.WriteLine();

            kirja2.HaeKirja(kirja3);

            Console.WriteLine();

            Kirja.VaihdaTeema();

            Console.WriteLine();

            kirja.HaeKirja(kirja2);
        }
    }
}
