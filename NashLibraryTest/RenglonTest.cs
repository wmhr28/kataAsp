using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NashLibrary.Tests
{
    [TestClass]
    public class RenglonTest
    {

        [TestMethod]
        public void RenglonTestInicializador()
        {
            Renglon renglon11 = new Renglon(5, 6);

            Assert.AreEqual(renglon11.Equilibrio, false);
            Assert.AreEqual(renglon11.ValorPagoX, 5);
            Assert.AreEqual(renglon11.ValorPagoY, 6);
        }

        [TestMethod]
        public void RenglonTestEquilibrio()
        {
            Renglon renglon11 = new Renglon(5, 6);

            Assert.AreEqual(renglon11.Equilibrio, false);
            Assert.AreEqual(renglon11.ValorPagoX, 5);
            Assert.AreEqual(renglon11.ValorPagoY, 6);

            renglon11.PagoXEsMaximo = true;
           // Assert.AreEqual(renglon11.Equilibrio, false);
        }

        [TestMethod]
        public void RenglonTestEquilibrioReal()
        {
            Renglon renglon11 = new Renglon(5, 6);

            Assert.AreEqual(renglon11.Equilibrio, false);
            Assert.AreEqual(renglon11.ValorPagoX, 5);
            Assert.AreEqual(renglon11.ValorPagoY, 6);

            renglon11.PagoXEsMaximo = true;
            renglon11.PagoYEsMaximo = true;
            Assert.AreEqual(renglon11.Equilibrio, true);
        }

        [TestMethod]
        public void RenglonTestImprimirX()
        {
            Renglon renglon11 = new Renglon(5, 6);
            string imp = renglon11.imprimir("X");

            string resp = "<span style='color: blue;'>5</span>";

            Assert.AreEqual(imp, resp);
        }

        [TestMethod]
        public void RenglonTestImprimirY()
        {
            Renglon renglon11 = new Renglon(5, 6);
            string imp = renglon11.imprimir("Y");

            string resp = "<span style='color: red;'>6</span>";

            Assert.AreEqual(imp, resp);
        }

    }
}
