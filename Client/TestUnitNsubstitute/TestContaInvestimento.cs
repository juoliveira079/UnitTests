using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using Client.Models;

namespace TestUnitNsubstitute
{
    [TestClass]
    public class TestContaInvestimento
    {
        [TestMethod]
        public void Conta_Investimento_GetSaldo_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaInvestimento>();

            //Act
            double result = conta.GetSaldo();

            //Assert
            Assert.AreEqual(conta.saldo,result);
        }

        [TestMethod]
        public void Conta_Investimento_Deposito_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaInvestimento>();
            double valor = 1000;

            //Act
            double deposito = conta.saldo + valor;
            conta.Deposito(valor);

            //Assert
            Assert.AreEqual(conta.saldo, deposito);
            
        }

        [TestMethod]
        public void Conta_Investimento_Saque_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<ContaInvestimento>();
            double valor = 1000;

            //Act
            double saque = conta.saldo - valor;
            conta.Saque(valor);

            //Assert
            Assert.AreEqual(conta.saldo, saque);

        }

        [TestMethod]
        public void Conta_Investimento_Numero_Nsubstitute()
        {
            //Arrange 
            var conta = Substitute.For<ContaInvestimento>();
            int num = 10;

            // Act
            conta.colocaNumero(num);
            //Assert
            Assert.AreEqual(conta.numero, num);

        }
    }
}
