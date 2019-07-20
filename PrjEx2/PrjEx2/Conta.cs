using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjEx2
{
    class Conta
    {

        public int numero ;
        public string titular;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo >= valor)
            {
                this.saldo = valor;
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
