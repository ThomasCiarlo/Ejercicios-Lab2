using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
   public class CentralitaException : Exception
  {
    private string nombreClase;
    private string nombreMetodo;

    public string NombreClase { get { return this.nombreClase; } }
    public string NombreMetodo { get { return this.nombreMetodo; } }

    public CentralitaException(string mensaje, string nombreClase, string nombreMetodo) : this(mensaje, nombreClase, nombreMetodo, null)
    {
      
    }

    public CentralitaException(string mensaje, string nombreClase, string nombreMetodo, Exception innerException) : base(mensaje,innerException)
    {
      this.nombreMetodo = nombreMetodo;
      this.nombreClase = nombreClase;

    }





  }
}
