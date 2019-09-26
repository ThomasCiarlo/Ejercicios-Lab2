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

        public override float CostoLlamada { get { return this.CalcularCosto(); } set { this.CostoLlamada = value; } }

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

        protected override string Mostrar()
        {

          StringBuilder texto = new StringBuilder($"{base.Mostrar()}. El costo es de: {this.CostoLlamada}");

           return texto.ToString();
        }

       public override bool Equals(object obj) {

            bool x = false;

             return x = obj is Local;

       }

      public override string ToString()
    {

      return this.Mostrar();

    }


    }
}
