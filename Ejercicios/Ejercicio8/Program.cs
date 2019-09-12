using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            string nombre;
            int valorHora;
            int antiguedad;
            int horasTrabajadas;
            double totalBruto;
            double totalNeto;


            Console.Write("Ingrese su nombre: ");
            nombre = Console.ReadLine();

            Console.Write("Ingrese su Antiguedad: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out antiguedad)) {
                Console.Write("Ingrese las horas trabajadas: ");
                aux = Console.ReadLine();
                if (int.TryParse(aux, out horasTrabajadas)) {
                    Console.Write("Ingrese el valor de la hora: ");
                    aux = Console.ReadLine();
                    if (int.TryParse(aux, out valorHora)) {
                        totalBruto = ((valorHora * horasTrabajadas) + (antiguedad * 150));
                        totalNeto = totalBruto * 0.87;

                        Console.WriteLine("El empleado: {0}, cobrar un sueldo Bruto de: {1}, sueldo neto: {2}", nombre, totalBruto,totalNeto);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
