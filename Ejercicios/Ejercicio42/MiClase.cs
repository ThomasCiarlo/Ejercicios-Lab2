using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio42
{
    public class MiClase
    {
        public MiClase() {

            


            

        }

        public MiClase(int n) { }

        public static string Metodo1() {

            throw new DivideByZeroException("e");
        }

        public string Metodo2(string e) { }
    }
}
