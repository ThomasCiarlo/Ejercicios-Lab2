using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class Program
    {
        static void Main(string[] args)
        {

            int opc;
            double lado;
            double resp;
            double alto;
            double radio;

            do
            {

            Console.WriteLine("1. Calcular cuadrado");
            Console.WriteLine("2. Calcular triangulo");
            Console.WriteLine("3. Calcular circulo");
            Console.Write("Seleccione la opcion que desea: ");
            opc = int.Parse(Console.ReadLine());

           
                switch (opc)
                {

                    case 1:
                        Console.Write("Ingrese el lado del cuadrado: ");
                        lado = double.Parse(Console.ReadLine());
                        resp = CalcularArea.CalcularCuadrado(lado);
                        Console.WriteLine("El area del cuadrado es de: {0}", resp);
                        break;
                    case 2:
                        Console.Write("Ingrese el alto del trinagulo: ");
                        alto = double.Parse(Console.ReadLine());
                        Console.Write("Ingrese la base del trinagulo: ");
                        lado = double.Parse(Console.ReadLine());
                        resp = CalcularArea.CalcularTriangulo(alto, lado);
                        Console.WriteLine("El area del cuadrado es de: {0}", resp);
                        break;
                    case 3:
                        Console.Write("Ingrese el radio del triangulo: ");
                        radio = double.Parse(Console.ReadLine());
                        resp = CalcularArea.CalcularCirculo(radio);
                        Console.WriteLine("El area del cuadrado es de: {0}", resp);
                        break;

                }
            } while (opc == 5);



            Console.ReadKey();


        }
    }
}
