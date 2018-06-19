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
    public partial class FrmTiedostoNimi : Form
    {
        public string TiedostoNimi {
            get { return txtNimi.Text.Trim(); }
            set { txtNimi.Text = value.Trim(); }
        }

        public FrmTiedostoNimi()
        {
            InitializeComponent();
        }
    }
}
