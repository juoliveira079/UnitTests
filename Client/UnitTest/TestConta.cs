using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TestConta
    {
        [TestMethod]
        public void Conta_Saldo()
        {
            //Arrange

            Fixture fixture = new Fixture();
            Conta conta = fixture.Create<Conta>();

            // Act
            double result = conta.GetSaldo();

            //Assert
            Assert.AreEqual(result,conta.saldo);
        }
        
        [TestMethod]
        public void Conta_Saque()
        {
            //Arrange
            Fixture fixture = new Fixture();
            Conta conta = fixture.Create<Conta>();
            double valor = 100;
           
            //Act
            
            double saque = conta.saldo - valor;
            conta.Saque(valor);
           
            //Assert

            Assert.AreEqual(conta.saldo, saque);

        }

        [TestMethod]
        public void Conta_Deposito()
        {
            //Arrange
            Fixture fixture = new Fixture();
            Conta conta = fixture.Create<Conta>();
            double valor = 100;
           
            //Act
            double deposito = conta.saldo + valor;
            conta.Deposito(valor);


            //Assert
            Assert.AreEqual(conta.saldo, deposito);
        }

        [TestMethod]
        public void Conta_Numero()
        {
            //Arrange
            Fixture fixture = new Fixture();
            Conta   conta   = fixture.Create<Conta>();
            int     numero  = fixture.Create<int>();

            //Act
            conta.colocaNumero(numero);

            //Assert
            Assert.AreEqual(conta.numero, numero);

        }
    }
}
