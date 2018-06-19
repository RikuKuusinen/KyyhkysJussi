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

namespace MyNoteBad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            string tiedostoNimi=Console.ReadLine();
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string tiedostoNimi = textBox1.Text;
            if (File.Exists(tiedostoNimi))
            {   

                textBox2.Text = File.ReadAllText(tiedostoNimi);
                               

                FileInfo nimi = new FileInfo(tiedostoNimi);

                Text = "MyNoteBad -" + Path.GetFileName(tiedostoNimi);
            }
            else
            {
                textBox2.Text = ("Kirjoita tiedoston nimi uudelleen! ");
            }
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(textBox1.Text,textBox2.Text);
        }
    }
}
