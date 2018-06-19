using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Kirja

{
    public string kirjanNimi;
    public string kirjoittajanNimi;
    public int idNumero;
    public double kappaleHinta;

    public void AlustaTiedot (string kirjanNimi, string kirjoittajanNimi, int idNumero, double kappaleHinta)
    {
        this.kirjanNimi = kirjanNimi;
        this.kirjoittajanNimi = kirjoittajanNimi;
        this.idNumero = idNumero;
        this.kappaleHinta = kappaleHinta;
    }
    public void TulostaTiedot()
    {
        Console.WriteLine("Kirjan tiedot: ");
        Console.WriteLine("----------------");
        Console.WriteLine("Kirjan nimi: " + kirjanNimi);
        Console.WriteLine("Kirjoittajan nimi: " + kirjoittajanNimi);
        Console.WriteLine("Id-numero: " + idNumero);
        Console.WriteLine("Kappalehinta: " + kappaleHinta);
    }

}

namespace Harjoitus5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kirja kirja;
            kirja = new Kirja();

            kirja.AlustaTiedot("Sijoita kuin guru", "Jukka Oksaharju", 12345, 21.95);

            kirja.TulostaTiedot();
        }
    }
}
