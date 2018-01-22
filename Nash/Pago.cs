using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nash
{
    public class Pago
    {
        private int valor;
        private bool esMaximo;
        public Pago(int valor)
        {
            this.valor = valor;
            this.esMaximo = false;
        }

        public int Valor { get => valor; }
        public bool EsMaximo { get => esMaximo; set => esMaximo = value; }
    }
}