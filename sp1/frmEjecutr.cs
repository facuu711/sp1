using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sp1
{
    public partial class frmEjecutr : Form
    {
        public frmEjecutr()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAlacena ventanaAlacena = new frmAlacena();

            ventanaAlacena.ShowDialog();

        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            frmFinanzas ventanaGastos = new frmFinanzas();

            ventanaGastos.ShowDialog();
        }
    }
}
