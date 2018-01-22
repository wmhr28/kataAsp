using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Nash.Tests
{
    [TestClass]
    public class NashTest
    {

        [TestMethod]
        public void NashTestInicializador()
        {
            
            MatrizNash problema = new MatrizNash(2,2);

            Nash objNash = new Nash(problema);
             
            Assert.AreEqual(objNash.TieneEquilibrios, false);
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 0);
            Assert.AreEqual(objNash.Filas, 2);
            Assert.AreEqual(objNash.Columnas, 2);
        }

        [TestMethod]
        public void NashTestDilemaPrisionero()
        {

            MatrizNash problema = new MatrizNash(2, 2);

            problema.Renglones[0, 0] = new Renglon(5, 5);
            problema.Renglones[1, 0] = new Renglon(0, 10);

            problema.Renglones[0, 1] = new Renglon(10, 0);
            problema.Renglones[1, 1] = new Renglon(1, 1);

            Nash objNash = new Nash(problema);

            objNash.encontrarEquilibrios();

            Assert.AreEqual(objNash.TieneEquilibrios, true);
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 1);
            Assert.AreEqual(objNash.Filas, 2);
            Assert.AreEqual(objNash.Columnas, 2);
        }
        [TestMethod]
        public void NashTestDilemaPrisionero55esEquilibrio()
        {

            MatrizNash problema = new MatrizNash(2, 2);

            problema.Renglones[0, 0] = new Renglon(5, 5);
            problema.Renglones[1, 0] = new Renglon(0, 10);

            problema.Renglones[0, 1] = new Renglon(10, 0);
            problema.Renglones[1, 1] = new Renglon(1, 1);

            Nash objNash = new Nash(problema);

            objNash.encontrarEquilibrios();
            Assert.AreEqual(objNash.TieneEquilibrios, true);
            Assert.AreEqual(objNash.esEsquilibrioElRenglon(5,5), true);
            
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 1);
            Assert.AreEqual(objNash.Filas, 2);
            Assert.AreEqual(objNash.Columnas, 2);
        }


        [TestMethod]
        public void NashTestCadenasTv()
        {

            MatrizNash problema = new MatrizNash(2, 2);

            problema.Renglones[0, 0] = new Renglon(27, 27);
            problema.Renglones[1, 0] = new Renglon(20, 40);

            problema.Renglones[0, 1] = new Renglon(40, 20);
            problema.Renglones[1, 1] = new Renglon(50, 50);

            Nash objNash = new Nash(problema);

            objNash.encontrarEquilibrios();
            Assert.AreEqual(objNash.TieneEquilibrios, true);
            Assert.AreEqual(objNash.esEsquilibrioElRenglon(27, 27), true);
            Assert.AreEqual(objNash.esEsquilibrioElRenglon(50, 50), true);
            
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 2);
            Assert.AreEqual(objNash.Filas, 2);
            Assert.AreEqual(objNash.Columnas, 2);
        }

        [TestMethod]
        public void NashTestMatriz2x2()
        {

            MatrizNash problema = new MatrizNash(2, 2);

            problema.Renglones[0, 0] = new Renglon(7, 4);
            problema.Renglones[1, 0] = new Renglon(5, 2);

            problema.Renglones[0, 1] = new Renglon(3, 1);
            problema.Renglones[1, 1] = new Renglon(8, 6);

            Nash objNash = new Nash(problema);

            objNash.encontrarEquilibrios();

            Assert.AreEqual(objNash.TieneEquilibrios, true);
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 2);
            Assert.AreEqual(objNash.Filas, 2);
            Assert.AreEqual(objNash.Columnas, 2);
        }

        [TestMethod]
        public void NashTestMatriz3x2()
        {

            MatrizNash problema = new MatrizNash(3, 2);

            problema.Renglones[0, 0] = new Renglon(3, 9);
            problema.Renglones[1, 0] = new Renglon(4, 2);
            problema.Renglones[2, 0] = new Renglon(-2, 1);

            problema.Renglones[0, 1] = new Renglon(4, -1);
            problema.Renglones[1, 1] = new Renglon(1, 8);
            problema.Renglones[2, 1] = new Renglon(5, 0);

            Nash objNash = new Nash(problema);

            objNash.encontrarEquilibrios();

            Assert.AreEqual(objNash.TieneEquilibrios, false);
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 0);
            Assert.AreEqual(objNash.Filas, 3);
            Assert.AreEqual(objNash.Columnas, 2);
        }

        [TestMethod]
        public void NashTestMatriz3x4()
        {

            MatrizNash problema = new MatrizNash(3, 4);

            problema.Renglones[0, 0] = new Renglon(0, 6);
            problema.Renglones[1, 0] = new Renglon(4, 5);
            problema.Renglones[2, 0] = new Renglon(3, -2);
            
            problema.Renglones[0, 1] = new Renglon(3, -1);
            problema.Renglones[1, 1] = new Renglon(-1, 7);
            problema.Renglones[2, 1] = new Renglon(10, 5);

            problema.Renglones[0, 2] = new Renglon(4, 9);
            problema.Renglones[1, 2] = new Renglon(10, 2);
            problema.Renglones[2, 2] = new Renglon(-2, 3);

            problema.Renglones[0, 3] = new Renglon(12, 2);
            problema.Renglones[1, 3] = new Renglon(6, 8);
            problema.Renglones[2, 3] = new Renglon(4, 1);


            Nash objNash = new Nash(problema);

            objNash.encontrarEquilibrios();

            Assert.AreEqual(objNash.TieneEquilibrios, true);
            Assert.AreEqual(objNash.CuantosEquilibriosTiene, 1);

            Assert.AreEqual(objNash.Filas, 3);
            Assert.AreEqual(objNash.Columnas, 4);
        }
    }
}
