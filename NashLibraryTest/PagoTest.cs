using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NashLibrary.Tests
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

        [TestMethod]
        public void PagoTestImprimirMaximo()
        {
            Pago pago = new Pago(5);
            pago.EsMaximo = true;
            string imp = pago.imprimir();

            Assert.AreEqual(imp, "<u><b>5</b></u>");
            Assert.AreEqual(pago.Valor, 5);
            Assert.AreEqual(pago.EsMaximo, true);
        }
        [TestMethod]
        public void PagoTestImprimir()
        {
            Pago pago = new Pago(6);
            
            string imp = pago.imprimir();

            Assert.AreEqual(imp, "6");
            Assert.AreEqual(pago.Valor, 6);
            Assert.AreEqual(pago.EsMaximo, false);
        }
    }
}
