using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Alumno
    {
        private double nota1;
        private double nota2;
        private double notaFinal;
        public string nombre;
        public string apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo) {

            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;

        }

        public bool estudiar(double nota1, double nota2) {

            this.nota1 = nota1;
            this.nota2 = nota2;

            return true;
        }

        public void calcularFinal() {

            Random aleatorio = new Random();

            if (nota1 >= 4 && nota2 >= 4)
            {

                notaFinal = aleatorio.Next(1, 10);
                

            }
            else {

                this.notaFinal = -1;

            }

           
        }

        public string Mostrar() {

            string txt;

            if (notaFinal == -1)
            {
                txt = "El alumno: "+ nombre + " esta desaprobado";
            }
            else {
                txt = "La nota final del alumno es: "+notaFinal+" nombre: "+nombre;
            }

            return txt;
        }



    }
}
