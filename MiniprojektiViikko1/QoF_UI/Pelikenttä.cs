using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QoF_UI
{
    class SolunValintaEventArgs:EventArgs
    {
        public int X { get; set; }
        public int Y { get; set; }
        public bool Elossa { get; set; }
    }

    class Pelikenttä
    {
        public event EventHandler<SolunValintaEventArgs> SolunValinta;

        private Label[,] labels;
        private const int MaxKoko = 600;
        public int Leveys { get; private set; }
        public int Korkeus { get; private set; }
        public Pelikenttä(int leveys, int korkeus)
        {
            Leveys = leveys;
            Korkeus = korkeus;
            labels = new Label[leveys, korkeus];
        }

        public void TeeKenttä(Panel pelialue)
        {
            pelialue.Controls.Clear();
            int w = MaxKoko / Leveys;
            int h = MaxKoko / Korkeus;
            int wh = Math.Min(w, h);
            for (int x = 0; x < Leveys; x++)
            {
                for (int y = 0; y < Korkeus; y++)
                {
                    Label l = new Label();
                    l.Location = new Point(x * wh, y * wh);
                    l.Size = new Size(wh, wh);
                    l.Name = $"{x},{y}";
                    labels[x, y] = l;
                    l.BackColor = Color.White;
                    l.Click += L_Click;
                    l.Tag = false;
                    pelialue.Controls.Add(l);
                }
            }
            pelialue.Size = new Size(Leveys * wh, Korkeus * wh);
        }

        private void L_Click(object sender, EventArgs e)
        {
            int x = 0, y = 0;
            Label l = sender as Label;
            l.Tag = !(bool)l.Tag;
            l.BackColor = (bool)l.Tag ? Color.Black : Color.White;
            string[] parts = l.Name.Split(',');
            int.TryParse(parts[0], out x);
            int.TryParse(parts[1], out y);
            SolunValinta?.Invoke(this, new SolunValintaEventArgs() { X = x, Y = y, Elossa = (bool)l.Tag });
        }

        public void AsetaSolu(int x, int y, bool elossa) {
            if (x < 0 || y < 0 || x >= Leveys || y >= Korkeus)
            {
                throw new ArgumentException("väärä solu, ei osu pelialueelle");
            }
            labels[x, y].Tag = elossa;
            labels[x, y].BackColor = elossa?Color.Black:Color.White;
        }

        public void PiirräKenttä(bool [,] solut )
        {
            if (labels == null)
            {
                return;
            }
            if (solut.GetUpperBound(0) != Leveys - 1 || solut.GetUpperBound(1) != Korkeus-1)
            {
                throw new ArgumentException("Väärän kokoinen pelialue");
            }
            for (int x = 0; x <= solut.GetUpperBound(0); x++)
            {
                for (int y = 0; y <= solut.GetUpperBound(1); y++)
                {
                    labels[x, y].Tag = solut[x, y];
                    labels[x, y].BackColor = solut[x, y] ? Color.Black : Color.White;
                }
            }
        }
    }
}
