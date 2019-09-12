using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    public static class CalcularArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double areaTotal=0;

            areaTotal = lado * lado;

            return areaTotal;
        }

        public static double CalcularTriangulo(double A, double b) {

            double areaTotal = 0;


            areaTotal = A * b;


            return areaTotal;
        }



        public static double CalcularCirculo(double x)
        {
            double areaTotal = 0;

            x = Math.Pow(x, 2);

            areaTotal = x * 3.14;


            return areaTotal;
        }

    }
}
