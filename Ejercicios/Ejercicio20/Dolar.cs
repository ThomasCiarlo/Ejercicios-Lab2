using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
    class Dolar
    {
        private double cantidad;
        private static double cotizRespectoDolar;
        private Dolar() { }

        public Dolar(double cantidad) {

            this.cantidad = cantidad;
        }

        public Dolar(double cantidad, double cotizRespctoDolar) : this(cantidad)
        {
            Dolar.cotizRespectoDolar = cotizRespctoDolar;

        }

        public double getCantidad() {

            double cantidad = this.cantidad;

            return cantidad;
        }

        public static double GetCotizacion()
        {

            double cotizacion = Dolar.cotizRespectoDolar;
            return cotizacion;

        }


        public static explicit operator Euro(Dolar d)
        {

            double valor;
            Euro e;

            valor = d.cantidad * Euro.GetCotizacion();

            e = new Euro(valor);

            return e;
        }

        public static explicit operator Peso(Dolar d) {

            Peso p;
            double valor;

            valor = d.cantidad * Peso.GetCotizacion();

            p = new Peso(valor);

            return p;
        }

        public static implicit operator Dolar(double c) {

            Dolar d = new Dolar(c);

            return d;

        }

        public static bool operator !=(Dolar d, Euro e) {


            bool todoOk = false;
            double cantidadE = e.GetCantidad();

            if (d.cantidad != cantidadE) {

                todoOk = true;
            }

            return todoOk;

        }

        public static bool operator ==(Dolar d, Euro e) {

            bool todoOk = true;

            if (d != e) {
                todoOk = false;
            }

            return todoOk;
        }

        public static bool operator ==(Dolar d, Peso p) {

            bool todoOk = false;
            double cantidad = p.GetCantidad();

            if (d.cantidad == cantidad ) {

                todoOk = true;
            }

            return todoOk;

        }


        public static bool operator !=(Dolar d, Peso p) {

            bool todoOk = true;

            if (d == p) todoOk = false;

            return todoOk;

        }

        public static bool operator !=(Dolar d, Dolar p) {

            bool todoOk = false;

            if (d.cantidad != p.cantidad) {

                todoOk = true;

            }

            return todoOk;

        }

        public static bool operator ==(Dolar d, Dolar p)
        {

            bool todoOk = false;

            if (!(d != p)) todoOk = true;

            return todoOk;
        }

        public static Dolar operator - (Dolar d, Euro e) {

            double cantidad = e.GetCantidad();
            double total;
            Dolar dola;

            total = d.cantidad - (cantidad * Euro.GetCotizacion());

            dola = new Dolar(total);


            return dola;

        }

        public static Dolar operator -(Dolar d, Peso p)
        {

            double cantidad = p.GetCantidad();
            double total;
            Dolar dola;

            total = d.cantidad - (cantidad / Peso.GetCotizacion());

            dola = new Dolar(total);


            return dola;

        }

        public static Dolar operator +(Dolar d, Peso p) {

            double cantidad = p.GetCantidad();
            double total;
            Dolar dola;

            total = d.cantidad + (cantidad / 38.33);

            dola = new Dolar(total);


            return dola;

        }

        public static Dolar operator +(Dolar d, Euro e)
        {

            double cantidad = e.GetCantidad();
            double total;
            Dolar dola;

            total = d.cantidad + (cantidad * 1.16);

            dola = new Dolar(total);


            return dola;

        }



    }
}
