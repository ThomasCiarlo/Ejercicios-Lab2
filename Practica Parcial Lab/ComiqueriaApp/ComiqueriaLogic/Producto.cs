using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public abstract class Producto
    {
        private Guid codigo;
        private double precio;
        private int stock;
        private string descripcion;

        public string Descripcion { get {return this.descripcion; } }
        public double Precio { get { return this.precio; } }
        public int Stock {
            get { return this.stock; }
            set { if (value >= 0)
                {
                    this.stock = value;
                }
            } }

        protected Producto(string descripcion, double precio, int stock) {

            this.codigo = Guid.NewGuid();
            this.descripcion = descripcion;
            this.precio = precio;
            this.stock = stock;

        }

        public static explicit operator Guid(Producto p) {

            return p.codigo;

        }

        public override string ToString() {

            StringBuilder texto = new StringBuilder();
            texto.Append($"Descripcion: {this.descripcion}\n");
            texto.Append($"Codigo: {this.codigo}\n");
            texto.Append($"Precio: {this.precio}\n");
            texto.Append($"Stock: {this.stock}\n");

            return texto.ToString();

        }



    }
}
