using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            int legajo;
            double not1;
            double not2;

            Alumno alum1 = new Alumno("thomas", "ciarlo", 1);
            Alumno alum2 = new Alumno("juan", "lopes", 2);
            Alumno alum3 = new Alumno("eve", "ibarra", 3);

            List<Alumno> Alumnos = new List<Alumno>();

            Alumnos.Add(alum1);
            Alumnos.Add(alum2);
            Alumnos.Add(alum3);

            do
            {
                Console.Clear();

                Console.WriteLine("1. Cargar notas al alumno");
                Console.WriteLine("2. Calcular nota final");
                Console.WriteLine("3. mostrar Alumno");
                opc = int.Parse(Console.ReadLine());

                switch (opc) {
                    case 1:
                        Console.Write("Ingrese el legajo del Alumno a modificar: ");
                        legajo= int.Parse(Console.ReadLine());

                        foreach (Alumno c in Alumnos) {
                            
                            if(c.legajo == legajo)
                            {
                                Console.WriteLine("ingrese la primer nota del alumno: ");
                                not1 = int.Parse(Console.ReadLine());

                                Console.WriteLine("ingrese la segunda nota del alumno: ");
                                not2 = int.Parse(Console.ReadLine());

                                c.estudiar(not1, not2);


                            }

                        }                     
                         break;
                    case 2:
                        Console.Write("Ingrese el legajo del Alumno a calcular final: ");
                        legajo = int.Parse(Console.ReadLine());

                        foreach (Alumno c in Alumnos)
                        {
                            if (c.legajo == legajo) {

                                c.calcularFinal();
                            }
                        }
                        break;
                    case 3:
                        Console.Write("Ingrese el legajo del Alumno a mostrar: ");
                        legajo = int.Parse(Console.ReadLine());

                        foreach (Alumno c in Alumnos)
                        {

                            if (c.legajo == legajo)
                            {
                                Console.WriteLine("{0}",c.Mostrar());
                                Console.ReadKey();
                            }
                        }
                      break;
    

                     }


            } while (opc != 5);

          






        }
    }
}
