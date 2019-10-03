using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaApp;
using ComiqueriaLogic;

namespace Formularios
{
    public partial class formVentas : Form
    {
        Comiqueria comiqueria;
        Producto productoSeleccionado;
        public formVentas(Comiqueria comiqueria, Producto producto)
        {
            InitializeComponent();
            this.comiqueria = comiqueria;
            this.productoSeleccionado = producto;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = productoSeleccionado.Descripcion;
           
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            
            if (productoSeleccionado.Stock >= numericUpDown1.Value)
            {
                comiqueria.Vender(productoSeleccionado, Convert.ToInt32(numericUpDown1.Value));
                this.DialogResult = DialogResult.OK;

            }
            else
            {
                MessageBox.Show("NO HAY EL STOCK SELECCIONADO","Stock insuficiente",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {
           
        }

        private void NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            lblPrecioFinal.Text = ("Precio final: "+Venta.CalcularPrecioFinal(productoSeleccionado.Precio, (int)numericUpDown1.Value).ToString());
        }
    }
}
