using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Clases
{
    public abstract class Botella
    {

        protected int capacidadML;
        protected int contenidoML;
        protected string marca;
       


        public int CapacidadLitros { get { return (this.capacidadML / 1000); } }
        public int Contenido { get { return this.contenidoML; } set { this.contenidoML = value; } }
        public float PorcentajeContenido { get { return this.contenidoML ; } }


        protected Botella(int capacidadML, int contenidoML, string marca)
        {

            if(capacidadML <= contenidoML){
                this.capacidadML = contenidoML;
            }
            else
            {
                this.capacidadML = capacidadML;
            }

            this.contenidoML = contenidoML;
            this.marca = marca;
        }

        protected virtual string GenerarInforme() {

            StringBuilder texto = new StringBuilder();

            texto.Append($"La capacidad es: {this.CapacidadLitros} Lts \n");
            texto.Append($"el contenido es: {this.Contenido} ML\n ");
            texto.Append($"La Marca es: {this.marca}\n ");

            return texto.ToString();

        }


        public abstract int ServirMedida();

        public override string ToString() {

            return this.GenerarInforme();

        }

        public enum Tipo
        {
            Plastico,
            Vidrio
        }



    }
}
