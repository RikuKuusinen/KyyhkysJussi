using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laskin
{
    class Program
    {

        static void Main(string[] args)
        {

            //int luku = 123_456_789;
            //Console.WriteLine(Convert.ToString(luku, 2));
            //return;

            Console.WriteLine("anna laskutoimitus:");
            string rivi = "";
            while ("" != (rivi = Console.ReadLine()))
            {
                string[] osat = rivi.Split(' ');

                if (osat.Length != 3)
                {
                    Console.WriteLine("Väärä määrä tietoja");
                    continue;
                }

                //int ekaluku = binääri2kymppinkata(osat[0]); 
                int ekaluku;
                int tokaluku;

                if (!int.TryParse(osat[0], out ekaluku)
                    || !int.TryParse(osat[2], out tokaluku))
                {
                    Console.WriteLine("luku ei ole kunnollinen numero");
                    continue;
                }

                string operaattori = osat[1];
                //if (operaattori != "+" 
                //    && operaattori != "-" 
                //    && operaattori != "*" 
                //    && operaattori != "/" )
                if (!"+-*/".Contains(operaattori))
                {
                    Console.WriteLine("Väärä operaattori");
                    continue;
                }


                int tulos = ekaluku + tokaluku; // ensimmäisessä vaiheessa pelkkä plus-lasku
                                                // seuraavana huomioidaan myös eri operaattorit
                                                // tee se switch-case -rakenteella
                try
                {
                    checked
                    {
                        switch (operaattori)
                        {
                            case "+":
                                tulos = ekaluku + tokaluku;
                                break;
                            case "-":
                                tulos = ekaluku - tokaluku;
                                break;
                            case "*":
                                tulos = ekaluku * tokaluku;
                                break;
                            case "/":
                                tulos = ekaluku / tokaluku;
                                break;

                        }
                    }
                    Console.WriteLine(rivi + " = " + tulos.ToString());
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("nollalla jakaminen ei onnistu");
                }
                catch (OverflowException ex)
                {
                    Console.WriteLine("ylivuoto");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("laskennassa virhe");
                }
            }
            // no mitenkäs luetaan seuraava laskutoimitus?
            /* 
             * 1. Lue syöte Console.ReadLine-metodilla
             *    (saat tehdä myös komentoriviversion jos se on helpompi)
             * 2. pura numerot ja operaattori riviltä vaikka String.Split() metodilla
             *      tuloksena on string-taulukko
             *      varmaan kannattaa tarkistaa että syöte on oikein eli
             *      rivillä on <numero> <operaattori> <numero>
             *      sovitaan että välilyönti pitää löytyä operaattorimerkin ympäriltä
             * 2.1 ensin pelkkä yhteenlasku 
             * 2.2. tutki mikä operaattorimerkki on kyseessä ja sen perusteella
             *      suorita oikea laskutoimitus
             * 3. tulosta vastaus
             * 4. aloita alusta (silmukka mutta mikä?)
             * 
             * Lisätehtävä: muuta koodia niin että se hyväksyy myös syötteen 2+3
             * eli ei ole välilyöntejä apuna
             */

        }

        static int binääri2kymppikanta(string lukumerkkijonona)
        {
            int i = 0;
            int kerroin = 1;
            foreach (var m in lukumerkkijonona.Reverse())
            {
                i += kerroin * int.Parse(m.ToString());
                kerroin *= 2;
            }
            return i;
        }
    }
}
//if (m != '1' && m != '0')
//{
//    throw new ArgumentException(lukumerkkijonona +  " ei ole binääriluku!");
//}
