using System;
using System.Collections.Generic;
using System.Text;

namespace Nash
{
    public class MatrizNash
    {
        private Renglon[,] renglones;
        private int filas;
        private int columnas;

        public MatrizNash(int filas, int columnas)
        {
            this.Renglones = new Renglon[filas, columnas];
            this.filas = filas;
            this.columnas = columnas;
        }
        public int Filas { get => filas; }
        public int Columnas { get => columnas; }

        public Renglon[,] Renglones { get => renglones; set => renglones = value; }

        public int encontrarColumnaMayorPago(int fila)
        {
            int resp = 0;
            int referencia = this.renglones[fila, 0].ValorPagoY;
            for (int i = 1; i < this.Columnas; i++)
            {
                int valorActual = this.renglones[fila, i].ValorPagoY;

                if (valorActual > referencia)
                {
                    resp = i;
                    referencia = valorActual;
                }
            }

            return resp;

        }
        public int encontrarFilaMayorPago(int columna)
        {
            int resp = 0;
            int referencia = this.renglones[0, columna].ValorPagoX;
            for (int i = 1; i < this.Filas; i++)
            {
                int valorActual = this.renglones[i, columna].ValorPagoX;

                if (valorActual > referencia)
                {
                    resp = i;
                    referencia = valorActual;
                }
            }

            return resp;

        }
    }
}
