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
    public partial class frmFinanzas : Form
    { //zona declaracion variable al formulario
        decimal varFinzanzas, varAlquiler, varImpuesto, varComida ,varSalidas ,varGastosVariosAhorros, varSaldoRestante;



     
        public frmFinanzas()
        {
            InitializeComponent();
        }

        private void TxtFinanzas_Click(object sender, EventArgs e)
        {

        }

        private void txtSalidas_Click(object sender, EventArgs e)
        {

        }

        private void lblSaldoRestante_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
         

        

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            varFinzanzas = Convert.ToDecimal(txtFinanzas.Text);
            varAlquiler = Convert.ToDecimal(txtAlquiler.Text);
            varImpuesto = Convert.ToDecimal(txtImpuestos.Text);
            varComida = Convert.ToDecimal(txtComida.Text);
            varSalidas = Convert.ToDecimal(txtSalidas.Text);
            
            varGastosVariosAhorros 
            varSaldoRestante = varFinzanzas - varAlquiler - varImpuesto - varComida - varSalidas;

            lblSaldoRestante2.Text = varSaldoRestante.ToString();



        }

        private void frmFinanzas_Load(object sender, EventArgs e)
        {
            lblSaldoRestante2.Text = "$__________";
        }
    }
}
