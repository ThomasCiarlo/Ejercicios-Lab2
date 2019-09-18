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
            
            Random num = new Random();

            #region conListas
            /* List<int> numerosList = new List<int>();
             List<int> NumeroPositivo = new List<int>();
             List<int> NumeroNegativo = new List<int>();

             for (int i = 0; i < 20; i++) {               
                 numerosList.Add(num.Next(-100, 100));
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
             */
            #endregion

            Stack<int> numerosLista = new Stack<int>();


            List<int> NumeroPositivo = new List<int>();
            List<int> NumeroNegativo = new List<int>();

            for (int i = 0; i < 20; i++) {

                numerosLista.Push(num.Next(-100, 100));

            }

            foreach (int c in numerosLista) {

                Console.Write(c + ", ");

                if (c < 0)
                {
                    NumeroNegativo.Add(c);
                }
                else {
                    NumeroPositivo.Add(c);
                }
            }
            Console.WriteLine("\nNumeros Positivos: ");
            NumeroPositivo.Sort();
            NumeroPositivo.Reverse();
            foreach (int c in NumeroPositivo) {
                
                Console.Write(c + ", ");
            }


            Console.WriteLine("\nNumeros negativos: ");
            NumeroNegativo.Sort();
            foreach (int c in NumeroNegativo)
            {
                
                Console.Write(c + ", ");
            }








            Console.ReadKey();



        }
    }
}
