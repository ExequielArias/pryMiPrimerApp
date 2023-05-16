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
        //Declaracion de Variables
        decimal deposito;
        decimal alquiler;
        decimal impuestos;
        decimal comida;
        decimal calculo; 
       
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
            var deposito=Convert.ToDecimal(txtDeposito.Text);
            var alquiler= Convert.ToDecimal(txtAlquiler.Text);
            var impuestos= Convert.ToDecimal(txtImpuestos.Text);
            var comida= Convert.ToDecimal(txtComida.Text); 
            var calculo = deposito - alquiler - impuestos - comida;
            lbl_____.Text = calculo.ToString(); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
