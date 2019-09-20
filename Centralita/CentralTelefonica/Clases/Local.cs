using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Local : Llamada
    {
        protected float costo;
        public float CostoLlamada { get { return this.CalcularCosto(); } }

       private float CalcularCosto()
        {
            float precio = Duracion * costo;

            return precio;
        }

        public Local(Llamada llamada, float costo) : base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.costo = costo;
        }

        public Local(string origen, float duracion, string destino, float costo): base(duracion,destino,origen)
        {
            this.costo = costo; 
                       
        }

        public string Mostrar()
        {

          StringBuilder texto = new StringBuilder($"{base.Mostar()}. El costo es de: {this.CostoLlamada}");

           return texto.ToString();
        }

        
    }
}
