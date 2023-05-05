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
    public partial class frmAlacena : Form
    {
        string varLugar;
        string varNombre;
        int varCantidad;
        DateTime varVence; 
        public frmAlacena()
        {
            InitializeComponent();
        }
        private void frmAlacena_Load(object sender, EventArgs e)
        {

        }
        private void cmdCargar_Click(object sender, EventArgs e)
        {
            varLugar=cboLugar.Text; 
            varNombre=cboNombre.Text;
            varCantidad = Convert.ToInt32(nudCantidad.Value);
            varVence=dtpVence.Value;    
            lstAlacena.Items.Add(varNombre + " " + varLugar + " " + varVence + " " + varCantidad);
            
        }

        private void lstAlacena_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstAlacena.Items.Add(varLugar + varNombre + varCantidad);
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
           
        }
    }
}
