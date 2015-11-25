using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Models;
using NSubstitute;
using Client;

namespace TestUnitNsubstitute
{
    [TestClass]
    public class TestTotalizadorConta
    {
     
        [TestMethod]
        public void Teste_Acumulo_Conta_Nsubstitute()
        {
            //Arrange
            var tributo = Substitute.For<Itributavel>();
            var totalizador = Substitute.For<TotalizadorConta>();

            //Act
            double total = totalizador.Total + tributo.CalculaTributo();
            totalizador.Acumula(tributo);

            //Assert
            Assert.AreEqual(totalizador.Total, total);
        }
    }
}
