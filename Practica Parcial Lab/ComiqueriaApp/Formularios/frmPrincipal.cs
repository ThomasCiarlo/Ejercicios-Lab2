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

namespace Formularios
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            Comiqueria comiqueria = new Comiqueria();
        }

        private void BtnVender_Click(object sender, EventArgs e)
        {
            formVentas frmVentas = new formVentas();

            frmVentas.Show();
        }

        private void RichListVentas_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
