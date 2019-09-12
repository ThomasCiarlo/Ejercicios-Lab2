using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    public static class Conversor
    {
        public static string DecimalBinario(double x){

            string bin="";
            string aux;
            double result=0;
            

            while (x == 1) {

                result += x % 2;

                aux = Convert.ToString(result);
                bin += aux;
                
            }
            

            return bin;
        }

        public static double BinarioDecimal(string dato) {

            double x=0;
            int exp = 0;

            for (int i = dato.Length-1; i >= 0; i--)
            {
                
                if (dato[i] == '1') {

                    x += Math.Pow(2, exp);

                }
                exp++;
            }

            return x;
        }

    }
}
