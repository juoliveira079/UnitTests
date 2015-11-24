using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class TotalizadorConta
    {
        public double ValorTotal { get; private set; }

        public void Soma(Conta conta)
        {
            ValorTotal += conta.saldo;
        }
    }
}