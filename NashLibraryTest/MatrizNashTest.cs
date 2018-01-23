using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace NashLibrary.Tests
{
    [TestClass]
    public class MatrizNashTest
    {

        [TestMethod]
        public void MatrizNashTestInicializador()
        {
            MatrizNash matriz = new MatrizNash(2, 3);

            Assert.AreEqual(matriz.Filas, 2);
            Assert.AreEqual(matriz.Columnas, 3);
        }
        [TestMethod]
        public void MatrizNashTestEncontrarFilasMayorPago()
        {
            MatrizNash matriz = new MatrizNash(2, 3);

            matriz.Renglones[0, 0] = new Renglon(5, 5);
            matriz.Renglones[0, 1] = new Renglon(10, 0);
            matriz.Renglones[0, 2] = new Renglon(6, 20);

            matriz.Renglones[1, 0] = new Renglon(3, 15);
            matriz.Renglones[1, 1] = new Renglon(0, 10);
            matriz.Renglones[1, 2] = new Renglon(8, 11);
            /*Las columnas sólo aplican para los valores del pagoY*/
            int columna = matriz.encontrarColumnaMayorPago(0);
            Assert.AreEqual(columna, 2);

            columna = matriz.encontrarColumnaMayorPago(1);
            Assert.AreEqual(columna, 0);

            Assert.AreEqual(matriz.Filas, 2);
            Assert.AreEqual(matriz.Columnas, 3);

        }
        [TestMethod]
        public void MatrizNashTestEncontrarColumnasMayorPago()
        {
            MatrizNash matriz = new MatrizNash(2, 3);

            matriz.Renglones[0, 0] = new Renglon(5, 55);
            matriz.Renglones[1, 0] = new Renglon(3, 15);

            matriz.Renglones[0, 1] = new Renglon(10, 0);
            matriz.Renglones[1, 1] = new Renglon(0, 10);

            matriz.Renglones[0, 2] = new Renglon(6, 20);
            matriz.Renglones[1, 2] = new Renglon(8, 11);
            /*Las filas sólo aplican para los valores del pagoX*/
            int fila = matriz.encontrarFilaMayorPago(0 );
            Assert.AreEqual(fila, 0);

            fila = matriz.encontrarFilaMayorPago(1);
            Assert.AreEqual(fila, 0);

            fila = matriz.encontrarFilaMayorPago(2);
            Assert.AreEqual(fila, 1);
            
            Assert.AreEqual(matriz.Filas, 2);
            Assert.AreEqual(matriz.Columnas, 3);

        }
    }
}
