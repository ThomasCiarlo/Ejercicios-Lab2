using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cantina
    {
        private int espacionTotales;
        private List<Botella> botellas;
        private static Cantina singleton;


        public List<Botella> Botellas { get { return this.botellas; } }


        private Cantina(int espacion)
        {
            this.espacionTotales = espacion;
            this.botellas = new List<Botella>();
        }

        public static Cantina GetCantina(int espacios)
        {
            if (Cantina.singleton is null)
            {
                Cantina.singleton = new Cantina(espacios);
            }
            else
            {
                Cantina.singleton.espacionTotales = espacios;
            }

            return Cantina.singleton;

        }

        public static bool operator +(Cantina c, Botella b)
        {

            bool todoOk = false;

            if(c.espacionTotales > c.botellas.Count)
            {
                c.botellas.Add(b);
                todoOk = true;
            }

            return todoOk;

        }





    }
}
