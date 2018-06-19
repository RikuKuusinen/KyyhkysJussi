using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tyontekija
{
    public string nimi;
    public int id;
    public string tehtava;
    public double palkka;

    public void Alustatiedot(string nimi,int id, string tehtava,double palkka)
    {
        this.nimi = nimi;
        this.id = id;
        this.tehtava = tehtava;
        this.palkka = palkka;

    }
    public Tyontekija(Tyontekija tyontekija)
    {
        this.nimi = tyontekija.nimi;
        this.id = tyontekija.id;
        this.tehtava = tyontekija.tehtava;
        this.palkka = tyontekija.palkka;
    }
    public Tyontekija()
    {
        nimi = "Ei tiedossa! ";
        id = 0;
        tehtava = "Ei tiedossa! ";
        palkka = 0;

    }
    public void Vertailetyontekija(Tyontekija tyontekija)
    {
        if (tyontekija.palkka > this.palkka)
            Console.WriteLine(tyontekija.nimi + " saa parempaa palkkaa kuin " + this.nimi);
        else if (tyontekija.palkka == this.palkka)
            Console.WriteLine(tyontekija.nimi + " ja " + this.nimi + " saavat saman verran palkkaa! ");
        else
        {
            Console.WriteLine(this.nimi + " saa parempaa palkkaa kuin " + tyontekija);
        } 
        
    }
    public void TulostaTiedot()
    {
        Console.WriteLine("Työntekijän nimi: " + nimi);
        Console.WriteLine("Työntekijän id: " + id);
        Console.WriteLine("Työntekijän tehtävä: " + tehtava);
        Console.WriteLine("Työntekijän palkka: " + palkka);
    }

}

namespace Harjoitus5_4
{
    class Program
    {
        static void Main(string[] args)
        {

            Tyontekija[] tyontekijat = new Tyontekija[3];

            tyontekijat[0] = new Tyontekija();
            tyontekijat[1] = new Tyontekija();
            tyontekijat[2] = new Tyontekija();

            tyontekijat[0].Alustatiedot("Sari Rahkola", 12345, "Sairaanhoitaja", 2898.45);
            tyontekijat[1].Alustatiedot("Aku Ilola", 23456, "Insinööri", 3245.34);
            tyontekijat[2].Alustatiedot("Toni Nygrén", 34567, "Diplomi-Insinööri", 4278.43);

            tyontekijat[0].TulostaTiedot();
            Console.WriteLine();
            tyontekijat[1].TulostaTiedot();
            Console.WriteLine();
            tyontekijat[2].TulostaTiedot();
            Console.WriteLine();

            tyontekijat[1].Vertailetyontekija(tyontekijat[2]);




        }
    }
}
