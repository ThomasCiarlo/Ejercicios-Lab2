using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercios26
{
    class Program
    {
        static void Main(string[] args)
        {
            Numero numero;
            Numero[] positivos;
            Numero[] negativos;
            Numero[] numeros = new Numero[20];

            Numero numero1 = new Numero(Convert.ToString(-5));
            Numero numero2 = new Numero(Convert.ToString(-4));
            Numero numero3 = new Numero(Convert.ToString(-9));


            numeros[0] = numero1;
            numeros[1] = numero2;
            numeros[2] = numero3;


            Console.WriteLine("Ingrese 20 numeros: ");

            for(int i = 3; i < 20; i++)
            {
              
                numero = new Numero(Convert.ToString(i));
                numeros[i] = numero;

            }
            Console.WriteLine("Numeros: ");
            Console.WriteLine(Numero.mostrarVector(numeros));

            positivos = Numero.mostrarPositivos(numeros);
            Console.WriteLine("Positivos: ");
            Array.Reverse(positivos);
            Console.WriteLine(Numero.mostrarVector(positivos));

            negativos = Numero.mostrarNegativos(numeros);
            Console.WriteLine("Negativos: ");
            Console.WriteLine(Numero.mostrarVector(negativos));

            

            Console.ReadKey();




        }

    }
}
