using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    class mene
    {
        public void liiku(Huone huone)
        {
            TämäHuone = huone;
            //miten järkevästi accessoida huoneen tekstit 

            //input haetaan varmaan tässä?
        }
        // tähän tehdään jokaiselle huoneelle oma metodi, jolla määritetään mitä eri ilmansuunnissa tapahtuu
        public void LiikuHuoneista(string ilmansuunta)
        {
            if(TämäHuone = huone1)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone666);
                        break;
                    case "e":
                        liiku(huone5);
                        break;
                    case "i":
                        Console.WriteLine("Naapurin mökki on vieressä, seinästä läpi ei kuitenkaan pääse.");
                        break;
                    case "l":
                        liiku(huone666);
                        break;

                }
            }
            else if(TämäHuone = huone2)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Ikkunan takana roihuaa tuli.");
                        break;
                    case "e":
                        liiku(huone6);
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennäkään seinästä läpi. Näet ikkunasta lehmäpellon.");
                        break;
                    case "l":
                        Console.WriteLine("Et voi mennä seinästä läpi, näet vihaisen naapuriluurangon ikkunasta.");
                        break;

                }
                 
            }
            else if (TämäHuone = huone3)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone666);
                        break;
                    case "e":
                        liiku(huone7);
                        break;
                    case "i":
                        Console.WriteLine("Edessäsi on naapurin mökki. Et voi mennä naapurin mökkin seinästä läpi.");
                        break;
                    case "l":
                        liiku(huone4);
                        break;

                }

            }
            else if (TämäHuone = huone4)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone666);
                        break;
                    case "e":
                        liiku(huone8);
                        break;
                    case "i":
                        liiku(huone3);
                        break;
                    case "l":
                        liiku(huone666);
                        break;

                }

            }
            else if (TämäHuone = huone4)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone666);
                        break;
                    case "e":
                        liiku(huone8);
                        break;
                    case "i":
                        liiku(huone3);
                        break;
                    case "l":
                        liiku(huone666);
                        break;

                }

            }
            else if (TämäHuone = huone4)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone666);
                        break;
                    case "e":
                        liiku(huone8);
                        break;
                    case "i":
                        liiku(huone3);
                        break;
                    case "l":
                        liiku(huone666);
                        break;

                }

            }
            else if (TämäHuone = huone6)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone2);
                        break;
                    case "e":
                        liiku(huone10);
                        break;
                    case "i":
                        liiku(huone7);
                        break;
                    case "l":
                        liiku(huone5);
                        break;

                }

            }
            else if (TämäHuone = huone7)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone3);
                        break;
                    case "e":
                        Console.WriteLine("Olet aloitusmökin takapihalla, et voi mennä seinästä läpi.");
                        break;
                    case "i":
                        liiku(huone8);
                        break;
                    case "l":
                        liiku(huone6);
                        break;

                }

            }
            else if (TämäHuone = huone8)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone4);
                        break;
                    case "e":
                        liiku(huone12);
                        break;
                    case "i":
                        liiku(huone666);
                        break;
                    case "l":
                        liiku(huone7);
                        break;

                }
            }
            else if (TämäHuone = huone9)
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
                        liiku(huone10);
                        break;
                    case "l":
                        liiku(huone666);
                        break;

                }
            }
            else if (TämäHuone = huone10)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone6);
                        break;
                    case "e":
                        liiku(huone14);
                        break;
                    case "i":
                        Console.WriteLine("Et voi mennä seinästä läpi, edessäsi on aloitusmökki.");
                        break;
                    case "l":
                        liiku(huone9);
                        break;
                }

            }
            
            else if (TämäHuone = huone11)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        Console.WriteLine("Edessäsi on kotimökkisi pohjoisseinä. Seinässä on ikkuna, josta näet pellon täynnä rotulehmiä.");
                        break;
                    case "e":
                        liiku(huone15);
                        break;
                    case "i":
                        Console.WriteLine("Edessäsi on kotimökkisi itäseinä. Ikkunasta näet omituisen pinkinsekaisen sateenkaarenvälähdyksen ja" 
                            +  "ikkunan raosta kantautuu vaimea 'Pruut pruut'-ääni");
                        break;
                    case "l":
                        Console.WriteLine("Edessäsi on kotimökkisi länsiseinä. Ikkunasta näet ruohikkoisen aukean, jonka keskellä kiemurtelee"
                            + "pieni polku. Polun yli loikkii sammakko.");
                        break;
                }
            }

            else if (TämäHuone = huone12)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone8);
                        break;
                    case "e":
                        liiku(huone16);
                        break;
                    case "i":
                        liiku(huone666);
                        break;
                    case "l":
                        Console.WriteLine("Näet kotimökkisi itäseinän.");
                        break;
                    case "pruu pruu":
                        liiku(huone999);
                        break;

                }
            }

            else if (TämäHuone = huone13)
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
                        liiku(huone14);
                        break;
                    case "l":
                        Console.WriteLine("Näet ikkunan ja ikkunan takana roihuaa tulimeri");
                        break;

                }
            }

            else if (TämäHuone = huone14)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone10);
                        break;
                    case "e":
                        liiku(huone666);
                        break;
                    case "i":
                        liiku(huone15);
                        break;
                    case "l":
                        liiku(huone13);
                        break;

                }
            }

            else if (TämäHuone = huone15)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone11);
                        break;
                    case "e":
                        liiku(huone666);
                        break;
                    case "i":
                        liiku(huone16);
                        break;
                    case "l":
                        liiku(huone14);
                        break;

                }
            }

            else if (TämäHuone = huone16)
            {
                switch (ilmansuunta)
                {
                    case "p":
                        liiku(huone12);
                        break;
                    case "e":
                        liiku(huone666);
                        break;
                    case "i":
                        liiku(huone666);
                        break;
                    case "l":
                        liiku(huone15);
                        break;

                }
            }
        }
    } 
}
