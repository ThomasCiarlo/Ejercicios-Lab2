using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            int min = int.MaxValue;
            int num;
            double promedio=0;
            
            for (int i = 0; i < 10; i++) {

                Console.Write("ingrese el numero: ");
                num = Int32.Parse(Console.ReadLine());

                if (Validacion.Validar(num, 100, -100))
                {
                    if (max < num) {

                        max = num;
                    }
                    if(min > num){
                        min = num;
                    }

                    promedio += num;
                    

                }
                else {

                    i--;
                }
                
               
            }

            promedio = promedio / 10;
            Console.WriteLine("Numero max: {0}, numero min{1}, promedio: {2} ",max,min,promedio);

            Console.ReadKey();
        }
    }
}
