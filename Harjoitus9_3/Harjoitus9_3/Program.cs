using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

public class Jumppa : IComparable
{
    string nimi;
    string[] ajat = new string[5];
    string[] paikat = new string[5];
    public static string lajitteluKriteeri = "nimi";

    public Jumppa(string nimi, string[] ajat, string[] paikat)
    {
        this.nimi = nimi;
        this.ajat = ajat;
        this.paikat = paikat;

    }

    public override string ToString()
    {
        string ajatstr = "";
        foreach (string str in ajat)
            ajatstr += str + "\t";

        string paikatstr = "";
        foreach (string str in paikat)
            paikatstr += str + "\t";

        return nimi + "\n\n" + ajatstr + "\n" + paikatstr + "\n";

        //return nimi + " " + ajat [0] + " " + paikat[0];

    }
    public int CompareTo(Object obj)
    {
        Jumppa jumppa = (Jumppa)obj;
        if (this.nimi.CompareTo(jumppa.nimi) < 1)
            return -1;
        else if (this.nimi.CompareTo(jumppa.nimi) > 1)
            return 1;
        else
            return 0;
    }
}

namespace Harjoitus9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable lista = new Hashtable();

            string[] ajat1 = { "Maanantaisin", "Tiistaisin", "Keskiviikkoisin", "Torstaisin", "Perjantaisin" };
            string[] paikat1 = { "Jäähallilla", "Alakoululla", "Metsässä", "Koulun pihalla", "Urheiluhallilla" };
            string[] ajat2 = { "Maanantaisin", "Tiistaisin", "Keskiviikkoisin", "Torstaisin", "Perjantaisin" };
            string[] paikat2 = { "Alakoululla", "Metsässä", "Koulun pihalla", "Urheiluhallilla", "Jäähallilla" };
            string[] ajat3 = { "Maanantaisin", "Tiistaisin", "Keskiviikkoisin", "Torstaisin", "Perjantaisin" };
            string[] paikat3 = { "Metsässä", "Koulun pihalla", "Urheiluhallilla", "Jäähallilla", "Alakoululla", };
            string[] ajat4 = { "Maanantaisin", "Tiistaisin", "Keskiviikkoisin", "Torstaisin", "Perjantaisin" };
            string[] paikat4 = { "Koulun pihalla", "Urheiluhallilla", "Jäähallilla", "Alakoululla", "Metsässä" };
            string[] ajat5 = { "Maanantaisin", "Tiistaisin", "Keskiviikkoisin", "Torstaisin", "Perjantaisin" };
            string[] paikat5 = { "Urheiluhallilla", "Jäähallilla", "Alakoululla", "Metsässä", "Koulun pihalla" };

            Jumppa j1 = new Jumppa("Zumba", ajat1, paikat1);
            Jumppa j2 = new Jumppa("Tanhu", ajat2, paikat2);
            Jumppa j3 = new Jumppa("Punppi", ajat3, paikat3);
            Jumppa j4 = new Jumppa("Mave", ajat4, paikat4);
            Jumppa j5 = new Jumppa("Ratata", ajat5, paikat5);

            lista.Add("Zumba",j1);
            lista.Add("Tanhu",j2);
            lista.Add("Punppi",j3);
            lista.Add("Mave",j4);
            lista.Add("Ratata",j5);

            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(lista[i].ToString());

            //for (int i = 0; i < 5; i++)
            //    Console.WriteLine(lista[i].ToString());

            Console.WriteLine("Alkioiden lukumäärä listalla alussa: "+lista.Count);

            bool avainLoytynyt = lista.ContainsKey("Punppi");

            Console.WriteLine("'Punppi' löytyy listalta? "+avainLoytynyt);

            bool olioLoytynyt = lista.ContainsValue(j4);

            Console.WriteLine("Jumppa 4 löytyy listalta? " + olioLoytynyt);

            string [] pumpit = new string[lista.Count];

            lista.Keys.CopyTo(pumpit, 0);

            Console.WriteLine("\nPumpit taulukon sisältö: \n");

            for (int i = 0; i < pumpit.Length; i++)
                Console.WriteLine("'" + pumpit[i] + "' ");






        }
    }
}

