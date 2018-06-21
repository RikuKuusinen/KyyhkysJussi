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

            "Näet edessäsi luurangon, joka on naapurin mökin isäntä. Hänellä on kädessään mattopiiska ja hän piiskaa mattoja." 
                + " \n- Pohjoisessa liekehtii liekkimeri. \n- Etelässä näet mattokasan ruohikkoisella aukiolla. \n- Idässä näet naapurin mökin länsiseinän."
                + " Ikkunan takana kimaltelee kultakello ja timanttisormus. Kahvipannu näyttää olevan porisemassa liedellä. \n- Lännessä leimuaa liekkimeri.\n",

            "Olet naapurin mökin sisällä. \n- Pohjoisessa on seinä, jonka ikkunasta kuultaa liekkimeri. \n- Lännessä on seinä, jonka ikkunasta näkyy aita ja"
                + " sen takana rotulehmän laikkuinen selkä ja kaarevat sarvet. Etelässä on auki jättämäsi ulko-ovi. \n- Idässä on seinä, jonka ikkunasta"
                + " näet mattoja hakkaavan naapurin. Talon sisällä näyttää olevan arvokkaita tavaroita, kuten kultakello ja timanttisormus.\n",

            "Olet niityllä joka on täynnä lehmiä. Ne näyttävät olevan rotulehmiä. \n- Pohjoisessa näkyy loimuava liekkimeri. \n- Etelässä näet lisää"
                + " lehmiä. \n- Idässä näkyy aukio ja sen keskellä kumpare, jonka päällä kasvaa iso puu. \n- Lännessä näet aidan ja sen takana luuranko-"
                + "naapurin talon.\n",

            "Olet aukiolla olevan kumpareen luona ja edessäsi näet puun, jonka oksalla istuu Kyyhkys-Jussi. \n- Pohjoisessa liekehtii liekkimeri."
                + "\n- Etelässä näet lehmälauman, jonka yksilöt tuijottavat sinua lehmänsilmillään. \n- Idässä loimuaa liekkimeri. \n- Lännessä näet"
                + " lehmälauman märehtivän.\n",

            "Olet aukiolla, jossa lojuu kasa mattoja, joista kaksi on raidallisia ja kaksi yksivärisiä. \n- Pohjoisessa"
                + " näet omituisesti heiluvan hahmon. \n- Etelässä näet korkean lauta-aidan, jonka raoista sinua kuikuilee fasaani. \n- Idässä näet"
                + " ruohikkoisen aukean, jonka keskellä kiemurtelee pieni polku. \n- Lännessä kipinöi liekkimeri.\n",

            "Olet ruohikkoisella aukiolla, jonka läpi kiemurtelee pieni polku. \n- Pohjoisessa häämöttää savupiippu. \n- Polku jatkuu etelään. \n- Idässä" 
                + "näkyy ruohoa ja kumpareita. \n- Lännessä näet myös epämääräisiä kumpareita ruohon keskellä.\n",

            "Olet niityllä joka on täynnä lehmiä. Lehmät näyttävät olevan rotulehmiä, ehkä Ayshire-rotuisia. Lihakarjaa ehdottomasti. Lauman"
                + " johtajalehmä tuijottaa sinua, etkä tiedä onko se vihainen vai ei. \n- Pohjoisessa näet lisää lehmiä. \n- Etelässä näet oman mökkisi"
                + " pohjoisseinän, jonka ikkunasta näet palamaan jättämäsi kynttilän. Toivot, että se ei sytytä tulipaloa. \n- Idässä näet lisää"
                + " lehmiä. \n- Lännessä näet ruohikkoisen aukean, jonka keskellä kiemurtelee pieni polku.\n",

            "Olet niityllä joka on täynnä lehmiä. Nämä ovat maatiaislehmiä, valko-ruskea-läikkäisiä. Et tunnista rotua. \n- Pohjoisessa näet niityn"
                + ", kumpareen ja kumpareella seisovan ison puun. Puun oksalla näkyy liikettä. \n- Etelässä näet kiviaidan, jonka takana vilahtaa"
                + " sateenkaari. \n- Idässä loimuaa liekkimeri. \nLännessä näet lehmänhäntien huisketta.\n",

            "Olet niityllä ja näet ison fasaanin, joka tuijottaa sinua isoilla silmillään. \n- Pohjoisessa näet korkean lauta-aidan. \n- Etelässä"
                + " näet leipurin talon, jonka ikkunassa leipuri naputtaa kauhalla kämmeneensä. \n- Idässä näet ruohikkoisen aukean, jonka keskellä"
                + " kiemurtelee polku. \n- Lännessä loimuaa liekkimeri.\n",

            "Olet ruohikkoisella niityllä, jonka keskellä kiemurtelee pieni polku. \n- Polku jatkuu pohjoiseen ja etelään. \n- Idässä näet talosi. " +
                "\n- Lännessä on komia niitty. Niityllä näyttäisi olevan jonkinlaista liikettä, mutta et oikein erota mikä siellä oikein mäyryää.\n",

            "Olet omassa mökissäsi. Huoneessa on pöytä, jonka päällä on silinterihattu. \n- Pohjoisella, läntisellä ja itäisellä seinällä on ikkunoita. " +
                "\n- Etelään päin on ovi, jossa on komea koirajuliste.\n",

            "Kiviaitojen välissä sijaitsee sopivankokoinen laitumen, jolla tepastelee kaunis pinkin- ja sateenkaarenkirjava yksisarvinen. " +
                "Pohjoiseen päin näet kiviaidan. Lännessä on mökkisi seinä. Idässä oikein kaunis ranta, josta pääsee helposti pulahtamaan liekkimereen halutessaan. " +
                "Etelään päin näet kulahtaneen kiviaiden ja taivaalla synkkiä pilviä parkkeerattuna taivahalle.\n",

            "Sieraimiisi sulloutuvat suunnattomat sulotuoksut. Mökissä leipuriörkki Okssu vääntää torttua virne naamallaan. Okssu toteaa tomerasti," +
                " \"Terve!\" Pullaa paistuu uunissa. \n- Pohjoisseinän ikkunasta avautuu komia niitty, jossa näkyy jonkunlaista liikettä. " +
                "\n- Itä- ja eteläikkunoista näkyy liekkimeren roihu.\n",

            "Polun risteyksessä on kookkaita kiviä ja pari mäntyä. \n- Polku haarautuu, lännessäpäin on leipurin mökki. Sen piipusta puksuu vienoa sauhua tasaisena virtauksena. " +
                "\n- Itäänpäin polulla näyttäisi kököttelevän lohikäärme haistelemassa tuulia. \n- Pohjoiseen päin polku jatkuu niitylle ja siitä eteenpäin näkymättömiin. \n- Etelän suunnalla liekkimeri.",

            "Etupihallasi on lohikäärme. Se katselee mitä puuhaat. Kevyt pakokauhu paukahtelee pakaroissasi lohikäärmeen katseen alla. " +
                "Toivot sisimmässäsi, että muistaisit loitsun, jolla lohikäärmeen saisi muutettua mukavammaksi elukaksi. \n- Pohjoiseen päin katsahtaessasi havaitset " +
                "tutunnäköisen mökin seinän ja kotiovesi. \n- Länteenpäin vie polku mukavahkon näköiselle niitylle. \n- Idässä häämöttävät synkät pilvet ja kivimuuri, jossa on portti. " +
                "\n- Etelässäpäin liehuu liekkimeri, et tunne suurta vetoa sinne.\n",

            "Taivaalla juuri tällä kohdalla on varsin synkkiä pilviä. Karut koivut muodostavat käytävän, jonka reunoilla on hautakiviä. " +
                "Edessäsi maassa töröttää puolittain esillä oleva reisiluu. \n- Pohjoisessa näet kiviaidan, jonka taa ei nää kovin hyvin. " +
                "\n- Lännessä on hautausmaan portti, jonka takaa erotat lohikäärmeisiä muotoja. \n- Idässä näet kiviaidan, jonka takana loimottelee lämmin liekkimeri. " +
                "\n- Etelässäkin näet kiviaidan, jonka takana loimottelee lämmin liekkimeri.\n",

            "Saavut kääpiöin salatulle saarelle. Selkäpiissäsi tunnet sellaista kutinaa, että kohta lähtee sokka irti. " +
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
