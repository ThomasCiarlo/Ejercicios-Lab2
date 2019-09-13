using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercios26
{
    class Numero
    {
        private int valor;

        public Numero(string num)
        {
            if (int.TryParse(num, out this.valor))
            {
            }

        }

        public static string mostrarVector(Numero[] numeros)
        {
            string lista = "";

            for (int i = 0; i < numeros.Length; i++)
            {
                if (!(numeros[i] is null)) {
                    lista += " " + Convert.ToString(numeros[i].valor);

                }

            }

            return lista;
        }

        public static Numero[] mostrarPositivos(Numero[] list) {


            Numero[] Lista = new Numero[20];
            int x = 0;


            for (int i = 0; i < list.Length; i++)
            {

                if (list[i].valor >= 0)
                {
                    Lista[x] = list[i];
                    x++;

                }

            }

            return Lista;
        }

        public static Numero[] mostrarNegativos (Numero[] list)
        {


            Numero[] Lista = new Numero[20];
            int x = 0;


            for (int i = 0; i < list.Length; i++)
            {

                if (list[i].valor < 0)
                {
                    Lista[x] = list[i];
                    x++;

                }

            }

            return Lista;
        }
    }
}
