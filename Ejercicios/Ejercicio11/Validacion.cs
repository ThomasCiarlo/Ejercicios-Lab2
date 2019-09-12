using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio11
{
    public static class Validacion
    {

        public static bool Validar(int valor, int max, int min) {

            bool todoOk = true;

            while (!(valor > min && valor < max))
            {
                todoOk = false;
            }

            return todoOk;
        }

        public static bool validaS(char opc) {

            bool todoOk = true;

            if (opc == 'n') {
                todoOk = false;
            }

            return todoOk;
        }
    }
}
