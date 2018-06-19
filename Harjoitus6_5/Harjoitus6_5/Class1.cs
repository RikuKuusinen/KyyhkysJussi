using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Harjoitus6_5
{
    namespace Kirjallisuus
    {
        public class Kirjailija
        {
            string nimi;
            string syntymapaiva;

            Kirja kirja;

            public class Kirja
            {
                public string nimi;
                public string kirjailija;
                public string kustantaja;
                public double hinta;


                public Kirja()
                {
                    this.nimi = "Ei tiedossa! ";
                    this.kirjailija = "Ei tiedossa! ";
                    this.kustantaja = "Ei tiedossa! ";
                    this.hinta = 0;
                }
                public Kirja(string nimi, string kirjailija, string kustantaja, double hinta)
                {
                    this.nimi = nimi;
                    this.kirjailija = kirjailija;
                    this.kustantaja = kustantaja;
                    this.hinta = hinta;
                }
                public void TulostaTiedot2()
                {
                    Console.WriteLine("Kirjan tiedot: ");
                    Console.WriteLine("Kirjailija: " + kirjailija);
                    Console.WriteLine("Kustantaja: " + kustantaja);
                    Console.WriteLine("Kirjan hinta: {0,0:f2}", hinta);

                }
                public void HaeKirja(Kirja kirja)
                {
                    if (this.nimi.Equals(kirja.nimi))
                        TulostaTiedot2();
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

            public Kirjailija()
            {
                this.nimi = "Ei tiedossa";
                this.syntymapaiva = "Ei tiedossa";

                kirja = new Kirja();
            }
            public Kirjailija(string nimi, string syntymapaiva, Kirja kirja)
            {
                this.nimi = nimi;
                this.syntymapaiva = syntymapaiva;
                this.kirja = kirja;
            }
            public void Tulostatiedot()
            {

                Console.WriteLine("\nKirjailijan nimi: " + nimi);
                Console.WriteLine("\nKirjailijan syntymäpäivät: " + syntymapaiva);
            }
        }
    }
}

