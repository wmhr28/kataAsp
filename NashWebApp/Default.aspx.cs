using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using NashLibrary;

namespace NashWebApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string[] nombresFilasColumnas = { "", "CONFIEZA", "NO CONFIEZA" };

            MatrizNash problemaPrisionero = new MatrizNash(2, 2);

            problemaPrisionero.Renglones[0, 0] = new Renglon(5, 5);
            problemaPrisionero.Renglones[1, 0] = new Renglon(0, 10);

            problemaPrisionero.Renglones[0, 1] = new Renglon(10, 0);
            problemaPrisionero.Renglones[1, 1] = new Renglon(1, 1);

            problemaPrisionero.NombresColumnas = nombresFilasColumnas;
            problemaPrisionero.NombresFilas = nombresFilasColumnas;

            Nash objNash = new Nash(problemaPrisionero);

            objNash.encontrarEquilibrios();

            divResultPrisionero.InnerHtml = objNash.imprimirTablaHtml("tablaPrisioneros");



            string[] nombresFilasColumnas2 = { "", "SI PUBLICIDAD", "NO PUBLICIDAD" };

            MatrizNash problemaCadenas = new MatrizNash(2, 2);

            problemaCadenas.Renglones[0, 0] = new Renglon(27, 27);
            problemaCadenas.Renglones[1, 0] = new Renglon(20, 40);

            problemaCadenas.Renglones[0, 1] = new Renglon(40, 20);
            problemaCadenas.Renglones[1, 1] = new Renglon(50, 50);

            problemaCadenas.NombresColumnas = nombresFilasColumnas2;
            problemaCadenas.NombresFilas = nombresFilasColumnas2;

            objNash = new Nash(problemaCadenas);

            objNash.encontrarEquilibrios();

            divResultCadenas.InnerHtml = objNash.imprimirTablaHtml("tablaCadenas");


            string[] nombresFilas = { "", "OPC A", " OPC B", "OPC C" };
            string[] nombresColumnas = { "", "OPC W", "OPC X", "OPC Y", "OPC Z" };

            MatrizNash problema3X4 = new MatrizNash(3, 4);

            problema3X4.Renglones[0, 0] = new Renglon(0, 6);
            problema3X4.Renglones[1, 0] = new Renglon(4, 5);
            problema3X4.Renglones[2, 0] = new Renglon(3, -2);

            problema3X4.Renglones[0, 1] = new Renglon(3, -1);
            problema3X4.Renglones[1, 1] = new Renglon(-1, 7);
            problema3X4.Renglones[2, 1] = new Renglon(10, 5);

            problema3X4.Renglones[0, 2] = new Renglon(4, 9);
            problema3X4.Renglones[1, 2] = new Renglon(10, 2);
            problema3X4.Renglones[2, 2] = new Renglon(-2, 3);

            problema3X4.Renglones[0, 3] = new Renglon(12, 2);
            problema3X4.Renglones[1, 3] = new Renglon(6, 8);
            problema3X4.Renglones[2, 3] = new Renglon(4, 1);


            problema3X4.NombresColumnas = nombresColumnas;
            problema3X4.NombresFilas = nombresFilas;

            objNash = new Nash(problema3X4);

            objNash.encontrarEquilibrios();

            divResultMatriz.InnerHtml = objNash.imprimirTablaHtml("tablaMatriz3x4");


        }
    }
}