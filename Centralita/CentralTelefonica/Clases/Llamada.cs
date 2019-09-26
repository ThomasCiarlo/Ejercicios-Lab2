using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
  public abstract class Llamada
  {
    protected float duracion;
    protected string nroDestino;
    protected string nroOrigen;

    public float Duracion { get { return this.duracion; } }
    public string NroDestino { get { return this.nroDestino; } }
    public string NroOrigen { get { return this.nroOrigen; } }
    public abstract float CostoLlamada { get; set; }

    public Llamada(float duracion, string nroDestino, string nroOrigen)
    {
      this.duracion = duracion;
      this.nroDestino = nroDestino;
      this.nroOrigen = nroOrigen;
    }

    protected virtual string Mostrar()
    {
      StringBuilder texto = new StringBuilder($"Duracion: {Duracion}\nNumero de destino: {NroDestino}\nNumero de origen: {NroOrigen}\n");

      return texto.ToString();
    }

    public static int OrdenarLista(Llamada a, Llamada b)
    {
      if (a.Duracion > b.Duracion)
        return -1;
      else if (a.Duracion > b.Duracion)
        return 1;
      else
        return 0;
    }

    public enum TipoLlamada
    {
      Local,
      Provincial,
      Todas

    }

      public static bool operator ==(Llamada l1, Llamada l2)
    {
      bool todoOk = l1.Equals(l2) && l1.nroDestino == l2.nroDestino && l1.nroOrigen == l2.nroOrigen;

      return todoOk;
    }


      public static bool operator != (Llamada l1, Llamada l2){

          bool todoOk = !(l1 == l2);
        
         return todoOk;
      }

        


  }
}
