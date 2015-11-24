using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class ContaCorrente
    {
        public int numero { get; set; }
        public double saldo { get; protected set; }
        public Cliente titular { get; set; }
        public static  int totalDeContas = 0;

        public ContaCorrente()
        {
            ContaCorrente.totalDeContas++;
        }

        public static int ProximaConta()
        {
            return ContaCorrente.totalDeContas + 1;
        }
       
        public void Saque(double valor)
        {
            
           this.saldo -= valor;

        }
        public void Deposito( double valor)
        {
            this.saldo += valor;
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public void colocaNumero(int numero)
        {
            this.numero = numero;
        }

        public double CalculaTributo()
        {
            return this.saldo * 0.02;
        }
    }
}