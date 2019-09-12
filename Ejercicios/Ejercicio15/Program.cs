using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1;
            double num2;
            double total;
            string oper;

            do {

                Console.Write("ingrese el primer numero: ");
                num1 = double.Parse(Console.ReadLine());

                Console.Write("ingrese el primer numero: ");
                num2 = double.Parse(Console.ReadLine());

                Console.Write("ingrese el signo de la operacion: ");
                oper = Console.ReadLine();

                total = Calculadora.calcular(num1, num2, oper);

                Console.WriteLine("El resultado es: {0}", total);

            } while (oper == "***");


            Console.ReadKey();
        }

        
    }
}
