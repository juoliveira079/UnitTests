using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Client.Models;
using NSubstitute;

namespace TestUnitNsubstitute
{
    [TestClass]
    public class TestSeguroVida
    {
        [TestMethod]
        public void Teste_Seguro_Vidas_Calculo_Tributos()
        {
            //Arrange
            var seguro = Substitute.For<SeguroDeVida>();
            
            //Act
            double result = seguro.CalculaTributo();

            //Assert
            Assert.AreEqual(seguro.saldo, result);
           
        }
    }
}
