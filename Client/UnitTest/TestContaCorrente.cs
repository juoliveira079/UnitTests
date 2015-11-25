using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TestContaCorrente
    {
        [TestMethod]
        public void Teste_Conta_Saldo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaCorrente conta = fixture.Create<ContaCorrente>();

            // Act
            double result = conta.GetSaldo();

            //Assert
            Assert.AreEqual(result,conta.saldo);
        }
        
        [TestMethod]
        public void Teste_Conta_Saque_Valor_Maior_Saldo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaCorrente conta = fixture.Create<ContaCorrente>();
            double valor = 100;
           
            //Act

            double saque = conta.saldo - (valor + 0.10);
            conta.Saque(valor);
           
            //Assert

            Assert.AreEqual(conta.saldo, saque);

        }
        [TestMethod]
        public void Teste_Conta_Saque_Valor_Menor_Saldo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaCorrente conta = fixture.Create<ContaCorrente>();
            double valor = -0.1;

            //Act

            double saque = conta.saldo - valor;
            conta.Saque(valor);

            //Assert

            Assert.AreEqual(conta.saldo, saque);
        }

        [TestMethod]
        public void Teste_Conta_Deposito()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaCorrente conta = fixture.Create<ContaCorrente>();
            double valor = 100;
           
            //Act
            double deposito = conta.saldo + valor;
            conta.Deposito(valor);

            //Assert
            Assert.AreEqual(conta.saldo, deposito);
        }

        [TestMethod]
        public void Teste_Conta_Numero()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaCorrente   conta   = fixture.Create<ContaCorrente>();
            int  numero  = fixture.Create<int>();

            //Act
            conta.colocaNumero(numero);

            //Assert
            Assert.AreEqual(conta.numero, numero);

        }

        [TestMethod]
        public void Teste_Conta_Proxima()
        {
            //Arrange
            Fixture fixture = new Fixture();

            //Act
            int result = ContaCorrente.ProximaConta();

            //Assert
           Assert.AreEqual(ContaCorrente.totalDeContas + 1, result);
        }
    }
}
