using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Clases;

namespace PruebasCentralita
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void CentralitaInstanciada()
    {
      Centralita central = new Centralita();

      Assert.AreSame(null, central);
    }
  }
}
