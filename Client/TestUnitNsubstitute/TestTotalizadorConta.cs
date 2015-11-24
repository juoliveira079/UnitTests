using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Models;
using NSubstitute;

namespace TestUnitNsubstitute
{
    [TestClass]
    public class TestTotalizadorConta
    {
     
        [TestMethod]
        public void Total_Contas_Nsubstitute()
        {
            //Arrange
            var conta = Substitute.For<Conta>();
            var totalizador = Substitute.For<TotalizadorConta>();

            //Act
            double total = totalizador.ValorTotal + conta.saldo;
            totalizador.Soma(conta);

            //Assert

            Assert.AreEqual(totalizador.ValorTotal, total);
        }
    }
}
