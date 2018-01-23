using System;

namespace NashLibrary
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

        public string imprimir()
        {
            string resp = "";
            if (esMaximo)
            {
                resp += "<u><b>" + this.Valor + "</b></u>";
            }
            else
            {
                resp += this.Valor + "";
            }
            return resp;
        }
    }
}