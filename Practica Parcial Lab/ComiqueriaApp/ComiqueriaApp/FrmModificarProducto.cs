using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComiqueriaLogic;

namespace ComiqueriaApp
{
    public partial class FrmModificarProducto : Form
    {
        private Producto productoSeleccionado;
        private Comiqueria Comiqueria;
        public FrmModificarProducto(Comiqueria comiqueria, Producto productoSeleccionado)
        {
            InitializeComponent();
            this.Comiqueria = comiqueria;
            this.productoSeleccionado = productoSeleccionado;
            
            
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblDescripcion_Click(object sender, EventArgs e)
        {

        }

        private void FrmModificarProducto_Load(object sender, EventArgs e)
        {
            lblDescripcion.Text = this.productoSeleccionado.Descripcion;
            txtPrecioActual.Text = this.productoSeleccionado.Precio.ToString();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
