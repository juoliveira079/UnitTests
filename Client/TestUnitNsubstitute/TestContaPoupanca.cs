using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Client.Models;

namespace TestUnitNsubstitute
{
    [TestClass]
    public class TestContaPoupanca
    {

        [TestMethod]
        public void Conta_Poupanca_Saldo_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaPoupanca>();
            //Act
            conta.GetSaldo();

            // Assert
            Assert.AreEqual(conta.saldo, conta.GetSaldo());
           
        }

         [TestMethod]
        public void Conta_Poupanca_Deposito_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaPoupanca>();
            double valor = 100;

            //Act
            double deposito = conta.saldo + valor;
            //Act
            conta.Deposito(valor);

            //Assert
            Assert.AreEqual(conta.saldo, deposito);


        }
        [TestMethod]
         public void Conta_Poupanca_Saque_Nsubstitute()
         {
             //Arrange
             var conta = Substitute.For<ContaPoupanca>();
             double valor = 100;

             //Act
             double saque = conta.saldo - (valor + 0.10);
             //Act
             conta.Saque(valor);

             //Assert
             Assert.AreEqual(conta.saldo, saque);
         }

        [TestMethod]
        public void Conta_Poupanca_CalculaTributo_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaPoupanca>();

            double result = conta.CalculaTributo();

            Assert.AreEqual(conta.saldo, result);
        }

        [TestMethod]
        public void Conta_Poupanca_Coloca_Numero_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaPoupanca>();
            int num = 1000;
            conta.colocaNumero(num);

            Assert.AreEqual(conta.numero, num);
        }
    }
}
