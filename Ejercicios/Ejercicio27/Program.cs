using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Random num = new Random();

            List<int> numerosList = new List<int>();
            List<int> NumeroPositivo = new List<int>();
            List<int> NumeroNegativo = new List<int>();

            for (int i = 0; i < 20; i++) {
                numero = num.Next(-100, 100);
                numerosList.Add(numero);
            }

            for (int i = 0; i < 20; i++) {

                if (numerosList[i] < 0) {

                    NumeroNegativo.Add(numerosList[i]);

                }

            }

            for (int i = 0; i < 20; i++)
            {

                if (numerosList[i] >= 0)
                {

                    NumeroPositivo.Add(numerosList[i]);

                }

            }


            for (int i = 0; i < 20; i++) {
                Console.Write(numerosList[i]+",");
            }

            NumeroPositivo.Sort();
            NumeroPositivo.Reverse();
            Console.WriteLine("\n Numeros Positivos: ");
            foreach (int c in NumeroPositivo) {

                Console.Write(c + ",");
            }

            NumeroNegativo.Sort();
            Console.WriteLine("\nNumeros Negativos: ");
            foreach (int c in NumeroNegativo)
            {

                Console.Write(c+ ",");
            }


            Console.ReadKey();



        }
    }
}
