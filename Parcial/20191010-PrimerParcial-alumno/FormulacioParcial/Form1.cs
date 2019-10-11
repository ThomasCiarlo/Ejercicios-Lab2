using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControlCantina;
using Clases;

namespace FormulacioParcial
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.barra1.SetCantina = Cantina.GetCantina(10);
            comboTipoBotella.DataSource = Enum.GetValues(typeof(Botella.Tipo));

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Botella.Tipo tipo;
            Enum.TryParse<Botella.Tipo>(comboTipoBotella.SelectedValue.ToString(), out tipo);
            if (radioCerveza.Checked)
            {
                int cap = Convert.ToInt16(numericContenido.Value);
                Cerveza c = new Cerveza(Convert.ToInt16(numericCapacidad.Value), txtMarca.Text, Convert.ToInt16(numericContenido.Value),tipo);
                barra1.AgregarBotella(c);
            }
            else
            {

                Agua a = new Agua(Convert.ToInt16(numericCapacidad.Value), txtMarca.Text, Convert.ToInt16(numericContenido.Value));
                barra1.AgregarBotella(a);
            }

            
        }
    }
}
