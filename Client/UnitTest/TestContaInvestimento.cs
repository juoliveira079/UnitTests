using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TestContaInvestimento
    {
        [TestMethod]
        public void Teste_Conta_Investimento_GetSaldo()
        {
            //Arrange

            Fixture fixture = new Fixture();
            ContaInvestimento conta = fixture.Create<ContaInvestimento>();
            
            // Act
            double result = conta.GetSaldo();

            //Assert
            Assert.AreEqual(result, conta.saldo);
        }

        [TestMethod]
        public void Teste_Conta_Investimento_Deposito()
        {
            //Arrange

            Fixture fixture = new Fixture();
            ContaInvestimento conta = fixture.Create<ContaInvestimento>();
            double valor = 100;

            //Act
            double deposito = conta.saldo + valor;
            conta.Deposito(valor);

            //Assert
            Assert.AreEqual(conta.saldo, deposito);

        }

        [TestMethod]
        public void Teste_Conta_Investimento_Saque_Maior_Saldo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaInvestimento conta = fixture.Create<ContaInvestimento>();
            double valor = 1000;

            //Act
            double saque = conta.saldo - (valor + 0.10);
            conta.Saque(valor);

            //Assert
            Assert.AreEqual(conta.saldo, saque);
        }


        [TestMethod]
        public void Teste_Conta_Investimento_Saque_Menor_Saldo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaInvestimento conta = fixture.Create<ContaInvestimento>();
            double valor = -0.1;

            //Act
            double saque = conta.saldo - valor;
            conta.Saque(valor);

            //Assert
            Assert.AreEqual(conta.saldo, saque);
        }

        [TestMethod]
        public void Teste_Conta_Investimento_Calculo_Atributo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaInvestimento conta = fixture.Create<ContaInvestimento>();

            //Act
            double result = conta.CalculaTributo();

            //Assert
            Assert.AreEqual(conta.saldo, result);

        }

        [TestMethod]
        public void Teste_Conta_Investimento_Coloca_Numero()
        {
            //Arrange
            Fixture fixture = new Fixture();
            ContaInvestimento conta = fixture.Create<ContaInvestimento>();
            int numero = fixture.Create<int>();

            //Act
            conta.colocaNumero(numero);

            //Assert
            Assert.AreEqual(conta.numero, numero);
        }
    }
}
