using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    public static class Calculadora
    {
        private static bool Validar(double num) {

            bool todoOk = true;

            if( num < 0)
            {
                todoOk = false;

            }

            return todoOk;
        }

        public static double calcular(double num1,double num2,string signo)
        {
            double total=0;

            switch (signo)
            {
                case "+":
                    total = num1 + num2;
                    break;
                case "-":
                    total = num1 - num2;
                    break;
                case "*":
                    total = num1 * num2;
                    break;
                case "/":
                    if (Calculadora.Validar(num2))
                    {

                        total = num1 / num2;
                    }
                    else {

                        Console.WriteLine("No se puede divir por 0 o un numero menor a 0");
                    }
                    break;
                default:
                    Console.WriteLine("operacion no reconocida");
                    break;



            }


            return total;
        }


    }
}
