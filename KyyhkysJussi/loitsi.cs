using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KyyhkysJussi
{
    class loitsi
    {
        // pelin taiat toimivat tätä kautta -- Jukka (StringReader?)

        public string Loitsu(string loitsu)
        {
            Random rnd = new Random();
            if (loitsu == "teleport pruu pruu")
            {
                // liikuta pelaaja 
                liiku(999);
                //palauta string taian onnistumisesta
                return "Hokkusta pokkusta vaan! Olet siirtynyt taialla ihka oikeaan salapaikkaan!";
            }
            if (loitsu == "teleport")
            {
                int numero = rnd.Next(1, 42);
                if(numero == 1)
                {
                    liiku(1);
                    return "Surprizio!";
                }
                if (numero == 2)
                {
                    liiku(2);
                    return "Surprizio!";
                }
                if (numero == 3)
                {
                    liiku(3);
                    return "Surprizio!";
                }
                if (numero == 4)
                {
                    liiku(4);
                    return "Surprizio!";
                }
                if (numero == 5)
                {
                    liiku(5);
                    return "Surprizio!";
                }
                if (numero == 6)
                {
                    liiku(6);
                    return "Surprizio!";
                }
                if (numero == 7)
                {
                    liiku(7);
                    return "Surprizio!";
                }
                if (numero == 8)
                {
                    liiku(8);
                    return "Surprizio!";
                }
                if (numero == 9)
                {
                    liiku(9);
                    return "Surprizio!";
                }
                if (numero == 10)
                {
                    liiku(10);
                    return "Surprizio!";
                }
                if (numero == 11)
                {
                    liiku(11);
                    return "Surprizio!";
                }
                if (numero == 12)
                {
                    liiku(12);
                    return "Surprizio!";
                }
                if (numero == 13)
                {
                    liiku(13);
                    return "Surprizio!";
                }
                if (numero == 14)
                {
                    liiku(14);
                    return "Surprizio!";
                }
                if (numero == 15)
                {
                    liiku(15);
                    return "Surprizio!";
                }
                if (numero == 16)
                {
                    liiku(16);
                    return "Surprizio!";
                }
                if (numero == 17)
                {
                    //kääpiöin luolaan
                    liiku(999);
                    return "Il teleportatsioone molto magnifico!";
                }
                if (numero > 17)
                {
                    //tulimereen
                    liiku(666);
                    return "Il teleportatsioone molto malo!";
                }
                return "Il teleportatsioone molto magnifico!";
            }
            else
            {
                return "Mökeltelet iloksesi, mutta ei siinä mitään taianomaista ole.";
            }
        }
    }
}
