using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic
{
    public class Comic: Producto
    {
        protected string autor;
        protected TipoComic tipoComic;

        public Comic(string descripcion, int stock, double precio, string autor, TipoComic tipo): base(descripcion,precio,stock)
        {
            this.tipoComic = tipo;
            this.autor = autor;
        }

        public enum TipoComic {
             Oriental, Ocidental
        }

        public override string ToString() {

            StringBuilder texto = new StringBuilder(base.ToString());
            texto.Append($"Autor: {this.autor}\nTipo: {this.tipoComic}");

            return texto.ToString();

        }
    }
}
