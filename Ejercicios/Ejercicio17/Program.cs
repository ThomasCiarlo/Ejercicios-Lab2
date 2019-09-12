using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo lap1 = new Boligrafo(100 , ConsoleColor.Blue);
            Boligrafo lap2 = new Boligrafo(50, ConsoleColor.Red);
            int opc;
            short tinta;
            string dibujo="";
            ConsoleColor color = lap1.getColor();
            short gasto;



            do
            {
                Console.Clear();
                Console.ResetColor();
                Console.WriteLine("1. Recargar boligrafo");
                Console.WriteLine("2. mostrar nivel de tinta");
                Console.WriteLine("3. pintar");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {

                    case 1:
                        lap1.recargar();
                        Console.WriteLine("Se pudo recargar con exito");
                        break;
                    case 2:
                        tinta = lap1.getTinta();
                        Console.WriteLine("Su nivel de tinta es: {0}", tinta);
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine("Seleccione cuanta tinta quiere gastar: ");
                        gasto = short.Parse(Console.ReadLine());

                        if(lap1.Pintar(gasto, out dibujo)){
                          
                            Console.ForegroundColor = color;
                            Console.Write("{0}", dibujo);
                            Console.ReadKey();
                        
                        }
                        
                        break;


                }

            } while (opc != 5);
            Console.ReadKey();
        }
    }
}
