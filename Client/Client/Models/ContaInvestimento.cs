using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class ContaInvestimento:Conta
    {
        public double CalculaTributo()
        {
            return this.saldo * 0.03;
        }
    }
}