using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace KyyhkysJussi
{
    public class UI
    {
        // käynnistä peli
        // käyttöliittymän perusominaisuudet - miltä näyttää
        // liikkuminen, toiminnot (ota, anna, mene, sano "user input", lyö, loitsi "user input", käytä,)
        // parse - millä kaikella tunnistaa
        // help - komentojen tuki
        public Hahmo Pelaaja = new Hahmo("kikki", "kikki", "kikki");
        public void AloitaPeli()
        {

            var _nimi = "asd";
            var _rotu = 5;
            var _sukupuoli = "m";
            string rotu;
            string sukupuoli;
            Console.WriteLine("Anna seikkailijanimesi:");
            _nimi = Console.ReadLine();
            Console.WriteLine("Minkäs rotuinen seikkailijasi on?\n1. Ihminen\n2. Örkki\n3. Haltia");
            Int32.TryParse(Console.ReadLine(), out _rotu);
            Console.WriteLine("Milläs sukuliittimillä toivoisit seikkailijasi olevan varustettu? m/n/eos");
            _sukupuoli = Console.ReadLine();
            switch (_rotu)
            {
                case 1:
                    rotu = "Ihminen";
                    break;
                case 2:
                    rotu = "Örkki";
                    break;
                case 3:
                    rotu = "Haltia";
                    break;
                case 4:
                    rotu = "Kyyhkynen";
                    break;
                default:
                    rotu = "Maaginen vompatti";
                    break;
            }
            switch (_sukupuoli)
            {
                case "m":
                    sukupuoli = "Miäs";
                    break;
                case "n":
                    sukupuoli = "Nainen";
                    break;
                case "x":
                    sukupuoli = "Eos";
                    break;
                case "z":
                    sukupuoli = "Kaikki";
                    break;
                default:
                    sukupuoli = "Dönkkö";
                    break;
            }

            Pelaaja.Nimi = _nimi;
            Pelaaja.Rotu = rotu;
            Pelaaja.Sukupuoli = sukupuoli;

            Console.WriteLine(Pelaaja.ToString());
            Console.Write("Paina nappia aloittaaksesi seikkailun!");
            Console.ReadKey();
            Console.Clear();

        }

    }
}