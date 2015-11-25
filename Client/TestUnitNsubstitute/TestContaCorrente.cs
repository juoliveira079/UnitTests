using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Models;
using NSubstitute;

namespace TestUnitNsubstitute
{
    [TestClass]
    public class TestContaCorrente
    {
         [TestMethod]
        public void Conta_Corrente_GetSaldo_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaCorrente>();

            //Act
            double result = conta.GetSaldo();

            //Assert
            Assert.AreEqual(conta.saldo,result);
        }

        [TestMethod]
        public void Conta_Corrente_Deposito_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaCorrente>();
            double valor = 1000;

            //Act
            double deposito = conta.saldo + valor;
            conta.Deposito(valor);

            //Assert
            Assert.AreEqual(conta.saldo, deposito);
            
        }

        [TestMethod]
        public void Conta_Corrente_Saque_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaCorrente>();
            double valor = 1000;

            //Act
            double saque = conta.saldo - (valor + 0.10);
            conta.Saque(valor);

            //Assert
            Assert.AreEqual(conta.saldo, saque);

        }

        [TestMethod]
        public void Conta_Corrente_Numero_Nsubstitute()
        {
            //Arrange 
            var conta = Substitute.For<ContaCorrente>();
            int num = 10;

            // Act
            conta.colocaNumero(num);
            //Assert
            Assert.AreEqual(conta.numero, num);

        }
    }
}
