using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cerveza : Botella
    {
        private const int MEDIDA = 330;
        private Tipo tipo;


        public Cerveza(int capacidadML, string marca, int contenidoML, Botella.Tipo tipo) : base(capacidadML, contenidoML, marca)
        {
            this.tipo = tipo;
        }

        public Cerveza(int capacidadML, string marca, int contenidoML) : this(capacidadML, marca, contenidoML, Botella.Tipo.Vidrio)
        {

        }


        protected override string GenerarInforme()
        {
            StringBuilder texto = new StringBuilder();

            texto.Append(base.GenerarInforme());
            texto.Append($"Tipo: {this.tipo}");

            return texto.ToString();
        }

        public static implicit operator Botella.Tipo(Cerveza p)
        {
            
            return p.tipo;
        }


        public override int ServirMedida()
        {
            int retorno = MEDIDA;

            int contenidoServido = this.contenidoML * 80 / 100;

            this.contenidoML = contenidoServido;

            if (MEDIDA <= this.contenidoML)
            {

                this.contenidoML -= MEDIDA;

            }
            else
            {

                this.Contenido -= this.contenidoML;
                retorno = 0;
            }


            return retorno;

        }








    }
}
