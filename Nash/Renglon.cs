using System;
using System.Collections.Generic;
using System.Text;

namespace Nash
{
    public class Renglon
    {
        private Pago pagoX;
        private Pago pagoY; 

        public Renglon(int valorX, int valorY) {
            this.pagoX = new Pago(valorX);
            this.pagoY = new Pago(valorY); 
        }

        public bool Equilibrio { get => PagoXEsMaximo && PagoYEsMaximo; }

        public bool PagoXEsMaximo { get => this.pagoX.EsMaximo; set => this.pagoX.EsMaximo = value; }

        public bool PagoYEsMaximo { get => this.pagoY.EsMaximo; set => this.pagoY.EsMaximo = value; }

        public int ValorPagoX { get => this.pagoX.Valor; }
        public int ValorPagoY { get => this.pagoY.Valor; }
    }
}
