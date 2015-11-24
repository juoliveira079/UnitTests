using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TestTotalizadorConta
    {
        [TestMethod]
        public void Total_Contas()
        {
            Fixture fixture = new Fixture();
            Conta   conta = fixture.Create<Conta>();
            TotalizadorConta totalizador = fixture.Create<TotalizadorConta>();

            //Act
            double total = totalizador.ValorTotal + conta.saldo;
            totalizador.Soma(conta);

            //Assert

            Assert.AreEqual(totalizador.ValorTotal, total);
        }

    }
}
