using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Sumador
    {
        private int cantidadDeSumas;
        public Sumador(int cantidadDeSumas) {

            this.cantidadDeSumas = cantidadDeSumas;

        }
        public Sumador() : this(0) {

        }

        public long sumar(long num1, long num2) {

            long total = num1 + num2;
            this.cantidadDeSumas++;

            return total;
        }

        public string sumar(string num1, string num2)
        {

            string total = num1 + num2;
            this.cantidadDeSumas++;

            return total;
        }

        public void getCantidadDeSumas(out int cant) {

            cant = this.cantidadDeSumas;

        }

        public static explicit operator int(Sumador s) {

            int cant = s.cantidadDeSumas;

            return cant;
        }

        public static long operator + (Sumador a, Sumador b){

            long total = a.cantidadDeSumas + b.cantidadDeSumas;

            return total;
          }

        public static bool operator |(Sumador a, Sumador b) {

            bool todoOk = false;

            if (a.cantidadDeSumas == b.cantidadDeSumas) {
                todoOk = true;
            }

            return todoOk;
        }


            
    }
}
