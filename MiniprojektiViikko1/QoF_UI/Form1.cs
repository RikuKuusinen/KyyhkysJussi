using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QoF_UI
{
    public partial class Form1 : Form
    {

        private Pelikenttä kenttä;
        private const string Otsikko = "Game Of Life";
        public Form1()
        {
            InitializeComponent();
        }

        #region Tiedostohommelit
        private void bTalletaKenttä_Click(object sender, EventArgs e)
        {
            string tiedosto = "";
            FrmTiedostoNimi f = new FrmTiedostoNimi();
            if (DialogResult.OK != f.ShowDialog())
            {
                return;
            }
            tiedosto = f.TiedostoNimi;
        }

        private void bLuePelikenttä_Click(object sender, EventArgs e)
        {
            string tiedosto = "";
            FrmTiedostoNimi f = new FrmTiedostoNimi();
            if (DialogResult.OK != f.ShowDialog())
            {
                return;
            }
            tiedosto = f.TiedostoNimi;
        }
        #endregion

        private void bLuoKenttä_Click(object sender, EventArgs e)
        {
            if (kenttä != null)
            {
                kenttä.SolunValinta -= Pelikenttä_SolunValinta;

            }
            kenttä = new Pelikenttä((int)nudLeveys.Value, (int)nudKorkeus.Value);
            kenttä.TeeKenttä(pnlBoard);
            kenttä.SolunValinta += Pelikenttä_SolunValinta;
            Text = Otsikko + $" - kenttä {kenttä.Leveys} x {kenttä.Korkeus}: Sukupolvi 0";
            // tässä luo Game-olio 
            Game Peli = new Game((int)nudLeveys.Value, (int)nudKorkeus.Value);
        }

private void Pelikenttä_SolunValinta(object sender, SolunValintaEventArgs e)
{
    int x = e.X;
    int y = e.Y;
    bool elossa = e.Elossa;
            // aseta peliin solut eläviksi tai kuolleiksi
            Peli.SetSCell(x, y, Alive);
}

        private void bSeuraavaSukupolvi_Click(object sender, EventArgs e)
        {
            // tässä pyydä peliltä seuraava sukupolvi
            // ja päivitä sukupolvi ikkunan otsikkoon (Text.ominaisuus)
            // tällä saat helpommin päivitettyä uuden sukupolvan tilanteen: kenttä.PiirräKenttä
            // kenttä.AsetaSolu on toinen vaihtoehto
        }
    }
}
