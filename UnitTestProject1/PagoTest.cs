using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nash.Tests
{
    [TestClass]
    public class PagoTest
    {
        [TestMethod]
        public void PagoTestInicializador()
        {
           Pago pago = new Pago(5);
            
            Assert.AreEqual(pago.Valor, 5);
            Assert.AreEqual(pago.EsMaximo, false);
        }
    }
}
