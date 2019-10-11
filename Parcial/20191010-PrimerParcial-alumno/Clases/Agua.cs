using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Agua : Botella
    {

        public const int MEDIDA = 400;

        public Agua(int capacidadML, string marca, int contenidoML) : base(capacidadML, contenidoML, marca)
        {
        }

        public override int ServirMedida()
        {
            int retorno = 1;

            if (MEDIDA <= this.contenidoML)
            {

                this.contenidoML -= MEDIDA;

            }
            else
            {

                this.Contenido -= this.contenidoML;
                retorno = 0;
            }


            return retorno;
        }

        public int ServirMedida(int medida) {


            if(medida != MEDIDA)
            {
                this.ServirMedida();
            }

            return 1;
        }

        protected override string GenerarInforme()
        {

            return base.GenerarInforme();

        }










    }
}
