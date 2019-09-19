using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;

        public float Duracion { get { return this.duracion; } }
        public string NroDestino { get { return this.nroDestino; } }
        public string NroOrigen {get { return this.nroOrigen; } }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        public string Mostar()
        {
            StringBuilder texto = new StringBuilder($"Duracion: {Duracion}, Numero de destino: {NroDestino}, Numero de origen: {NroOrigen}");

            return texto.ToString();
        }

        public enum TipoLlamada
        {
            Local,
            Provincial,
            Todas

        }
    }
}
