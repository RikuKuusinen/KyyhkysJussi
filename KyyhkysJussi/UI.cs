using System;
using System.Collections.Generic;
using System.IO;
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
        Random rnd = new Random();
        public Hahmo Pelaaja;
        public bool PelaajaElossa;
        public Huone TämäHuone { get; set; }
        public Kartta kartta { get; set; }
        internal string[] UserInput;
        //public mene liike { get; set; }
        public bool mattopiiskaOtettu = false;
        public bool luuOtettu = false;
        public bool lentävämattoOtettu = false;
        public bool kyyhkynenElossa = true;
        public bool luurankoTalossa = false;
        public bool sormusOtettu = false;
        public bool kelloOtettu = false;
        public UI()
        {
            kartta = new Kartta();
            kartta.TeeHuoneLista();
            Pelaaja = new Hahmo("kikki", "kikki", "kikki");
            PelaajaElossa = true;
            TämäHuone = kartta.Huoneet[11];
            //liike = new mene();

        }
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

            Peli();
        }
        //Tähän luodaan reppu, jonka ominaisuuksiin kuuluu lisätä, säilyttää ja luovuttaa tavaroita.
        //Tehdään lista, johon tulee (objekti) tavaroita. Repussa on myös rahaa, joka on int.

        public List<string> reppu = new List<string>();

        public void LisaaTavara(string t)
        {
            reppu.Add(t);
        }
        public void PoistaTavara(string t)
        {
            reppu.Remove(t);
        }
        public void NaytaReppu()
        {
            Console.WriteLine("Repun sisältö: ");
            foreach (var i in reppu)
            {
                Console.WriteLine(i);
            }
        }


        public void Peli()
        {
            while (PelaajaElossa)
            {
                //anna huoneen tiedot
                Console.WriteLine(TämäHuone.HuoneenKuvaus);
                // user input
                string input = Console.ReadLine().ToLower();
                UserInput = input.Split(' ');
                ParseInput(UserInput);

            }
        }
        public void ParseInput(string[] vars)
        {
            // Liikkumiskomennot

            if (vars[0] == "p" || vars[0] == "e" || vars[0] == "l" || vars[0] == "i")
            {
                LiikuHuoneista(vars[0]);
            }

            else if (vars[0] == "liiku" && vars.Length == 1)
            {
                Console.WriteLine("Minne ajattelit mennä? (Pohjoinen, etelä, itä ja länsi ovat sallitut suunnat.)");
            }
            else if (vars[0] == "liiku" && vars[1] == "pohj*")
            {
                LiikuHuoneista("p");
            }
            else if (vars[0] == "liiku" && vars[1] == "ete*")
            {
                LiikuHuoneista("e");
            }
            else if (vars[0] == "liiku" && vars[1] == "län*")
            {
                LiikuHuoneista("l");
            }
            else if (vars[0] == "liiku" && vars[1] == "itä*")
            {
                LiikuHuoneista("p");
            }

            // Reppukomennot
            else if (vars[0] == "reppu")
            {
                NaytaReppu();
            }
            else if (vars[0] == "näyt*" && vars[1] == "rep*")
            {
                NaytaReppu();
            }

            // kiipeämiskomento
            else if (vars[0] == "kiip*" && TämäHuone == kartta.Huoneet[16])
            {
                Console.WriteLine("Kiipeät rohkeasti aidan yli kohti uusia seikkailuja!");
                Console.ReadKey();
                TämäHuone = kartta.Huoneet[12];
            }
            else if (vars[0] == "kiip*" && TämäHuone == kartta.Huoneet[8])
            {
                Console.WriteLine("Kiipeät rohkeasti aidan yli kohti uusia seikkailuja!");
                Console.ReadKey();
                TämäHuone = kartta.Huoneet[12];
            }

            // ottamiskomento ja huoneen tekstin muutos
            else if (TämäHuone == kartta.Huoneet[16] && vars[0] == "ota" && (vars[1] == "luu" || vars[1] == "reisiluu" ))
            {
                LisaaTavara("Vanhemman puoleinen reisiluu");
                Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                kartta.Huoneet[16].HuoneenKuvaus = "Taivaalla juuri tällä kohdalla on varsin synkkiä pilviä. Karut koivut muodostavat käytävän, jonka reunoilla on hautakiviä. Maassa on kolo, jossa olisi voinut olla jonkun reisiluu. Pohjoisessa näet kiviaidan, jonka taa ei nää kovin hyvin. Lännessä on hautausmaan portti, jonka takaa erotat lohikäärmeisiä muotoja. Idässä näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.Etelässäkin näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.";
                luuOtettu = true;
            }
            else if (TämäHuone == kartta.Huoneet[2] && vars[0] == "ota" && (vars[1] == "kultakello" || vars[1] == "kello" ))
            {
                LisaaTavara("kultakello");
                Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                kartta.Huoneet[2].HuoneenKuvaus = "";
            }
            else if (TämäHuone == kartta.Huoneet[2] && vars[0] == "ota" && (vars[1] == "sormus"|| vars[1] == "timanttisormus" ))
            {
                LisaaTavara(vars[1]);
                Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                kartta.Huoneet[2].HuoneenKuvaus = "";
            }
            else if (TämäHuone == kartta.Huoneet[1] && vars[0] == "ota" && vars[1] == "mattopiiska" )
            {
                LisaaTavara("mattopiiska");
                Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Naapuri näkyy istuvan kahvikupposella, joku oli varastanut hänen mattopiiskan." +
                "Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                + " näet matot mattotelineellä. Talon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello ja timanttisormus.";
            }
            else if(TämäHuone == kartta.Huoneet[4] && vars[0] == "ota" && (vars[1] == "jauheliha" || vars[1] == "kyyhkysen jauheliha"))
            {
                LisaaTavara("Kyyhkysen jauheliha");
                Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                kartta.Huoneet[4].HuoneenKuvaus = "Olet aukiolla olevan kumpareen luona ja edessäsi näet puun, jonka oksalla ei istu Kyyhkys-Jussia koska hän on kuollut. Pohjoisessa liekehtii liekkimeri."
                + "Etelässä näet lehmälauman, jonka yksilöt tuijottavat sinua lehmänsilmillään. Idässä loimuaa liekkimeri. Lännessä näet"
                + " lehmälauman märehtivän.";
            }
            // sanomiset
            else if(TämäHuone == kartta.Huoneet[13] && vars[0] == "sano")
            {
                int numero = rnd.Next(1,10);
                if (numero < 4)
                {
                    Console.WriteLine("Tomppa toteaa tomerasti \"Oispa lihhhooo.\"");
                }
                if (numero >= 4 && numero < 7)
                {
                    Console.WriteLine("Örkki örähtää \"Voe kunpa oiskii lihhhooota.\"");
                }
                if (numero >= 7 && numero < 9)
                {
                    Console.WriteLine("Leipuri lurittaa menemään \"Lihhoota, lihhoota, enemmän lihhoota\". Huomaat pienen kaipuun kyynelen Tompan silmäkulmassa.");
                }
            }
        }
        public void LiikuHuoneista(string ilmansuunta)
        {
            if (TämäHuone == kartta.Huoneet[0])
            {
                Console.WriteLine("Kävelit tulimereen ja kuolit");
                //switch (ilmansuunta)
                //{
                //    case "p":
                //        Console.WriteLine("Seinä sanoo klonk");
                //        break;
                //    case "e":
                //        TämäHuone = kartta.Huoneet[1];
                //        break;
                //    case "i":
                //        Console.WriteLine("Naapurin mökki on vieressä, seinästä läpi ei kuitenkaan pääse.");
                //        break;
                //    case "l":
                //        Console.WriteLine("Seinä sanoo klonk");
                //        break;

                //}
            }
            else if (TämäHuone == kartta.Huoneet[1])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[5];
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet vihaisen naapuriluurangon ikkunasta.");
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                }
            }
            else if (TämäHuone == kartta.Huoneet[2])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet ikkunasta helvetin.");
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[6];
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennä seinistä läpi, näet ikkunasta lehmäpellon.");
                        break;
                    case "l":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet vihaisen naapuriluurangon ikkunasta.");
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[3])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[0]; 
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[7];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[4];
                        break;
                    case "l":
                        Console.WriteLine("Edessäsi on naapurin mökki. Et voi mennä naapurin mökkin seinästä läpi.");
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[4])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[8];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[3];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[0];
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[5])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[1];
                        break;
                    case "e":
                        Console.WriteLine("Et voi mennä aidan läpi. Edessäsi on aita");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[6];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[0];
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[6])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[2];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[10];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[7];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[5];
                        break;

                }

            }

            else if (TämäHuone == kartta.Huoneet[7])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[3];
                        break;
                    case "e":
                        Console.WriteLine("Olet aloitusmökin takapihalla, et voi mennä seinästä läpi.");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[8];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[6];
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[8])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[4];
                        break;
                    case "e":
                        Console.WriteLine("Et voi mennä aidan läpi! Mene johonkin toiseen suuntaan!");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[7];
                        break;

                }
            }
            else if (TämäHuone == kartta.Huoneet[9])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Et pääse aidasta läpi");
                        break;
                    case "e":
                        Console.WriteLine("Edessäsi on leipurin mökki, ette voi mennä seinästä läpi.");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[10];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[0];
                        break;

                }
            }
            else if (TämäHuone == kartta.Huoneet[10])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[6];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[14];
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennä seinästä läpi, edessäsi on aloitusmökki.");
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[9];
                        break;
                }

            }

            else if (TämäHuone == kartta.Huoneet[11])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Edessäsi on kotimökkisi pohjoisseinä. Seinässä on ikkuna, josta näet pellon täynnä rotulehmiä.");
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[15];
                        break;
                    case "i":
                        Console.WriteLine("Edessäsi on kotimökkisi itäseinä. Ikkunasta näet omituisen pinkinsekaisen sateenkaarenvälähdyksen ja"
                            + "ikkunan raosta kantautuu vaimea 'Pruut pruut'-ääni");
                        break;
                    case "l":
                        Console.WriteLine("Edessäsi on kotimökkisi länsiseinä. Ikkunasta näet ruohikkoisen aukean, jonka keskellä kiemurtelee"
                            + "pieni polku. Polun yli loikkii sammakko.");
                        break;
                }
            }

            else if (TämäHuone == kartta.Huoneet[12])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[8];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[16];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "l":
                        Console.WriteLine("Näet kotimökkisi itäseinän.");
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[13])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Näet ikkunan ja ikkunan takana pellon, jolla tallustelee fasaani.");
                        break;
                    case "e":
                        Console.WriteLine("Näet ikkunan ja ikkunan takana roihuaa tulimeri");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[14];
                        break;
                    case "l":
                        Console.WriteLine("Näet ikkunan ja ikkunan takana roihuaa tulimeri");
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[14])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[10];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[15];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[13];
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[15])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[11];
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[16];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[14];
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[16])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Edessäsi on aita, pitääköhän mennä jotain toista reittiä.");
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[15];
                        break;

                }
            }
        }
    }
}
