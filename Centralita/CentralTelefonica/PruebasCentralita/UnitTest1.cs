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

            Assert.IsTrue(central.Llamadas != null);

        }

        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void excepcionLlamadasLocal()
        {
            Centralita central = new Centralita();
            Local l1 = new Local("123", 10, "1234", 15);

            central += l1;

            Local l2 = new Local("123", 10, "1234", 15);

            central += l2;

        }
        [TestMethod]
        [ExpectedException(typeof(CentralitaException))]
        public void excepcionLlamadasProvincial()
        {
            Centralita central = new Centralita();
            Provincial l1 = new Provincial("123", Provincial.Franja.Franja_1, 15, "1234");

            central += l1;

            Provincial l2 = new Provincial("123", Provincial.Franja.Franja_1, 15, "1234");
            central += l2;

        }

        [TestMethod]
        public void ComprarLlamadas()
        {
            Provincial l1 = new Provincial("123", Provincial.Franja.Franja_1, 15, "1234");
            Provincial l2 = new Provincial("123", Provincial.Franja.Franja_1, 15, "1234");

            Local l3 = new Local("123", 10, "1234", 15);
            Local l4 = new Local("123", 10, "1234", 15);

            Assert.IsFalse(l1 == l3);
            Assert.IsFalse(l2 == l4);
            Assert.IsTrue(l1 == l2);
            Assert.IsTrue(l3 == l4);



        }
    }
}
