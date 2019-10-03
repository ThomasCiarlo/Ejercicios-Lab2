using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public sealed class Venta
    {
        private DateTime fecha;
        private static int porcentaje;
        private int cantidad;
        private double precioFinal;
        private Producto producto;

        internal DateTime Fecha { get { return this.fecha; } }

        public int Cantidad { get { return this.cantidad; } }

        static Venta() {           
            Venta.porcentaje = 21;
        }

        internal Venta(Producto producto, int cantidad) {

            this.producto = producto;
            this.cantidad = cantidad;
            Vender(cantidad);
            
        }

        public static double CalcularPrecioFinal(double precioUnidad, int cantidad) {


            return ((precioUnidad * cantidad) * Venta.porcentaje) / 100;
        }

        private void Vender(int cantidad) {

            this.producto.Stock -= cantidad;
            System.Threading.Thread.Sleep(2000);
            this.fecha = DateTime.Now;
            this.precioFinal = CalcularPrecioFinal(this.producto.Precio, cantidad);
            
        }

        public string ObtenerBreveDescripcion() {

            StringBuilder texto = new StringBuilder();

            texto.Append($"Fecha: {this.fecha} - Descripcion: {this.producto.Descripcion} - Precio Final {this.precioFinal}");

            return texto.ToString();

        }

        public static int OrdenarLista(Venta a, Venta b)
        {
            if (a.fecha > b.fecha)
                return -1;
            else if (a.fecha > b.fecha)
                return 1;
            else
                return 0;
        }

        public static explicit operator Producto(Venta v) {

            return v.producto;

        }


    }
}
