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
        public static Hahmo Pelaaja { get; set; }
        public bool PelaajaElossa;
        public Huone TämäHuone { get; set; }
        public Kartta kartta { get; set; }
        internal string[] UserInput;
        
        
        //public mene liike { get; set; }
        public bool mattopiiskaOtettu = false;
        public bool luuOtettu = false;
        public bool lentävämattoOtettu = false;
        public bool kyyhkynenElossa { get; set; }
        public bool luurankoTalossa = false;
        public bool sormusOtettu = false;
        public bool kelloOtettu = false;
        public bool koiraJulisteOtettu = false;
        public bool silinteriHattuOtettu = false;
        public bool avainOtettu = false;
        KyyhkysJussi Kyyhky = new KyyhkysJussi();
        public bool LiikuttuBool = true;
        public bool MattopiiskaAnnettu = false;
        public bool LihaOtettu = false;
        public bool onkoPäässäHattu = false;
        public bool koiraJulisteAnnettu = false;
        public bool luurankoElossa = true;
      

        // Mittaa sitä kuinka monta vuoroa on mennyt siitä, että fasaani on viimeksi piiloutunut, jos arvo on 3 Peli() muuttaa tekstin niin, että fasaani näkyy jälleen. 
        int FasaaniPiilossa = 3;

        public UI() //Jukka
        {
            kyyhkynenElossa = true;
            kartta = new Kartta();
            kartta.TeeHuoneLista();
            Pelaaja = new Hahmo("kikki", "kikki", "kikki");
            PelaajaElossa = true;
            TämäHuone = kartta.Huoneet[11];
            //liike = new mene();

        }
        public void AloitaPeli() // Jukka
        {
            Console.WriteLine("Tervetuloa Kyyhkys-Jussin seikkailuun!\n");
            Helppi();
            Console.Write("Paina nappia luodaksesi pelaajahahmosi!");
            Console.ReadKey();
            Console.Clear();

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
            _sukupuoli = Console.ReadLine().ToLower().Trim(' ', ',', '.','-','<','>','1', '2', '3', '4', '5', '6', '7', '8', '9', '0', '+');
            //if (_sukupuoli != "m" || _sukupuoli != "f" || _sukupuoli != "eos" || _sukupuoli != "z")
            
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
                case "eos":
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
            NimiMuutokset();
            Peli();
        }
        //Tähän luodaan reppu, jonka ominaisuuksiin kuuluu lisätä, säilyttää ja luovuttaa tavaroita.
        //Tehdään lista, johon tulee (objekti) tavaroita. Repussa on myös rahaa, joka on int.

        public List<string> reppu = new List<string>(); // Elli

        public void LisaaTavara(string t) //Elli
        {
            reppu.Add(t);
        }
        public void PoistaTavara(string t)
        {
            reppu.Remove(t);
        }
        public void NaytaReppu()
        {
            Console.WriteLine();
            Console.WriteLine("Repun sisältö: ");
            foreach (var i in reppu)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
        }
        public void tyhjennaReppu()
        {
            reppu.Clear();
        }
        public void NimiMuutokset() // Jukka
        {
            kartta.Huoneet[13].HuoneenKuvaus = "Sieraimiisi sulloutuvat suunnattomat sulotuoksut. \n Mökissä leipuriörkki Okssu vääntää torttua virne naamallaan. Okssu toteaa tomerasti, \n \"Terve, " + UI.Pelaaja.Nimi + "!\" Pullaa paistuu uunissa Pohjoiseen päin \n avautuu komia niitty, jossa näkyy jonkunlaista liikettä";

        }
        public void Liikuttu() // Jukka
        {
            LiikuttuBool = true;
            Console.WriteLine("Lähdet käpyttelemään.");
            if (TämäHuone == kartta.Huoneet[0])
            {
                Console.WriteLine(kartta.Huoneet[0].HuoneenKuvaus);
                GameOver();
            }
            else if (PelaajaElossa)
            { 
            Peli();
            }
            

        }
        public void Peli()
        {
            while (PelaajaElossa)
            {
            //seurataan fasaanin liikkeitä - Jukka
            if (FasaaniPiilossa == 7)
                {
                    kartta.Huoneet[9].HuoneenKuvaus = "Olet niityllä ja näet ison fasaanin, joka tuijottaa sinua isoilla silmillään. \- Pohjoisessa näet korkean lauta-aidan. \- Etelässä"
                + " näet leipurin talon, jonka ikkunassa leipuri naputtaa kauhalla kämmeneensä. Idässä näet ruohikkoisen aukean, jonka keskellä"
                + " kiemurtelee polku. Lännessä loimuaa liekkimeri.";
                }
                FasaaniPiilossa++;

                //Tässä tarkistetaan liikkuuko pelaaja huoneesta toiseen. Jos liikkuu, tulee huoneenkuvaus. Jos ei liiku, ei tule huoneenkuvausta
                if (LiikuttuBool)
                {
                    //anna huoneen tiedot
                    Console.WriteLine(TämäHuone.HuoneenKuvaus);
                    
                    // jos hattu on päässä
                    if (TämäHuone == kartta.Huoneet[13] && onkoPäässäHattu)
                    {
                        int numero = rnd.Next(1,5);
                        if (numero == 1)
                        { 
                            Console.WriteLine("Petyt syvästi, kun Okssu ei huomioi hienoa hattuasi.");
                        }
                        if (numero == 2)
                        {
                            Console.WriteLine("Okssu murisee: \"Oisipa mullakin noin hiano hattu.\"");
                        }
                        if (numero == 3)
                        {
                            Console.WriteLine("Okssu ihmettelee: \"Onko hattusi tehty siiselin sisuksista vai miksi se on noin siisti?\"");
                        }
                        if (numero == 4)
                        {
                            Console.WriteLine("Okssu parahtaa: \"Onpas sinulla ruma silinterihattu!\"");
                        }
                        if (numero == 5)
                        {
                            Console.WriteLine("Okssu huutaa: \"Onko tuo minun hattuni?!\"");
                        }

                    }
                    // gameover kun huoneessa 17
                    if (TämäHuone == kartta.Huoneet[17])
                    {
                        GameOver();
                    }

                    LiikuttuBool = false;
                }
                else 
                {
                   
                }
                // user input
                string input = Console.ReadLine().ToLower();
                UserInput = input.Split(' ');
                ParseInput(UserInput);

            }
        }
        public void ParseInput(string[] vars)
        {
            // Liikkumiskomennot - Anni

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

            // Reppukomennot - Elli
            else if (vars[0] == "reppu")
            {
                NaytaReppu();
            }
            else if (vars[0] == "näytä" && vars[1] == "reppu")
            {
                NaytaReppu();
            }

            // kiipeämiskomento - Jukka
            else if (vars.Length == 2 && vars[0] == "kiipeä" && vars[1] == "p" && TämäHuone == kartta.Huoneet[16])
            {
                Console.WriteLine("Kiipeät rohkeasti aidan yli kohti uusia seikkailuja!");
                TämäHuone = kartta.Huoneet[12];
                LiikuttuBool = true;
            }
            else if (vars.Length == 2 && vars[0] == "kiipeä" && vars[1] == "e" && TämäHuone == kartta.Huoneet[8])
            {
                Console.WriteLine("Kiipeät rohkeasti aidan yli kohti uusia seikkailuja!");
                TämäHuone = kartta.Huoneet[12];
                LiikuttuBool = true;
            }
            else if (vars.Length == 2 && vars[0] == "kiipeä" && vars[1] == "p" && TämäHuone == kartta.Huoneet[12])
            {
                Console.WriteLine("Kiipeät rohkeasti aidan yli kohti uusia seikkailuja!");
                TämäHuone = kartta.Huoneet[8];
                LiikuttuBool = true;
            }
            else if (vars.Length == 2 && vars[0] == "kiipeä" && vars[1] == "e" && TämäHuone == kartta.Huoneet[12])
            {
                Console.WriteLine("Kiipeät rohkeasti aidan yli kohti uusia seikkailuja!");
                TämäHuone = kartta.Huoneet[16];
                LiikuttuBool = true;
            }
            else if (vars.Length == 1 && vars[0] == "kiipeä")
            {
                Console.WriteLine("Mihinkäs meinasit kiivetä?"); 
            }
            else if (vars.Length == 2 && vars[0] == "kiipeä" && (vars[1] != "p" || vars[1] != "e"))
            {
                Console.WriteLine("Mihinkäs meinasit kiivetä? Ei täällä ole mitään sellaista järkevää kiivettävää");
            }


            // ottamiskomento ja huoneen tekstin muutos - Elli
            else if (vars.Length == 1 && vars[0] == "ota")
            {
                Console.WriteLine("Yritähän ottaa jotain järkevää.\n");
            }
            else if (TämäHuone == kartta.Huoneet[16] && vars[0] == "ota" && (vars[1] == "luu" || vars[1] == "reisiluu"))
            {
                if (luuOtettu == true)
                {
                    Console.WriteLine("Ei täällä mitään luita ole otettavana enää! Tsekkaa reppus.");
                }
                else
                {
                    LisaaTavara("Vanhemman puoleinen reisiluu");
                    luuOtettu = true;
                    Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                    kartta.Huoneet[16].HuoneenKuvaus = "Taivaalla juuri tällä kohdalla on varsin synkkiä pilviä. Karut koivut muodostavat käytävän, jonka reunoilla on hautakiviä. Maassa on kolo, jossa olisi voinut olla jonkun reisiluu. Pohjoisessa näet kiviaidan, jonka taa ei nää kovin hyvin. Lännessä on hautausmaan portti, jonka takaa erotat lohikäärmeisiä muotoja. Idässä näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.Etelässäkin näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.";
                    
                }

            }
            //kellon ottaminen
            else if (TämäHuone == kartta.Huoneet[2] && vars[0] == "ota" && (vars[1] == "kultakello" || vars[1] == "kello"))
            {
                if (kelloOtettu == true)
                {
                    Console.WriteLine("Ei täällä mitään kelloja enää ole, katso repustasi!");
                }
                else
                {
                    LisaaTavara("kultakello");
                    kelloOtettu = true;
                    Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                    if (sormusOtettu == true && mattopiiskaOtettu == true)
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Naapuri istuu kahvilla pöydän ääressä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                    + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                    + " näet mattotelineen.";
                    }
                    else if (sormusOtettu == true && mattopiiskaOtettu == false)
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                   + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                   + " näet mattoja hakkaavan naapurin.";
                    }
                    else if (sormusOtettu == false && mattopiiskaOtettu == true)
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Naapuri näkyy istuvan kahvikupposella, joku oli varastanut hänen mattopiiskan. " +
                    "Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                    + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                    + " näet matot mattotelineellä. Talon sisällä näyttää olevan arvokkaita tavaroita, kuten timanttisormus.";
                    }
                    else
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                    + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                    + " näet mattoja hakkaavan naapurin";
                    }
                }

            }
            //sormuksen ottaminen
            else if (TämäHuone == kartta.Huoneet[2] && vars[0] == "ota" && (vars[1] == "sormus" || vars[1] == "timanttisormus"))
            {
                if (sormusOtettu == true)
                {
                    Console.WriteLine("Ei täällä mitään timanttisormusta enää ole, katso repustasi!");
                }
                else
                {
                    LisaaTavara(vars[1]);
                    sormusOtettu = true;
                    Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                    if (kelloOtettu == true && mattopiiskaOtettu == true)
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Naapuri istuu kahvilla pöydän ääressä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                    + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                    + " näet mattotelineen.";
                    }
                    else if (kelloOtettu == true && mattopiiskaOtettu == false)
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                   + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                   + " näet mattoja hakkaavan naapurin.";
                    }
                    else if (kelloOtettu == false && mattopiiskaOtettu == true)
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Naapuri näkyy istuvan kahvikupposella, joku oli varastanut hänen mattopiiskan." +
                    "Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                    + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                    + " näet matot mattotelineellä. Talon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello.";
                    }
                    else
                    {
                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                    + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                    + " näet mattoja hakkaavan naapurin";
                    }
                }


            }
            //mattopiiskan ottaminen
            else if (TämäHuone == kartta.Huoneet[1] && vars[0] == "ota" && vars[1] == "mattopiiska")
            {
                if (!luurankoTalossa)
                {
                    Console.WriteLine("Luuranko ärjäisee: \"Äläpäs yritä senkin nulikka, tämä on minun mattopiiskani!\" ja kumauttaa sinua päähän. Nyt on kuhmu ja sattuu. Kannattiko?");
                    Peli();
                }
                else
                {
                    if (mattopiiskaOtettu == true)
                    {
                        Console.WriteLine("Ei täällä mitään mattopiiskaa enää ole, katso repustasi!");
                    }
                    else
                    {
                        mattopiiskaOtettu = true;
                        LisaaTavara("mattopiiska");
                        Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");


                        kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Naapuri näkyy istuvan kahvikupposella." +
                       "Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, jonka ikkunasta näkyy aita ja"
                       + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                       + " näet matot mattotelineellä.";

                        if (kelloOtettu == true && sormusOtettu == true)
                        {
                            kartta.Huoneet[1].HuoneenKuvaus = "Näet edessäsi mattotelineen."
                   + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. Idässä näet naapurin mökin länsiseinän.\n"
                   + "  Kahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n";
                        }
                        else if (kelloOtettu == true)
                        {
                            kartta.Huoneet[1].HuoneenKuvaus = "Näet edessäsi mattotelineen."
                   + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. Idässä näet naapurin mökin länsiseinän.\n"
                   + " Ikkunan takana kimaltelee kultakello. Kahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n";
                        }
                        else
                        {
                            kartta.Huoneet[1].HuoneenKuvaus = "Näet edessäsi mattotelineen."
                   + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. Idässä näet naapurin mökin länsiseinän.\n"
                   + " Ikkunan takana kimaltelee timanttisormus. Kahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n";
                        }

                    }
                }

            }
            //jauhelihan ottaminen - Elli, Henni
            else if (TämäHuone == kartta.Huoneet[4] && vars[0] == "ota" && !kyyhkynenElossa && (vars[1] == "jauheliha" || vars[1] == "kyyhkysen jauheliha"))
            {
                if (LihaOtettu == true)
                {
                    Console.WriteLine("Taitaa jauhelihat olla jo repussa!");
                }
                else
                {
                    LisaaTavara("Kyyhkysen jauheliha");
                    LihaOtettu = true;
                    Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                    kartta.Huoneet[4].HuoneenKuvaus = "Olet aukiolla olevan kumpareen luona ja edessäsi näet puun, jonka oksalla on enää Kyyhkys-Jussin muisto. Pohjoisessa liekehtii liekkimeri."
                    + "Etelässä näet lehmälauman, jonka yksilöt tuijottavat sinua lehmänsilmillään. Idässä loimuaa liekkimeri. Lännessä näet"
                    + " lehmälauman märehtivän.";
                }

            }
            //Julisteen ottaminen
            else if (TämäHuone == kartta.Huoneet[11] && vars[0] == "ota" && (vars[1] == "juliste" || vars[1] == "koirajuliste"))
            {
                if (koiraJulisteOtettu == true)
                {
                    Console.WriteLine("Ei täällä mitään julisteita ole, onko sinulla repussa jo sellainen?");
                }
                else
                {
                    LisaaTavara("Koirajuliste");
                    koiraJulisteOtettu = true;
                    Console.WriteLine($"{vars[1]} otettu ja lisätty reppuun.");
                    if (silinteriHattuOtettu == true)
                    {
                        kartta.Huoneet[11].HuoneenKuvaus = "Olet mökissäsi, jossa on pöytä. Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. Etelään päin on ovi.";
                    }
                    else
                    {
                        kartta.Huoneet[11].HuoneenKuvaus = "Olet mökissäsi, jossa on pöytä, jolla on silinterihattu. Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. Etelään päin on ovi.";
                    }
                }


            }
            //hatun ottaminen
            else if (TämäHuone == kartta.Huoneet[11] && vars[0] == "ota" && (vars[1] == "silinterihattu" || vars[1] == "hattu"))
            {
                if (silinteriHattuOtettu == true)
                {
                    Console.WriteLine("Ei täällä mitään hattuja enää ole");
                }
                else
                {
                    silinteriHattuOtettu = true;
                    onkoPäässäHattu = true;
                    Console.WriteLine($"{vars[1]} otettu ja laitettu päähän.");
                    if (koiraJulisteOtettu == true)
                    {
                        kartta.Huoneet[11].HuoneenKuvaus = "Olet mökissäsi, jossa on pöytä. Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. Etelään päin on ovi.";
                    }
                    else
                    {
                        kartta.Huoneet[11].HuoneenKuvaus = "Olet mökissäsi, jossa on pöytä. Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. Etelään päin on ovi, jossa on komea koirajuliste.";
                    }

                }


            }
            //maton ottaminen
            else if (TämäHuone == kartta.Huoneet[5] && vars[0] == "ota" && vars[1] == "matto")
            {
                Console.WriteLine("Noinkohan ajattelit kanniskella mattoa paikasta toiseen? Turhaa painolastia, eiköhän anneta niiden mattojen vain olla");
            }
            // lohikäärmeen kanssa asiointi -Elli
            else if (TämäHuone == kartta.Huoneet[15] && vars[0] == "lyö")
            {
                int numero = rnd.Next(1, 10);
                if (numero < 4)
                {
                    Console.WriteLine("Lohikäärme sanoo \"Älä lyö!\"");
                }
                if (numero >= 4 && numero < 7)
                {
                    Console.WriteLine("Lohikäärme purskahtaa itkuun.");
                }
                if (numero >= 7 && numero < 10)
                {
                    Console.WriteLine("Lohikäärme sanoo\"Haista paska!\"");
                }
            }
            //lohikäärmeelle puhuminen
            else if (TämäHuone == kartta.Huoneet[15] && vars[0] == "sano")
            {
                int numero = rnd.Next(1, 10);
                if (numero < 4)
                {
                    Console.WriteLine("Lohikäärme sanoo \"Moi!\"");
                }
                if (numero >= 4 && numero < 7)
                {
                    Console.WriteLine("Lohikäärme halaa sinua intiimisti.");
                }
                if (numero >= 7 && numero < 10)
                {
                    Console.WriteLine("Lohikäärme antaa sinulle vinkin! \" Mene hautuumaalle ja koita kiivetä aidan yli.");
                }
            }

            //yksisarvisen lyöminen -Elli
            else if (TämäHuone == kartta.Huoneet[12] && vars[0] == "lyö")
            {
                Console.WriteLine("Olitpa tyhmä kun löit yksisarvista! Yksisarvinen tökkäsi sarvensa sinuun ja kuolit väkivaltaisen kuoleman.");
                GameOver();
            }

            //fasaanin lyöminen - Elli / Jukka + Henni
            else if (TämäHuone == kartta.Huoneet[9] && FasaaniPiilossa >= 3 && vars[0] == "lyö")
            {
                Console.WriteLine("Fasaani karkasi. Ehkä se tulee takaisin jos olet kiltimpi.");
                kartta.Huoneet[9].HuoneenKuvaus = "Olet niityllä, jossa yleensä on fasaani. Tällä kertaa fasaani on lähtenyt karkuteille kun häntä on yritetty pahoinpidellä. Pohjoisessa näet korkean lauta-aidan. Etelässä"
            + " näet leipurin talon, jonka ikkunassa leipuri naputtaa kauhalla kämmeneensä. Idässä näet ruohikkoisen aukean, jonka keskellä"
            + " kiemurtelee polku. Lännessä loimuaa liekkimeri.";
                // fasaani asetetaan palaavaksi kolmen liikkumisen jälkeen
                FasaaniPiilossa = 0;

            }
            else if (TämäHuone == kartta.Huoneet[9] && FasaaniPiilossa < 3 && vars[0] == "lyö")
            {
                Console.WriteLine("Paremman lyötävän puutteessa mäjäytät itseäsi mahaan.");
                
            }

            // sanomiset leipuri -Elli
            else if (TämäHuone == kartta.Huoneet[13] && vars[0] == "sano")
            {
                int numero = rnd.Next(1, 10);
                if (numero < 4)
                {
                    Console.WriteLine("Okssu toteaa tomerasti \"Oispa lihhhooo.\"");
                }
                if (numero >= 4 && numero < 7)
                {
                    Console.WriteLine("Örkki örähtää \"Voe kunpa oiskii lihhhooota.\"");
                }
                if (numero >= 7 && numero < 9)
                {
                    Console.WriteLine("Leipuri lurittaa menemään \"Lihhoota, lihhoota, enemmän lihhoota\". Huomaat pienen kaipuun kyynelen Okssun silmäkulmassa.");
                }
            }
            //fasaani -Elli, Henni
            else if (TämäHuone == kartta.Huoneet[9] && FasaaniPiilossa == 3 && vars[0] == "sano" && vars[1] == "piip" && vars[2] == "piip" && vars[3] == "motherfucker")
            {
                Console.WriteLine("\"Loukkasit äitiäni ja nyt kuolet!\" Sanoi fasaani. Fasaani alkaa raivokkaasti repimään sinusta palasia irti ja veri roiskuu.");
                GameOver();
            }

            else if (TämäHuone == kartta.Huoneet[9] && FasaaniPiilossa != 3 && vars[0] == "sano")
            {
                Console.WriteLine("Itsekseen juttelemista pidetään joissain piireissä hulluuden merkkinä...");
            }

            //yksisarvisen kanssa -Henni
            else if (TämäHuone == kartta.Huoneet[12] && vars[0] == "sano" && vars[1] == "pruu" && vars[2] == "pruu")
            {
                Console.WriteLine("\"Tervetuloa niitylleni," + UI.Pelaaja.Nimi + "! Kerron sinulle salaisuuden! Taikasanan, jolla pääset ihmeelliseen maailmaan! Lausu siis 'teleport pruu pruu' ja anna tuulen kuljettaa <3 <3 <3 <3\"");
            }

            //teleportti / loitsi -Henni, Jukka


            else if (vars.Length == 3 && vars[0] == "loitsi" && vars[1] == "teleport" && int.TryParse(vars[2], out int indeksi) && indeksi <= 17 && indeksi >= 0) //vars.Any(_ => kartta.Huoneet.Contains(_))
            {
                Console.WriteLine("Il teleportatsioone molto magnifico!");
                TämäHuone = kartta.Huoneet[indeksi]; //vars.Any(_ => kartta.Huoneet.Contains(_));
                LiikuttuBool = true;
            }

            else if (vars.Length == 4 && vars[0] == "loitsi" && vars[1] == "teleport" && vars[2] == "pruu" && vars[3] == "pruu")
            {
                if(Pelaaja.Rotu == "Haltia")
                {
                    Console.WriteLine("Saavut kääpiöin salatulle saarelle. Herkässä pyllyssäsi tunnet sellaista kutinaa, että kohta lähtee ruumiinosia irti - sinulta. \n" +
                "Olet joutunut kääpiöiden Shangri-La:han - Kuppakivelle! Yrität juosta lähestyviä kääpiöitä pakoon mutta, kompastut liian kulmikkaaseen kiveen. Kääpiöt saavat sinut kiinni ja onneksi menetät tajuntasi jo siinä vaiheessä, kun kääpiöt repivät kätesi irti.\n");
                GameOver();
                }
                else
                { 
                Console.WriteLine("Il teleportatsioone molto magnifico!");
                TämäHuone = kartta.Huoneet[17];
                LiikuttuBool = true;
                }
            }
            else if (vars.Length == 2 && vars[0] == "loitsi" && vars[1] == "teleport")
            {
                               
                    int numero = rnd.Next(0, 17);
                    Console.WriteLine("Surprizio!");
                    TämäHuone = kartta.Huoneet[numero];
                    LiikuttuBool = true;
                
            }
            else if (vars.Length == 2 && vars[0] == "loitsi" && vars[1] != "teleport")
            {
                Console.WriteLine("Höpiset itseksesi jotain kummallisuuksia ja viuhdot käsillä vimmatusti, mutta eetteri ei vastaa. Olisiko väärä loitsusyntaksi?");
            }



            //luurangon kanssa --- tämä else-lause ei taida tehdä mitään? 
            //else if (TämäHuone == kartta.Huoneet[1])
            //{
            //    if (luuOtettu == true)
            //    {
            //        Console.WriteLine("\"Tuo on minun isosetäni reisiluu senkin torvelo!\" Huutaa luuranko ja alkaa hakata sinua kuolettavasti reisiluulla. Tunnet kuinka luu pureutuu lihaasi ja verta ja suolenpätkiä lentelee. ");
            //        GameOver();
            //    }

            //}

            //luuranko kahville / sano kahvi Anni
            else if (TämäHuone == kartta.Huoneet[1] && vars[0] == "sano" && vars[1] == "kahvi")
            {
                luurankoTalossa = true;
                Console.WriteLine("\"Kylläpäs kahvihammastani kolottaa, taidankin pitää pienen kahvitauon!\" luuranko-naapuri toteaa ja lähtee astelemaan kohti mökkiään jättäen mattopiiskan maahan lojumaan.\n");
                if(kelloOtettu == false && sormusOtettu == false)
                {
                    kartta.Huoneet[1].HuoneenKuvaus = "Maassa lojuu mattopiiska."
                + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. \nIdässä näet naapurin mökin länsiseinän."
                + " Ikkunan takana kimaltelee kultakello ja timanttisormus. \nKahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.";

                    kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, \njonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. \nIdässä on seinä, jonka ikkunasta"
                + " näet mattotelineen. \nTalon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello ja timanttisormus.\n";
                }
                else if(kelloOtettu == true && sormusOtettu == false)
                {
                    kartta.Huoneet[1].HuoneenKuvaus = "Maassa lojuu mattopiiska."
             + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. \nIdässä näet naapurin mökin länsiseinän."
             + " Ikkunan takana kimaltelee timanttisormus. \nKahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n";

                    kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, \njonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. \nIdässä on seinä, jonka ikkunasta"
                + " näet mattotelineen. \nTalon sisällä näyttää olevan arvokkaita tavaroita, kuten timanttisormus.\n";
                }
                else if(kelloOtettu == false && sormusOtettu == true)
                {
                    kartta.Huoneet[1].HuoneenKuvaus = "Maassa lojuu mattopiiska."
          + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. \nIdässä näet naapurin mökin länsiseinän."
          + " Ikkunan takana kimaltelee kultakello. \nKahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n";

                    kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, \njonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. \nIdässä on seinä, jonka ikkunasta"
                + " näet mattotelineen. \nTalon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello.\n";
                }
                else if (kelloOtettu == true && sormusOtettu == true)
                {
                    kartta.Huoneet[1].HuoneenKuvaus = "Maassa lojuu mattopiiska."
                + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. \nIdässä näet naapurin mökin länsiseinän."
                + " \nKahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n";

                    kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, \njonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. \nIdässä on seinä, jonka ikkunasta"
                + " näet mattotelineen. \n";
                }

                
            }

            //jauhelihan antaminen -Elli
            else if (TämäHuone == kartta.Huoneet[13] && vars[0] == "anna" && (vars[1] == "jauheliha" || vars[1] == "kyyhkysen jauheliha"))
            {
                Console.WriteLine("\"Ihanaa, olen niin onnellinen! Sain vihdoin lihaa! Kyllä alan nyt heti tästä leipomaan lihapiirakkaa!\" \nSanoo leipuri Okssu." +
                    " Okssu alkaa leipomaan lihapiirakkaa ponnekkaasti. \nKun lihapiirakka on valmis, leipuri hotkii piirakan, masentuu \nja hyppää masennuksissaan länsi-ikkunasta hohkaavaan tulimereen");
                kartta.Huoneet[13].HuoneenKuvaus = "Mökin pöydällä on puoliksi leivottu torttu. Jäät kaipaamaan tomeraa tervehdystä jostain kummasta syystä. Uunissa on musta hiilikikkare, joka on joskus saattanut olla pulla. Pohjoisseinän ikkunasta avautuu komia niitty, jossa näkyy jonkunlaista liikettä. Etelän suunnalla oleva ikkuna on rikki ja liekit luikuttavat ikkunan raosta.\n";

            }
            //mattopiiskan antaminen
            else if (TämäHuone == kartta.Huoneet[4] && vars[0] == "anna" && vars[1] == "mattopiiska")
            {
                if (mattopiiskaOtettu = true && Kyyhky.Mielenterveys < 5)
                {
                    Console.WriteLine("Kyykynen hakkaa sinut kuoliaaksi mattopiiskalla kaikessa hiljaisuudessa \nlehmien katsoessa hyväksyvästi. Veri lentää ja suolenpätkät pursuavat. \nKukaan ei tykkää kiusaajista!");
                    MattopiiskaAnnettu = true;
                    GameOver();
                }

            }
            //koirajulisteen antaminen
            else if ((TämäHuone == kartta.Huoneet[3] || TämäHuone == kartta.Huoneet[7] || TämäHuone == kartta.Huoneet[8]) && vars[0] == "anna" && (vars[1] == "koirajuliste" || vars[1] == "juliste"))
            {

                Console.WriteLine("Lehmät riemastuvat koirajulisteesta ja alkavat katsoa sitä!");
                koiraJulisteAnnettu = true;

            }




            //Kyyhkysinteraktiot -Jukka
            else if (TämäHuone == kartta.Huoneet[4] && vars[0] == "sano" && vars.Any(_ => Kyyhky.HaittaSanat.Contains(_)) && MattopiiskaAnnettu)
            {
                Console.WriteLine("Kyyhkynen kaivaa taskustaan antamasi mattopiiskan, lentää luoksesi \nja hakkaa sinua niin kovaa, että lihasi erottuu luista. \nViimeinen asia, jonka näet, on oma veresi joka roiskuu kaarissa.");
                GameOver();
            }
            else if (TämäHuone == kartta.Huoneet[4] && vars[0] == "sano" && vars.Any(_ => Kyyhky.HaittaSanat.Contains(_)))
            {
                Kyyhky.VähennäMielenterveyttä();
                if (Kyyhky.Mielenterveys == 4)
                {
                    Console.WriteLine("Kyyhky näyttää hieman surullisemmalta.");
                }
                if (Kyyhky.Mielenterveys == 3)
                {
                    Console.WriteLine("Kyyhkyn olemus synkkenee ja sen kasvoille ilmestyy huoliryppyjä.");
                }
                if (Kyyhky.Mielenterveys == 2)
                {
                    Console.WriteLine("Kyyhkyn ryppyisille kasvoilla valuu vuolas virta kyyneliä.");
                }
                if (Kyyhky.Mielenterveys == 1)
                {
                    Console.WriteLine("Kyyhky tuijottaa tyhjyyteen ja alkaa kaivella taskujaan");
                }
                if (Kyyhky.Mielenterveys <= 0)
                {
                    Console.WriteLine("Kyyhky kaivaa taskustaan lihamyllyn, astuu siihen ja alkaa veivata itseään jauhelihaksi. \nJähmetyt tuijottamaan, kunka kyyhky muuntuu veriseksi muusiksi hitaasti \nja tuskallisen näköisesti. Kyyhkyn päättäväisesti veivaa menemään \nitseään jauhelihaksi luiden napsuessa poikki ja veren roiskuessa ympäriinsä.");
                    kyyhkynenElossa = false;
                    kartta.Huoneet[4].HuoneenKuvaus = "Olet aukiolla olevan kumpareen luona ja edessäsi näet puun, jonka oksa \nnäyttää yksinäiseltä. Maassa on lihamylly, jonka vieressä on kasa kyyhkys-jauhelihaa. \nPohjoisessa liekehtii liekkimeri."
                + " Etelässä näet lehmälauman, jonka yksilöt tuijottavat sinua syyttävän \noloisesti lehmänsilmillään. Idässä loimuaa liekkimeri. Lännessä näet"
                + " lehmälauman märehtivän. \nNe eivät välitä omantunnontuskistasi";
                }
            }
            else if (TämäHuone == kartta.Huoneet[4] && vars[0] == "sano" && vars.Any(_ => Kyyhky.HyötySanat.Contains(_)))
            {
                Kyyhky.LisääMielenterveyttä();
                if (Kyyhky.Mielenterveys == 4)
                {
                    Console.WriteLine("Kyyhky näyttää enää vain hieman surulliselta.");
                }
                if (Kyyhky.Mielenterveys == 3)
                {
                    Console.WriteLine("Ihan kuin kyyhkyn huolirypyt alkaisivat siloittua");
                }
                if (Kyyhky.Mielenterveys == 2)
                {
                    Console.WriteLine("Kyyhky lopettaa taskujensa kaivelun ja kyynelvirta tyrehtyy.");
                }
                if (Kyyhky.Mielenterveys == 1)
                {
                    Console.WriteLine("Kyyhky tuijottaa tyhjyyteen ja alkaa kaivella taskujaan");
                }
                if (Kyyhky.Mielenterveys >= 5 && Kyyhky.Mielenterveys < 10)
                {
                    Console.WriteLine("Kyyhky vaikuttaa suhteellisen onnelliselta");
                }
                if (Kyyhky.Mielenterveys == 10)
                {
                    Console.WriteLine("Kyyhky on silminnähden iloinen! Olet parantanut kyyhkyn oloa ja ansaitset paikkasi \nHyvien Tyyppien listalla! Nyt voit olla hyvin mielin.");

                    GameOver();
                }
            }
            //helppi
            else if (vars[0] == "apua" || vars[0] == "help")
            {
                Helppi();
            }
            // jos kaikki muu ei toimi...
            else
            {
                Console.WriteLine("Yritähän toisin sanoin, tai lue vaikka \"apua\"-komennolla miten voisit käskyttää peliä.");
            }
        }

        //liikkuminen huoneista
        public void LiikuHuoneista(string ilmansuunta)
        {

            if (TämäHuone == kartta.Huoneet[0])
            {
                 GameOver();
            }
            else if (TämäHuone == kartta.Huoneet[1])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                       // Liikuttu();
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[5];
                        Liikuttu();
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet luuranko-naapurin talon.");
                        break;
                    case "l":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                       // Liikuttu();
                        break;
                }
            }
            else if (TämäHuone == kartta.Huoneet[2])
            {
                
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet ikkunasta loimuavan liekkimeren.");
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[6];
                        Liikuttu();
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet ikkunasta lehmäpellon.");
                        break;
                    case "l":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet ikkunasta matontamppauspaikan.");
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[3])
            {
                if (!koiraJulisteAnnettu)
                {
                    LehmiäTiellä();
                }
                switch (ilmansuunta)
                {
                    case "p":
                         HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                       // Liikuttu();
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[7];
                        Liikuttu();
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[4];
                        Liikuttu();
                        break;
                    case "l":
                        Console.WriteLine("Edessäsi on naapurin mökki. Et voi mennä naapurin mökin seinästä läpi.");
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[4])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                      //  Liikuttu();
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[8];
                        Liikuttu();
                        break;
                    case "i":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                      //  Liikuttu();
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[3];
                        Liikuttu();
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[5])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        if (luuOtettu)
                        {
                            Console.WriteLine("\"Tuo on minun isosetäni reisiluu senkin torvelo!\" Huutaa luuranko \nja alkaa hakata sinua kuolettavasti reisiluulla. Tunnet kuinka luu pureutuu \nlihaasi ja verta ja suolenpätkiä lentelee. ");
                            GameOver();
                        }
                        TämäHuone = kartta.Huoneet[1];
                        Liikuttu();
                        break;
                    case "e":
                        Console.WriteLine("Edessäsi on aita. Et voi mennä aidan läpi.");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[6];
                        Liikuttu();
                        break;
                    case "l":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                      //  Liikuttu();
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[6])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        if (luurankoTalossa == true && (sormusOtettu == true || kelloOtettu == true))
                        {
                            Console.WriteLine("\"Lohikäärmeen perkele on käynyt taas varkaissa! Nyt saa riittää, tämä on viimeinen kerta, \nnyt lähden lohikäärmejahtiin\" huutaa luuranko ja lähtee ovesta.");
                            luurankoTalossa = false;
                            luurankoElossa = false;
                            // kartta.Huoneet[2].HuoneenKuvaus ="Luurangon talo on tyhjyyttä täynnä";
                            if (kelloOtettu == true && sormusOtettu == true)
                            {
                                kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. \nIdässä on seinä, jonka ikkunasta näkyy aita ja"
                            + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. \nEtelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                            + " näet mattotelineen.";
                            }
                            else if (kelloOtettu == true && sormusOtettu == false)
                            {
                                kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. \nIdässä on seinä, jonka ikkunasta näkyy aita ja"
                            + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. \nEtelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                            + " näet mattotelineen.\nTalon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello";
                            }
                            else if (kelloOtettu == false && sormusOtettu == true)
                            {
                                kartta.Huoneet[2].HuoneenKuvaus = "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. \nIdässä on seinä, jonka ikkunasta näkyy aita ja"
                            + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. \nEtelässä on auki jättämäsi ulko-ovi. Idässä on seinä, jonka ikkunasta"
                            + " näet mattotelineen.\nTalon sisällä näyttää olevan arvokkaita tavaroita, kuten timanttisormus";
                            }

                            kartta.Huoneet[15].HuoneenKuvaus = "Etupihallasi on lohikäärme. Lohikäärmeen suupielestä pilkottaa luu. Se katselee mitä puuhaat. Kevyt pakokauhu paukahtelee pakaroissasi lohikäärmeen katseen alla. \n" +
                        "Toivot sisimmässäsi, että muistaisit loitsun, jolla lohikäärmeen saisi muutettua mukavammaksi elukaksi. Pohjoiseen päin katsahtaessasi havaitset \n" +
                        "tutunnäköisen mökin seinän ja kotiovesi. Länteenpäin vie polku mukavahkon näköiselle niitylle. Idässä häämöttävät synkät pilvet ja kivimuuri, jossa on portti. \n" +
                        "Etelässäpäin liehuu liekkimeri, et tunne suurta vetoa sinne.\n";

                        }
                        TämäHuone = kartta.Huoneet[2];
                        Liikuttu();
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[10];
                        Liikuttu();
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[7];
                        Liikuttu();
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[5];
                        Liikuttu();
                        break;

                }

            }

            else if (TämäHuone == kartta.Huoneet[7])
            {
                if (!koiraJulisteAnnettu)
                {
                    LehmiäTiellä();
                }
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[3];
                        Liikuttu();
                        break;
                    case "e":
                        Console.WriteLine("Olet oman mökkisi takapihalla, et voi mennä seinästä läpi.");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[8];
                        Liikuttu();
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[6];
                        Liikuttu();
                        break;

                }

            }
            else if (TämäHuone == kartta.Huoneet[8])
            {
                if (!koiraJulisteAnnettu)
                {
                    LehmiäTiellä();
                }
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[4];
                        Liikuttu();
                        break;
                    case "e":
                        Console.WriteLine("Kiviaidan läpi ei voi kävellä, pääsetköhän tästä jotenkin muuten?");
                        break;
                    case "i":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                        //Liikuttu();
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[7];
                        Liikuttu();
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
                        Console.WriteLine("Edessäsi on leipurin mökki, et voi mennä seinästä läpi.");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[10];
                        Liikuttu();
                        break;
                    case "l":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                       // Liikuttu();
                        break;

                }
            }
            else if (TämäHuone == kartta.Huoneet[10])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[6];
                        Liikuttu();
                        break;
                    case "e":
                        TämäHuone = kartta.Huoneet[14];
                        Liikuttu();
                        break;
                    case "i":
                        Console.WriteLine("Edessäsi on oman mökkisi länsiseinä, et voi mennä seinästä läpi.");
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[9];
                        Liikuttu();
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
                        Liikuttu();
                        break;
                    case "i":
                        Console.WriteLine("Edessäsi on kotimökkisi itäseinä. Ikkunasta näet omituisen pinkinsekaisen sateenkaarenvälähdyksen ja"
                            + " ikkunan raosta kantautuu vaimea 'Pruu pruu'-ääni");
                        break;
                    case "l":
                        Console.WriteLine("Edessäsi on kotimökkisi länsiseinä. Ikkunasta näet ruohikkoisen aukean, jonka keskellä kiemurtelee"
                            + " pieni polku. Polun yli loikkii sammakko.");
                        break;
                }
            }

            else if (TämäHuone == kartta.Huoneet[12])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Edessäsi on aita, pitääköhän mennä jotain toista reittiä.");
                        break;;
                    case "e":
                        Console.WriteLine("Edessäsi on aita, pitääköhän mennä jotain toista reittiä.");
                        break;
                    case "i":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                        break;
                    case "l":
                        Console.WriteLine("Näet kotimökkisi itäseinän, et voi kävellä seinän läpi.");
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[13])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Edessäsi on leipurin mökin pohjoisseinä ja ikkunan takana näet pellon, jolla tallustelee fasaani.");
                        break;
                    case "e":
                        Console.WriteLine("Edessäsi on leipurin mökin eteläseinä, jonka ikkunan takana roihuaa tulimeri");
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[14];
                        Liikuttu();
                        break;
                    case "l":
                        Console.WriteLine("Edessäsi on leipurin mökin länsiseinä, jonka ikkunasta näet kuumana roihuavan tulimeren");
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[14])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[10];
                        Liikuttu();
                        break;
                    case "e":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];
                      //  Liikuttu();
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[15];
                        Liikuttu();
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[13];
                        Liikuttu();
                        break;

                }
            }

            else if (TämäHuone == kartta.Huoneet[15])
            {
                switch (ilmansuunta)
                {
                    case "p":
                        TämäHuone = kartta.Huoneet[11];
                        Liikuttu();
                        break;
                    case "e":
                        HaluatkoKuolla();
                        TämäHuone = kartta.Huoneet[0];                        
                       // Liikuttu();
                        
                        break;
                    case "i":
                        TämäHuone = kartta.Huoneet[16];
                        Liikuttu();
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[14];
                        Liikuttu();
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
                        Console.WriteLine("Edessäsi on aita, pitääköhän mennä jotain toista reittiä.");
                        break;
                    case "i":
                        Console.WriteLine("Edessäsi on aita, pitääköhän mennä jotain toista reittiä.");
                        break;
                    case "l":
                        TämäHuone = kartta.Huoneet[15];
                        Liikuttu();
                        break;

                }
            }
        }
            

        public void LehmiäTiellä() //Anni
        {
            int nro = rnd.Next(1, 10);
            if (nro == 1 || nro == 2 || nro == 3)
            {
                Console.WriteLine("Pääset puikkelehtimaan lehmien välistä!");
            }
            else
            {
                Console.WriteLine("Lehmät tukkivat tiesi");
                Peli();
            }
        }
        public void HaluatkoKuolla() //Anni
        {

            Console.WriteLine($"Oletko aivan varma että haluat kävellä tulimereen? Saattaa olla melko lämmin... (k/e)");
            string jatka = Console.ReadLine();
            if (jatka == "k")
            {
                Console.WriteLine("Kävelit tulimereen. Liekit hyväilevät innolla ruumiisi muotoja, muuttaen karvasi tuhkaksi. Ihosi kärventyy ja mietit itseksesi, \n\"Olisin varmaan hyvänmakuinen\". Viimeisenä näkökenttäsi mustuu ja silmäsi räjähtävät kuumuudesta *poks* *ruisk*");
                GameOver();
            }
            else if ( jatka == "e")
            {
                Console.WriteLine("Viisas päätös. Kokeile lähteä johonkin toiseen suuntaan!");
                Peli();
            }
            else
            {
                Console.WriteLine($"Kokeileppa antaa joku järkevä vastaus");
            }
        }

        public void GameOver() //Anni
        {
            PelaajaElossa = false;
            string jatka;
            Console.WriteLine("Peli päättyi, haluatko pelata uudelleen? (k/e)");
            jatka = Console.ReadLine();
            if (jatka == "k")
            {
                tyhjennaReppu();
                mattopiiskaOtettu = false;
                luuOtettu = false;
                lentävämattoOtettu = false;
                luurankoTalossa = false;
                sormusOtettu = false;
                kelloOtettu = false;
                koiraJulisteOtettu = false;
                silinteriHattuOtettu = false;
                avainOtettu = false;
                LiikuttuBool = true;
                MattopiiskaAnnettu = false;
                LihaOtettu = false;
                onkoPäässäHattu = false;
                koiraJulisteAnnettu = false;
                kyyhkynenElossa = true;
                luurankoElossa = true;
                PelaajaElossa = true;
                LiikuttuBool = true;
                kartta.TeeHuoneLista();
                TämäHuone = kartta.Huoneet[11];
                AloitaPeli();
            }
            else if (jatka == "e")
            {
                Console.WriteLine($"Oli kiva pelata kanssasi, {UI.Pelaaja.Nimi}, toivottavasti sinullakin oli hauskaa!");
                return;
            }
            else
            {
                Console.WriteLine($"Itte oot {jatka}.\n");
                GameOver();
            }

        }

        public void Helppi() //Anni
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("Näin pelaat Kyyhkys-Jussi-peliä:");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Pelissä voit liikkua pääilmansuuntiin antamalla komennoksi 'P', 'E', 'L' tai 'I'.");
            Console.WriteLine($"Ollessasi talossa sisällä voit kulkea ovesta tai katsoa ikkunoista antamalla komennoksi ilmansuunnan.");
            Console.WriteLine($"Tiellesi voi sattua esteitä ja voit kokeilla kiivetä niiden yli komennolla 'kiipeä *haluamasi ilmansuunta*'.");
            Console.WriteLine($"Maailmaan on sijoitettu esineitä ja voit lisätä niitä reppuusi komennolla 'ota *haluamasi esine*'. Näet repun sisällön komennolla 'reppu'.");
            Console.WriteLine($"Voit antaa esineitä repustasi maailman hahmoille komennolla 'anna *haluamasi esine*'.");
            Console.WriteLine($"Voit lyödä näkemääsi komennolla 'lyö'. Voit puhua muille hahmoille komennolla 'sano *mitä nyt ikinä haluatkaan sanoa*'.");
            Console.WriteLine($"Voit kokeilla loitsia komennolla 'loitsi *taikasanat*'.");
            Console.WriteLine("------------------------------------");
            Console.WriteLine($"Pääset lukemaan nämä ohjeet missä tahansa vaiheessa peliä komennolla 'apua'.");
            Console.WriteLine("------------------------------------");
            Console.WriteLine();
            LiikuttuBool = true;

        }
    }
}
