using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFDemo1

{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtData.Text += Environment.NewLine +   DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = txtData.Text;
            MessageBox.Show(s, "ilmoitus", MessageBoxButtons.YesNoCancel);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmToinenIkkuna f = new frmToinenIkkuna();
            f.Show();
        }

        private void txtData_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tes(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
