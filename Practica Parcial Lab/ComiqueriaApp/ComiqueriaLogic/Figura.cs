using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Figura: Producto
    {
        protected double altura;

        public Figura(string descripcion, int stock, double precio, double altura) : base(descripcion,precio,stock)
        {
            this.altura = altura;
        }

        public Figura(int stock, double precio, double altura) : this(($"Figura: {altura}"), stock, precio, altura) { }

        public override string ToString() {
            StringBuilder texto = new StringBuilder(base.ToString());
            texto.Append($"Descripcion: {this.Descripcion}\n");
            texto.Append($"Altura: {this.altura}");

            return texto.ToString();

        }
    }
}
