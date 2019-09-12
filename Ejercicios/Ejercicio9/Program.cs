using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int altura;
            string aux;

            Console.Write("ingrese la altura de la piramide");
            aux = Console.ReadLine();

            if (int.TryParse(aux, out altura)) {
                for (int i = 0; i < altura; i++) {
                    for (int k = i; ; k++)
                    {
                        Console.Write("*");
                    }
                }
            }
        }
    }
}
