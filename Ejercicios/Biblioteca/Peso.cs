using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Peso
    {
        private double Cantidad;
        private static double cotizRespectoDolar;

        private Peso() { }

        public Peso(double cantidad)
        {
            this.Cantidad = cantidad;
        }

        public Peso(double cantidad, double cotizRespectoDolar) : this(cantidad)
        {

            Peso.cotizRespectoDolar = cotizRespectoDolar;
        }

        public double GetCantidad()
        {

            double cantidad = this.Cantidad;


            return cantidad;

        }

        public double GetCotizacion()
        {

            double Cotizacion = Peso.cotizRespectoDolar;


            return Cotizacion;

        }

        public static explicit operator Dolar(Peso p)
        {

            Dolar d;
            double total = p.Cantidad / 38.33;
            d = new Dolar(total);

            return d;
        }

        public static explicit operator Euro(Peso p)
        {

            Euro e;
            double total = (p.Cantidad / 38.33) * 1.16;
            e = new Euro(total);

            return e;

        }


        public static implicit operator Peso(double c)
        {

            Peso d = new Peso();

            d.Cantidad = c;

            return d;

        }

        public static bool operator !=(Peso p, Dolar d)
        {


            bool todoOk = false;
            double cantidadE = d.getCantidad();

            if (p.Cantidad != cantidadE)
            {

                todoOk = true;
            }

            return todoOk;

        }

        public static bool operator ==(Peso p, Dolar d)
        {

            bool todoOk = true;

            if (p != d) todoOk = true;

            return todoOk;

        }


        public static bool operator !=(Peso p, Euro d)
        {


            bool todoOk = false;
            double cantidadE = d.GetCantidad();

            if (p.Cantidad != cantidadE)
            {

                todoOk = true;
            }

            return todoOk;

        }

        public static bool operator ==(Peso p, Euro d)
        {

            bool todoOk = true;

            if (p != d) todoOk = true;

            return todoOk;

        }

        public static bool operator ==(Peso e, Peso p)
        {

            bool todoOk = false;

            if (e.Cantidad == p.Cantidad)
            {

                todoOk = true;

            }

            return todoOk;
        }

        public static bool operator !=(Peso e, Peso p)
        {

            bool todoOk = true;

            if (e == p) todoOk = false;

            return todoOk;

        }

        public static Peso operator -(Peso p, Euro e)
        {

            Peso pesos;
            double cantidad = e.GetCantidad();
            double total = p.Cantidad - ((cantidad * 1.16) * 38.33);

            pesos = new Peso(total);

            return pesos;

        }

        public static Peso operator +(Peso p, Euro e)
        {

            Peso pesos;
            double cantidad = e.GetCantidad();
            double total = p.Cantidad + ((cantidad * 1.16) * 38.33);

            pesos = new Peso(total);

            return pesos;

        }

        public static Peso operator -(Peso p, Dolar e)
        {

            Peso pesos;
            double cantidad = e.getCantidad();
            double total = p.Cantidad - (cantidad * 38.33);

            pesos = new Peso(total);

            return pesos;

        }

        public static Peso operator +(Peso p, Dolar e)
        {

            Peso pesos;
            double cantidad = e.getCantidad();
            double total = p.Cantidad - (cantidad * 38.33);

            pesos = new Peso(total);

            return pesos;

        }

    }
}
