using System;
using System.Collections.Generic;

namespace NashLibrary
{
    public class Nash
    {
        private MatrizNash problema;
        private bool tieneEquilibrios;
        private List<Renglon> equilibriosEncontrados;


        public Nash(MatrizNash problema)
        {
            this.problema = problema;
            this.tieneEquilibrios = false;
            this.equilibriosEncontrados = new List<Renglon>();
        }

        public bool TieneEquilibrios { get => tieneEquilibrios; }
        public int Filas { get => this.problema.Filas; }
        public int Columnas { get => this.problema.Columnas; }

        public int CuantosEquilibriosTiene { get => this.equilibriosEncontrados.Count; }

        public void encontrarEquilibrios()
        {
            for (int columna = 0; columna < this.Columnas; columna++)
            {
                int filaMayor = this.problema.encontrarFilaMayorPago(columna);
                this.problema.Renglones[filaMayor, columna].PagoXEsMaximo = true;
            }
            for (int fila = 0; fila < this.Filas; fila++)
            {
                int columnaMayor = this.problema.encontrarColumnaMayorPago(fila);
                this.problema.Renglones[fila, columnaMayor].PagoYEsMaximo = true;
            }
            foreach (Renglon renglon in this.problema.Renglones)
            {
                if (renglon.Equilibrio)
                {
                    this.equilibriosEncontrados.Add(renglon);
                    this.tieneEquilibrios = true;
                }
            } 

        }

        public bool esEsquilibrioElRenglon(int valorX, int valorY)
        {
            foreach (Renglon renglon in this.equilibriosEncontrados)
            {
                if (renglon.ValorPagoX == valorX && renglon.ValorPagoY == valorY )
                {
                    return true;
                }
            }
            return false;
        }

        public string imprimirTablaHtml(string idtabla)
        {
            string resp = "<table class='tabla' border='1' cellpadding='5' id='" + idtabla + "'>";

            resp += "<tr>";
            for (int columna = 0; columna <= this.Columnas; columna++)
            {
                resp += "<td class='columna'><b>" + this.problema.NombresColumnas[columna] + "</b></td>";
            }
            resp += "</tr>";
            
            for (int fila = 0; fila < this.Filas; fila++)
            {
                resp += "<tr>";
                resp += "<td class='fila'><b>" + this.problema.NombresFilas[fila+1] + "</b></td>";
                for (int columna = 0; columna < this.Columnas; columna++)
                {
                    resp += "<td class='renglones' style='text-align:center;'>";
                    resp += this.problema.Renglones[fila, columna].imprimir("X");
                    resp += "/";
                    resp += this.problema.Renglones[fila, columna].imprimir("Y");
                    resp += "</td>";
                }
                resp += "</tr>";
            }
            resp += "</table>";
            return resp;
        }
    }
}
