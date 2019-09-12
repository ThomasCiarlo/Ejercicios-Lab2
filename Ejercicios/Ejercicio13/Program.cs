using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            string conver;

            Console.Write("ingrese un numero: ");
            // x = Convert.ToDouble(Console.ReadLine());
            conver = Console.ReadLine();

            x = Conversor.BinarioDecimal(conver);
            Console.WriteLine("el numero en entero es el: {0}", x);

            Console.ReadKey();

        }
    }
}
