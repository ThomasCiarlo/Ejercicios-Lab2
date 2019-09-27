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
    public partial class frmMostrar : Form
    {
        private Llamada.TipoLlamada tipo;

        public Llamada.TipoLlamada Tipo { set { this.tipo = value; } }

        public frmMostrar()
        {
            InitializeComponent();
            this.tipo = Llamada.TipoLlamada.Todas;

        }

        public void TextoAMostrar(Centralita central)
        {

           

            foreach (Llamada c in central.Llamadas)
            {
                switch (this.tipo)
                {
                    case Llamada.TipoLlamada.Todas:
                        richText.Text = central.Mostrar();
                        break;
                    case Llamada.TipoLlamada.Provincial:
                        if(c is Provincial)
                        {
                          richText.Text +=  c.ToString();
                        }
                        break;
                    case Llamada.TipoLlamada.Local:
                        if (c is Local)
                        {
                           richText.Text += c.ToString();
                        }
                        break;
                    default:
                        richText.Text = central.Mostrar();
                        break;

                }
            }

            

        }

        private void frmMostrar_Load(object sender, EventArgs e)
        {

        }

        
    }
}
