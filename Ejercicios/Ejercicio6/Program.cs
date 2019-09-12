using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int añoAnte;
            int añoPoste;

            Console.Write("Ingrese el primer año: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out añoAnte)) {

                Console.Write("Ingrese el segundo año: ");
                aux = Console.ReadLine();
                if (int.TryParse(aux, out añoPoste))
                {

                    for (int i = añoAnte; i <= añoPoste; i++)
                    {
                        if (i % 4 == 0)
                        {
                            if (i % 100 == 0)
                            {
                                if (i % 400 == 0)
                                {
                                    Console.WriteLine("El año {0} es un año bisiesto", i);
                                }
                            }
                            else
                            {
                                Console.WriteLine("El año {0} es un año bisiesto", i);
                            }
                        }

                    }


                }
                else {
                    Console.WriteLine("Ingrese un año correcto");
                }


            }
            else
            {
                Console.WriteLine("Ingrese un año correcto");
            }

            Console.ReadKey();

        }
    }
}
