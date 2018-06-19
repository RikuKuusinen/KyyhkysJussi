using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Kirja
{
    public string nimi;
    public readonly string kirjailija;
    public string kustantaja;
    public double hinta;
   
    
    public Kirja()
    {
        this.nimi = "Ei tiedossa! ";
        this.kirjailija = "Ei tiedossa! ";
        this.kustantaja = "Ei tiedossa! ";
        this.hinta = 0;
    }
    public Kirja(string nimi,string kirjailija,string kustantaja, double hinta)
    {
        this.nimi = nimi;
        this.kirjailija = kirjailija;
        this.kustantaja = kustantaja;
        this.hinta = hinta;
    }
    public void TulostaTiedot()
    {
        Console.WriteLine("Kirjan tiedot: ");
        Console.WriteLine("Kirjailija: " + kirjailija);
        Console.WriteLine("Kustantaja: " + kustantaja);
        Console.WriteLine("Kirjan hinta: {0,0:f2}", hinta);
       
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

    public double Hinta2
    {
        get
        {
            return hinta;
        }
        set
        {
            hinta = value;

            if (value > 30)
            {
                hinta = hinta - hinta * 0.1;
                Console.WriteLine("Sait 10% alennusta! ");
            }
        }
    }

}

namespace Harjoitus6_1
{
    class Program
    {

        static void Main(string[] args)
        {
            Kirja omaKirja = new Kirja();
            omaKirja = new Kirja("Taivas ja helvetti", "Karo Hämäläinen", "One on one Publishing Oy", 31.53);

            omaKirja.TulostaTiedot();

            Console.WriteLine("\nKirjailijan nimi: " + omaKirja.kirjailija);

           

        }
    }
}