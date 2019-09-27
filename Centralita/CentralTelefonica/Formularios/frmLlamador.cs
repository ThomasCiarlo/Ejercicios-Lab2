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
    public partial class frmLlamador : Form
    {

        private Centralita central;

        public frmLlamador(Centralita central)
        {
            InitializeComponent();

            this.central = central;

        }

        public Centralita Central { get { return this.central; } }

        public void CargarBtn(string btn)
        {
            txtNroDestino.Text += btn;

            string destino = txtNroDestino.Text;

            if (!(DetectarTipo(destino)))
            {
                cmbFranja.Enabled = false;
            }
            else
            {
                cmbFranja.Enabled = true;
            }
        }

        public bool DetectarTipo(string txt)
        {
            bool todoOk = false;

            if (txt.Substring(0, 1) == "#")
            {
                todoOk = true;
            }

            return todoOk;
        }




        private void Llamador_Load(object sender, EventArgs e)
        {

        }

        #region TecladoNumerico
        private void btn1_Click(object sender, EventArgs e)
        {

            StringBuilder btn1 = new StringBuilder("1");

            CargarBtn(btn1.ToString());

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("2");

            CargarBtn(btn1.ToString());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("3");

            CargarBtn(btn1.ToString());
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("4");

            CargarBtn(btn1.ToString());
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("5");

            CargarBtn(btn1.ToString());
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("6");

            CargarBtn(btn1.ToString());
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("7");

            CargarBtn(btn1.ToString());
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("8");

            CargarBtn(btn1.ToString());
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("9");

            CargarBtn(btn1.ToString());
        }

        private void btnNumeral_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("#");

            CargarBtn(btn1.ToString());

        }

        private void btn0_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("0");

            CargarBtn(btn1.ToString());
        }

        private void btnAsterisco_Click(object sender, EventArgs e)
        {
            StringBuilder btn1 = new StringBuilder("*");

            CargarBtn(btn1.ToString());
        }

        #endregion

        public void Limpiar()
        {
            txtNroDestino.Text = "";
            txtNroOrigen.Text = "";
            cmbFranja.Text = "Franja";
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
  
        private void btnLlamar_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int duracion = rnd.Next(1, 50);
            float costo = rnd.Next(5, 56) / 10;

            if (DetectarTipo(txtNroDestino.Text))
            {
                Provincial l1;

                switch (cmbFranja.Text)
                {
                    case "Franja 1":
                        l1 = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_1, duracion, txtNroDestino.Text);
                        this.central += l1;
                        MessageBox.Show("Se cargo la llamada correctamente");
                        break;
                    case "Franja 2":
                        l1 = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_2, duracion, txtNroDestino.Text);
                        this.central += l1;
                        MessageBox.Show("Se cargo la llamada correctamente");
                        break;
                    case "Franja 3":
                        l1 = new Provincial(txtNroOrigen.Text, Provincial.Franja.Franja_3, duracion, txtNroDestino.Text);
                        this.central += l1;
                        MessageBox.Show("Se cargo la llamada correctamente");
                        break;
                    default:
                        MessageBox.Show("Falta cargar la franja");
                        break;
                }
            }
            else
            {
                Local l2;
                l2 = new Local(txtNroOrigen.Text, duracion, txtNroDestino.Text, costo);
                this.central += l2;
                MessageBox.Show("Se cargo la llamada correctamente");
            }

            Limpiar();
        }
    }
}
