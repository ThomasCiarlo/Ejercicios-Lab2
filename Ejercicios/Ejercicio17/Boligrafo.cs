using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    public class Boligrafo
    {
        private ConsoleColor color;
        private short tinta;
        const short cantMaximaTinta=100;

        public Boligrafo(short tinta, ConsoleColor color) {

            this.tinta = tinta;
            this.color = color;

        }

        public short getTinta() {

            return this.tinta;
        }

        public ConsoleColor getColor() {

            return this.color; ;
        }

        private void SetTinta(short tinta) {

            short aux = this.tinta;

            if (tinta >= 0)
            {
                if (aux + tinta <= cantMaximaTinta)
                {

                    this.tinta += tinta;
                }
                else
                {
                    Console.WriteLine("Exede el nivel maximo de tinta");
                }

            }
            else {

                if (aux - tinta >= 0)
                {

                    this.tinta += tinta;
                }
                else {

                    Console.WriteLine("Exede el nivel minimo de tinta");
                }

            }

        }

        public void recargar() {

            this.tinta = cantMaximaTinta;

        }

        public bool Pintar(short tinta, out string dibujo) {

            dibujo = "";
            int i = 0;
            bool todoOk = false;



            if (this.tinta >= tinta)
            {
                while (i != tinta)
                {
                    
                       this.SetTinta(-1);
                       dibujo += "*";
                       todoOk = true;
                       i++;
                    
                }
            }
            else {

                Console.WriteLine("No posee ese nivel de tinta");
                Console.ReadKey();
            }

            

            return todoOk;
        }






    }
}
