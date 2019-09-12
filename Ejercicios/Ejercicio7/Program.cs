using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int dia;
            int mes;
            int anio;
            int total;
            DateTime nacimiento;
            int diferencia;

            Console.Write("Dia: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out dia)) {

                Console.Write("Mes: ");
                aux = Console.ReadLine();

                if(int.TryParse(aux,out mes))
                {

                    Console.Write("Anio: ");
                    aux = Console.ReadLine();
                    if (int.TryParse(aux, out anio))
                    {

                        nacimiento = new DateTime(anio, mes, dia);

                        diferencia = DateTime.Now.Year - nacimiento.Year;
                        total = (diferencia * 350) + nacimiento.Day + (nacimiento.Month * 31);

                        Console.WriteLine("El total de dias vividos es de: {0}", total);
                                              

                    }
                    else {
                        Console.WriteLine("ingrese un numero correcto");
                    }

                }
                else
                {
                    Console.WriteLine("ingrese un numero correcto");
                }

            }
            else
            {
                Console.WriteLine("ingrese un numero correcto");
            }

            Console.ReadKey();
        }
    }
}
