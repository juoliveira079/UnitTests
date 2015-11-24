using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TestContaPoupanca
    {
        [TestMethod]
        public void Conta_Poupanca_Saldo()
        {
            //Arrange

            Fixture fixture = new Fixture();
            ContaPoupanca conta = fixture.Create<ContaPoupanca>();

            // Act
            double result = conta.GetSaldo();

            //Assert
            Assert.AreEqual(result, conta.saldo);
        }

        [TestMethod]
        public void Conta_Saque_Conta_Poupanca()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaPoupanca conta = fixture.Create<ContaPoupanca>();
            double valor = 100;

            //Act
            double saque = conta.saldo - (valor + 0.10);
            conta.Saque(valor);


            //Assert
            Assert.AreEqual(conta.saldo, saque);

        }

        [TestMethod]
        public void Conta_Poupanca_Deposito()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaPoupanca conta = fixture.Create<ContaPoupanca>();
            double valor = 100;

            //Act
            double deposito = conta.saldo + valor;
            conta.Deposito(valor);

            //Assert
            Assert.AreEqual(conta.saldo, deposito);
        }

        [TestMethod]
        public void Conta_Poupanca_Numero()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaPoupanca conta = fixture.Create<ContaPoupanca>();
            int numero = fixture.Create<int>();

            //Act
            conta.colocaNumero(numero);

            //Assert
            Assert.AreEqual(conta.numero, numero);

        }
        [TestMethod]

        public void Conta_Poupanca_Calcular_Tributo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaPoupanca conta = fixture.Create<ContaPoupanca>();

            //Act
            double saldo = conta.saldo * 0.02;

            conta.CalculaTributo();

            Assert.AreEqual(conta.saldo, saldo);

        }
    }
}
