using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sum = new Sumador();
            Sumador sum2 = new Sumador(2);
            long total;
            string tot;
            int cant;
            

            total= sum.sumar(100, 100);
            tot = sum.sumar("100", "1005");
            sum.getCantidadDeSumas(out cant);

            Console.WriteLine(total);
            Console.WriteLine(tot);
            Console.WriteLine(cant);

            cant = (int)sum;
            total = sum + sum2;

            if (sum | sum2)
            {
                Console.WriteLine("Son iguales");
            }
            else {
                Console.WriteLine("No son iguales");
            }

            Console.WriteLine(total);
            Console.WriteLine(cant);





            Console.ReadKey();

        }
    }
}
