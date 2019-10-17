using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
  public class Centralita
  {
    private List<Llamada> listaDeLlamadas;
    protected string razonSocial;

    public float GananciasPorLocal { get { return this.CalcularGanacia(Llamada.TipoLlamada.Local); } }
    public float GananciasPorProvincial { get { return this.CalcularGanacia(Llamada.TipoLlamada.Provincial); } }
    public float GananciasPorTodas { get { return this.CalcularGanacia(Llamada.TipoLlamada.Todas); } }
    public List<Llamada> Llamadas { get { return this.listaDeLlamadas; } }




    public Centralita()
    {

      listaDeLlamadas = new List<Llamada>();

    }

    public Centralita(string nombreEmpresa) : this()
    {

      this.razonSocial = nombreEmpresa;

    }


    private float CalcularGanacia(Llamada.TipoLlamada tipo)
    {

      float total = 0;
      Local local;
      Provincial provincial;

      if (tipo == Llamada.TipoLlamada.Todas)
      {
        foreach (Llamada c in listaDeLlamadas)
        {

          if (c is Local)
          {

            local = (Local)c;
            total += local.CostoLlamada;

          }
        }

        foreach (Llamada c in listaDeLlamadas)
        {

          if (c is Provincial)
          {

            provincial = (Provincial)c;
            total += provincial.CostoLlamada;

          }
        }
      }
      else if (tipo == Llamada.TipoLlamada.Local)
      {

        foreach (Llamada c in listaDeLlamadas)
        {

          if (c is Local)
          {

            local = (Local)c;
            total += local.CostoLlamada;

          }
        }

      }
      else
      {
        foreach (Llamada c in listaDeLlamadas)
        {

          if (c is Provincial)
          {

            provincial = (Provincial)c;
            total += provincial.CostoLlamada;

          }
        }

      }

      return total;
    }

    private void AgregarLlamada(Llamada llamadaNueva)
    {
      this.listaDeLlamadas.Add(llamadaNueva);
    }

    public string Mostrar()
    {

      StringBuilder texto = new StringBuilder($"\nEmpresa: {this.razonSocial}, \nTotal ganado:" +
        $" {this.GananciasPorTodas}\nGanado por local: {this.GananciasPorLocal}, " +
        $"\nGanado por las provincial: {this.GananciasPorProvincial}\n\n");

      foreach (Llamada c in this.listaDeLlamadas)
      {
        texto.Append($"\n{c.ToString()}\n");
      }
      texto.Append("\n--------------------------------------------\n");
      return texto.ToString();
    }



    public void OrdenarLlamadas()
    {

      this.listaDeLlamadas.Sort(Llamada.OrdenarLista);

    }

    public static bool operator ==(Centralita central, Llamada l1)
    {
      bool todoOk = false;

      foreach (Llamada c in central.listaDeLlamadas)
      {
        if (c.Equals(l1))
        {
          todoOk = true;
        }

      }
      return todoOk;
    }

    public static bool operator !=(Centralita central, Llamada l1)
    {

      return !(central == l1);

    }

    public static Centralita operator +(Centralita central, Llamada l1)
    {

      if (central != l1)
      {
        central.AgregarLlamada(l1);

      }
      else
      {
        throw new CentralitaException("Error llamada registrada", "Centralita", "AgregarLlamada");
      }

      return central;

    }






  }


}

