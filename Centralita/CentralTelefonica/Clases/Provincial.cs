using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Provincial : Llamada
    {
      protected Franja franjaHoraria;


    public override float CostoLlamada { get { return this.CalcularCosto(); } set { this.CostoLlamada = value; } }

    public Provincial(Franja miFranja, Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen) {

      this.franjaHoraria = miFranja;

    }

    public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion, destino, origen)
    {
      this.franjaHoraria = miFranja;
    }

    private float CalcularCosto()
    {
      float total=0;

      switch (this.franjaHoraria)
      {
        case Franja.Franja_1:
          total = base.duracion * (float)0.99;
          break;
        case Franja.Franja_2:
          total = base.duracion * (float)1.25;
          break;
        case Franja.Franja_3:
          total = base.duracion * (float)0.66;
          break;
      }

      return total;
    }

    protected override string Mostrar() {

      StringBuilder texto = new StringBuilder($"{base.Mostrar()}. El costo es {this.CostoLlamada}");

      return texto.ToString();

    }

      public enum Franja
    {
      Franja_1,
      Franja_2,
      Franja_3
    }

    public override bool Equals(object obj)
    {

      return obj is Provincial;
    }

    public override string ToString()
    {
      return this.Mostrar();
    }



  }
}
