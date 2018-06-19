using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perjantainviimenen
{
    class Asiakas
    {
        string nimi;
        int asiakasnumero;
        int tilaustenArvo;

        public string nimi1 { get => nimi; set => nimi = value; }
        public int Asiakasnumero { get => asiakasnumero; set => asiakasnumero = value; }
        public double TilaustenArvo { get => tilaustenArvo1; set => tilaustenArvo1 = value; }

        private double tilaustenArvo1;

        public override string ToString()
        {
            return " <Asiakas\n>"+
            "   <Asiakasnumero>" + Asiakasnumero +"</Asiakasnumero>\n"+
            "   <Nimi>"+nimi1+"</Nimi> \n"+
            "   <TilaustenArvo>"+TilaustenArvo+"</TilaustenArvo>\n"+"</Asiakas>";

        }

    }
}
