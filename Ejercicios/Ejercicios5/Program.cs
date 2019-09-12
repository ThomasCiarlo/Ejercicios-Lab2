using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios5
{
    class Program
    {
        static void Main(string[] args)
        {
            string aux;
            int num;
            int acum1 = 0;
            int acum2 = 0;
            bool centro= false;

            Console.Write("Ingrese un numero: ");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out num)) {

                for (int i = 0; i < num; i++) {
                    acum1 = 0;
                    acum2 = 0;
                    centro = false;

                    for (int j = 0; j < i; j++) {

                        acum1 += j;
                        
                    }

                    for (int k = i+1; ; k++)
                    {
                        acum2 += k;

                        if (acum1 == acum2) {

                            centro = true;
                            break;
                        }

                        if (acum2 > acum1) {

                            break;
                        }


                    }

                    if (centro) {
                        Console.WriteLine("{0,5}",i);

                    }

                }

                Console.ReadKey();


            }
            else
            {
                Console.WriteLine("Numero incorrecto");
            }


        }
    }
}
