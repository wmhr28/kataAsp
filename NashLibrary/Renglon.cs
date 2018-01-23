using System;

namespace NashLibrary
{
    public class Renglon
    {
        private Pago pagoX;
        private Pago pagoY;

        public Renglon(int valorX, int valorY)
        {
            this.pagoX = new Pago(valorX);
            this.pagoY = new Pago(valorY);
        }

        public bool Equilibrio { get => PagoXEsMaximo && PagoYEsMaximo; }

        public bool PagoXEsMaximo { get => this.pagoX.EsMaximo; set => this.pagoX.EsMaximo = value; }

        public bool PagoYEsMaximo { get => this.pagoY.EsMaximo; set => this.pagoY.EsMaximo = value; }

        public int ValorPagoX { get => this.pagoX.Valor; }
        public int ValorPagoY { get => this.pagoY.Valor; }
        public string imprimir(string tipoPago)
        {
            string resp = "";
            if (tipoPago == "X")
            {
                resp += "<span style='color: blue;'>";
                resp += this.pagoX.imprimir();
            }
            if (tipoPago == "Y")
            {
                resp += "<span style='color: red;'>";
                resp += this.pagoY.imprimir();
            }            
            resp += "</span>";
            return resp;
        }
    }
}
