using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace Formularios
{
    public partial class frmMenu : Form
    {
        public Centralita central;

        public frmMenu()
        {
            InitializeComponent();
            central = new Centralita("Telecentro");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar();
            mostrar.Tipo = Llamada.TipoLlamada.Provincial;

            mostrar.Show();
            mostrar.TextoAMostrar(this.central);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bntGenerarLlamada_Click(object sender, EventArgs e)
        {
            frmLlamador llamador = new frmLlamador(this.central);

            llamador.ShowDialog();

            this.central = llamador.Central;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFacturacionTotal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar();
            mostrar.Tipo = Llamada.TipoLlamada.Todas;

            mostrar.Show();
            mostrar.TextoAMostrar(this.central);


        }

        private void btnFacturacionLocal_Click(object sender, EventArgs e)
        {
            frmMostrar mostrar = new frmMostrar();
            mostrar.Tipo = Llamada.TipoLlamada.Local;

            mostrar.Show();
            mostrar.TextoAMostrar(this.central);
        }
    }
}
