using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TestSeguroVida
    {
        [TestMethod]
        public void Teste_Seguro_Vida_Calculo_Atributo()
        {
            //Arrange
            Fixture fixture = new Fixture();
            SeguroDeVida seguro = fixture.Create<SeguroDeVida>();

            //Act
            double result = seguro.CalculaTributo();

            //Assert
            Assert.AreEqual(seguro.saldo, result);
        }
    }
}
