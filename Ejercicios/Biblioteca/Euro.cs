using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Euro
    {
        private double cantidad;
        private static double cotizRespectoDolar;

        private Euro()
        {
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }

        public Euro(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {

            Euro.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {

            double cantidad = this.cantidad;

            return cantidad;

        }

        public static double GetCotizacion()
        {

            double cotizacion = Euro.cotizRespectoDolar;
            return cotizacion;

        }

        public static explicit operator Dolar(Euro e)
        {

            Dolar dolar;
            double valor;

            valor = e.cantidad * 1.16;

            dolar = new Dolar(valor);

            return dolar;
        }

        public static explicit operator Peso(Euro e)
        {

            Peso p;
            double valor;

            valor = (e.cantidad * 1.16) * 38.33;

            p = new Peso(valor);

            return p;
        }

        public static implicit operator Euro(double c)
        {

            Euro d = new Euro();

            d.cantidad = c;

            return d;

        }

        public static bool operator !=(Euro e, Dolar d)
        {


            bool todoOk = false;
            double cantidadE = d.getCantidad();

            if (e.cantidad != cantidadE)
            {

                todoOk = true;
            }

            return todoOk;

        }

        public static bool operator ==(Euro e, Dolar d)
        {

            bool todoOk = true;

            if (e != d) todoOk = false;

            return todoOk;
        }

        public static bool operator !=(Euro e, Peso p)
        {


            bool todoOk = false;
            double cantidadE = p.GetCantidad();

            if (e.cantidad != cantidadE)
            {

                todoOk = true;
            }

            return todoOk;

        }

        public static bool operator ==(Euro e, Peso p)
        {

            bool todoOk = true;

            if (e != p) todoOk = false;

            return todoOk;
        }

        public static bool operator ==(Euro e, Euro p)
        {

            bool todoOk = false;

            if (e.cantidad == p.cantidad)
            {

                todoOk = true;

            }

            return todoOk;
        }

        public static bool operator !=(Euro e, Euro p)
        {

            bool todoOk = true;

            if (e == p) todoOk = false;

            return todoOk;

        }

        public static Euro operator -(Euro e, Peso p)
        {

            double cantidad = p.GetCantidad();
            double total;
            Euro euro;

            total = e.cantidad - ((cantidad / 38.33) * 1.16);

            euro = new Euro(total);

            return euro;
        }

        public static Euro operator +(Euro e, Peso p)
        {

            double cantidad = p.GetCantidad();
            double total;
            Euro euro;

            total = e.cantidad + ((cantidad / 38.33) * 1.16);

            euro = new Euro(total);

            return euro;

        }

        public static Euro operator +(Euro e, Dolar p)
        {

            double cantidad = p.getCantidad();
            double total;
            Euro euro;

            total = e.cantidad + ((cantidad / 1.16));

            euro = new Euro(total);

            return euro;

        }

        public static Euro operator -(Euro e, Dolar p)
        {

            double cantidad = p.getCantidad();
            double total;
            Euro euro;

            total = e.cantidad - ((cantidad / 1.16));

            euro = new Euro(total);

            return euro;

        }

    }
}
