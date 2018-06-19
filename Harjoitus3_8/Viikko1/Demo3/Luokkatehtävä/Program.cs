using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Henkilo
{
    string etuNimi { get; set; }
    string sukuNimi { get; set; }
    int ika { get; set; }

    private readonly int id;
    
    public int Id { get { return Id; } }
      public Henkilo(string etuNimi, string sukuNimi, int ika)
    {
        this.etuNimi = etuNimi;
        this.sukuNimi = sukuNimi;
        this.ika = ika;
        id = seuraavaVapaaId++;
    }

    public override string ToString()
    {
        return etuNimi+" "+sukuNimi+" "+ika;
    }

}
public class HenkilöTesteri 
{
    Henkilo[] hlot = { new Henkilo ("Jaska", "Jokunen", 21),new Henkilo("Maija", "Meikäläinen", 28),new Henkilo("John", "Doe", 55),new Henkilo("John", "Deere", 21),
        new Henkilo("Musta", "Naamio", 355) };

    public void PulautaUlos()
    {
        foreach (var i in hlot)
        {
            Console.WriteLine(i);
        }


    }
}
namespace Luokkatehtävä
{
    class Program
    {
        static void Main(string[] args)
        {
            Henkilo persoona = new Henkilo("Elli", "Salo,", 25);
            Henkilo persoona2 = new Henkilo("Mauri", "Himos,", 27);
            Henkilo persoona3 = new Henkilo("Olli", "Pekka,", 21);

            Console.Write(persoona.ToString());
            Console.Read();

            Henkilo[] hlot = { new Henkilo ("Jaska", "Jokunen", 21),new Henkilo("Maija", "Meikäläinen", 28),new Henkilo("John", "Doe", 55),new Henkilo("John", "Deere", 21),
        new Henkilo("Musta", "Naamio", 355) };

            hlot.ToString();

        }
    }
}
