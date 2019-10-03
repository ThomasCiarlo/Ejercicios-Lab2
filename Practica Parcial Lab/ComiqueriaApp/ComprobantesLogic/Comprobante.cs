using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ComiqueriaLogic;

namespace ComprobantesLogic
{
    public abstract class Comprobante
    {
        protected DateTime fechaEmision;
        private Venta venta;

        internal Venta Venta { get { return this.venta; }  }

        public Comprobante(Venta venta) {

            this.venta = venta;

        }

        public override bool Equals (object obj) {

            return obj is Comprobante; 
        }

        public abstract string GenerarComprobante();

        




        


    }
}
