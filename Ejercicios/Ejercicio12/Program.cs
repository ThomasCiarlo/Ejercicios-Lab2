using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio11;

namespace Ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            char opc;
            string aux;
            int sumar=0;

            do {

                Console.Write("ingrese el numero: ");
                num = Int32.Parse(Console.ReadLine());

                sumar += num;

                Console.Write("Desea seguir S/N: ");
                aux = Console.ReadLine();

                if (!(char.TryParse(aux, out opc))) {
                    Console.Write("Ingrese nuevamente la respuesta: ");
                    aux = Console.ReadLine();
                }
               
                                  

            } while (Validacion.validaS(opc));

            Console.WriteLine("La suma de los numero ingresados es de: {0}", sumar);
            Console.ReadKey();
        }
    }
}
