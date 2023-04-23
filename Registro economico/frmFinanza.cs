using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_economico
{
    public partial class frmFinanza : Form
    {
        public frmFinanza()
        {
            InitializeComponent();
        }

        private void mrcIngreso_Enter(object sender, EventArgs e)
        {

        }

        private void frmFinanza_Load(object sender, EventArgs e)
        {

        }

        private void cmdCalcular_Click(object sender, EventArgs e)
        {
            var deposito=Convert.ToInt32(txtDeposito.Text);
            var alquiler= Convert.ToInt32(txtAlquiler.Text);
            var impuestos= Convert.ToInt32(txtImpuestos.Text);
            var comida= Convert.ToInt32(txtComida.Text);
            var calculo = deposito - alquiler - impuestos - comida;
            txtMonto.Text = calculo.ToString(); 
        }
    }
}
