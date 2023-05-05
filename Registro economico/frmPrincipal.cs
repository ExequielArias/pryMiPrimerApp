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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAlacena VentanaAlacena = new frmAlacena(); 
            VentanaAlacena.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmFinanza VentanaFinanza = new frmFinanza();   
            VentanaFinanza.ShowDialog();    
        }

        private void lblMostrarInformacionDe_Click(object sender, EventArgs e)
        {

        }
    }
}
