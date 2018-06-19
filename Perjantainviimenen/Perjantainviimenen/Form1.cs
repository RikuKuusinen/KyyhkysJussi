using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Perjantainviimenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            List<Asiakas> asiakkaat = new List<Asiakas>();

            Asiakas A1 = new Asiakas { Asiakasnumero = 1, nimi1 = "Elli Salo", TilaustenArvo = 2347 };
            asiakkaat.Add(A1);
            asiakkaat.Add(new Asiakas() { Asiakasnumero = 2, nimi1 = "Salla Lappala", TilaustenArvo = 26663457 });
            asiakkaat.Add(new Asiakas (){ Asiakasnumero = 3, nimi1 = "Tuomo Ollila", TilaustenArvo = 133947777 });
            asiakkaat.Add(new Asiakas (){ Asiakasnumero = 4, nimi1 = "Olli Reppana", TilaustenArvo = 1049840 });

            double summa=0;

            foreach(var a in asiakkaat)
            {
                summa += a.TilaustenArvo;
            }
            textBox1.Text = Convert.ToString(summa);

            StreamWriter w = new StreamWriter("C:\\work\\asiakasrekisteri.xml");

            w.WriteLine(" <Asiakas\n>");
            w.WriteLine("   <Asiakasnumero>" + Asiakasnumero + "</Asiakasnumero>\n");
            w.WriteLine("   <Nimi>" + nimi1 + "</Nimi> \n" )
            "   <TilaustenArvo>" + TilaustenArvo + "</TilaustenArvo>\n" + "</Asiakas>";)

            for (int i = 0; i < asiakkaat.Count; i++)
            {
                asiakkaat[i]=
                textBox2.Text=
            }

            foreach (var i in asiakkaat)
            {
                textBox2.Text = i.ToString();
            }
        }    
        

    }
    
}
