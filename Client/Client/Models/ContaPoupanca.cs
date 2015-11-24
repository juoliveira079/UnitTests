using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class ContaPoupanca : Conta
    {
        public void Saque(double valor)
        {
            this.saldo -= (valor + 0.10);
        }
        public double CalculaTributo()
        {
            return this.saldo * 0.02;
        }
    }
}