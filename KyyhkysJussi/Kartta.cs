using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    public class Kartta //Anni, Henni
    {
        // Tehdään lista huoneista

        internal List<Huone> Huoneet = new List<Huone>();
        string[] HuoneenKuvaus =
            {
            "Astuit liekkimereen. Olet tulessa ja kuolet.\n",

            "Näet edessäsi luurangon, joka on naapurin mökin isäntä. Hänellä on kädessään mattopiiska ja hän piiskaa mattoja.\n" 
                + " Pohjoisessa liekehtii liekkimeri. Etelässä näet mattokasan ruohikkoisella aukiolla. Idässä näet naapurin mökin länsiseinän.\n"
                + " Ikkunan takana kimaltelee kultakello ja timanttisormus. Kahvipannu näyttää olevan porisemassa liedellä. Lännessä leimuaa liekkimeri.\n",

            "Olet naapurin mökin sisällä. Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. Idässä on seinä, \njonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. \nIdässä on seinä, jonka ikkunasta"
                + " näet mattoja hakkaavan naapurin. \nTalon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello ja timanttisormus.\n",

            "Olet niityllä joka on täynnä lehmiä. Ne näyttävät olevan rotulehmiä. Pohjoisessa näkyy loimuava liekkimeri. \nEtelässä näet lisää"
                + " lehmiä. Idässä näkyy aukio ja sen keskellä kumpare, jonka päällä kasvaa iso puu. \nLännessä näet aidan ja sen takana luuranko-"
                + "naapurin talon.\n",

            "Olet aukiolla olevan kumpareen luona ja edessäsi näet puun, jonka oksalla istuu Kyyhkys-Jussi. \nPohjoisessa liekehtii liekkimeri."
                + "Etelässä näet lehmälauman, jonka yksilöt tuijottavat sinua lehmänsilmillään. \nIdässä loimuaa liekkimeri. Lännessä näet"
                + " lehmälauman märehtivän.\n",

            "Olet aukiolla, jossa lojuu kasa mattoja, joista kaksi on raidallisia ja kaksi yksivärisiä. \nPohjoisessa"
                + " näet omituisesti heiluvan hahmon. Etelässä näet korkean lauta-aidan, jonka raoista sinua kuikuilee fasaani.\nIdässä näet"
                + " ruohikkoisen aukean, jonka keskellä kiemurtelee pieni polku. Lännessä kipinöi liekkimeri.\n",

            "Olet ruohikkoisella aukiolla, jonka läpi kiemurtelee pieni polku. Pohjoisessa häämöttää savupiippu. Polku jatkuu etelään. \nIdässä" 
                + "näkyy ruohoa ja kumpareita. Lännessä näet myös epämääräisiä kumpareita ruohon keskellä.\n",

            "Olet niityllä joka on täynnä lehmiä. Lehmät näyttävät olevan rotulehmiä, ehkä Ayshire-rotuisia. Lihakarjaa ehdottomasti. \nLauman"
                + " johtajalehmä tuijottaa sinua, etkä tiedä onko se vihainen vai ei. Pohjoisessa näet lisää lehmiä. \nEtelässä näet oman mökkisi"
                + " pohjoisseinän, jonka ikkunasta näet palamaan jättämäsi kynttilän. Toivot, että se ei sytytä tulipaloa. \nIdässä näet lisää"
                + " lehmiä. Lännessä näet ruohikkoisen aukean, jonka keskellä kiemurtelee pieni polku.\n",

            "Olet niityllä joka on täynnä lehmiä. Nämä ovat maatiaislehmiä, valko-ruskea-läikkäisiä. Et tunnista rotua. \nPohjoisessa näet niityn"
                + ", kumpareen ja kumpareella seisovan ison puun. Puun oksalla näkyy liikettä. \nEtelässä näet kiviaidan, jonka takana vilahtaa"
                + " sateenkaari. Idässä loimuaa liekkimeri. \nLännessä näet lehmänhäntien huisketta.\n",

            "Olet niityllä ja näet ison fasaanin, joka tuijottaa sinua isoilla silmillään. Pohjoisessa näet korkean lauta-aidan. \nEtelässä"
                + " näet leipurin talon, jonka ikkunassa leipuri naputtaa kauhalla kämmeneensä. \nIdässä näet ruohikkoisen aukean, jonka keskellä"
                + " kiemurtelee polku. \bLännessä loimuaa liekkimeri.\n",

            "Olet ruohikkoisella niityllä, jonka keskellä kiemurtelee pieni polku. Polku jatkuu pohjoiseen ja etelään. Idässä näet talosi. \n" +
                "Lännessä on komia niitty. Niityllä näyttäisi olevan jonkinlaista liikettä, mutta et oikein erota mikä siellä oikein mäyryää.\n",

            "Olet omassa mökissäsi. Huoneessa on pöytä, jonka päällä on silinterihattu. Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. \n" +
                "Etelään päin on ovi, jossa on komea koirajuliste.\n",

            "Kiviaitojen välissä sijaitsee sopivankokoinen laitumen, jolla tepastelee kaunis pinkin- ja sateenkaarenkirjava yksisarvinen. \n" +
                "Pohjoiseen päin näet kiviaidan. Lännessä on mökkisi seinä. Idässä oikein kaunis ranta, josta pääsee helposti pulahtamaan liekkimereen halutessaan. \n" +
                "Etelään päin näet kulahtaneen kiviaiden ja taivaalla synkkiä pilviä parkkeerattuna taivahalle.\n",

            "Sieraimiisi sulloutuvat suunnattomat sulotuoksut. Mökissä leipuriörkki Okssu vääntää torttua virne naamallaan. Okssu toteaa tomerasti,\n" +
                " \"Terve!\" Pullaa paistuu uunissa. Pohjoisseinän ikkunasta avautuu komia niitty, jossa näkyy jonkunlaista liikettä. \n" +
                "Itä- ja eteläikkunoista näkyy liekkimeren roihu.\n",

            "Polun risteyksessä on kookkaita kiviä ja pari mäntyä. Polku haarautuu, lännessäpäin on leipurin mökki. Sen piipusta puksuu vienoa sauhua tasaisena virtauksena. \n" +
                "Itäänpäin polulla näyttäisi kököttelevän lohikäärme haistelemassa tuulia. Pohjoiseen päin polku jatkuu niitylle ja siitä eteenpäin näkymättömiin. Etelän suunnalla liekkimeri.\n",

            "Etupihallasi on lohikäärme. Se katselee mitä puuhaat. Kevyt pakokauhu paukahtelee pakaroissasi lohikäärmeen katseen alla. \n" +
                "Toivot sisimmässäsi, että muistaisit loitsun, jolla lohikäärmeen saisi muutettua mukavammaksi elukaksi. Pohjoiseen päin katsahtaessasi havaitset \n" +
                "tutunnäköisen mökin seinän ja kotiovesi. Länteenpäin vie polku mukavahkon näköiselle niitylle. Idässä häämöttävät synkät pilvet ja kivimuuri, jossa on portti. \n" +
                "Etelässäpäin liehuu liekkimeri, et tunne suurta vetoa sinne.\n",

            "Taivaalla juuri tällä kohdalla on varsin synkkiä pilviä. Karut koivut muodostavat käytävän, jonka reunoilla on hautakiviä. \n" +
                "Edessäsi maassa töröttää puolittain esillä oleva reisiluu. Pohjoisessa näet kiviaidan, jonka taa ei nää kovin hyvin. \n" +
                "Lännessä on hautausmaan portti, jonka takaa erotat lohikäärmeisiä muotoja. Idässä näet kiviaidan, jonka takana loimottelee lämmin liekkimeri. \n" +
                "Etelässäkin näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.\n",

            "Saavut kääpiöin salatulle saarelle. Selkäpiissäsi tunnet sellaista kutinaa, että kohta lähtee sokka irti. \n" +
                "Olet päässyt kääpiöiden Shangri-La:han - Kuppakivelle! Nyt voit rauhassa mainaroida sielusi kyllyydestä seurassa, joka ei tuomitse tauhkaamistasi.\n"};
        
        public Kartta()
        {
            return;
        }
        public void TeeHuoneLista()
        {
            foreach (var k in HuoneenKuvaus)
            {
                Huone huone = new Huone(k);
                Huoneet.Add(huone);
            }
        }
    }
}
