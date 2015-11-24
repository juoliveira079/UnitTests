﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Client.Models
{
    public class Conta
    {
        public int numero { get; set; }
        public double saldo { get; protected set; }
        public Cliente titular { get; set; }
        

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
    }
}