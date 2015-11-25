using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ploeh.AutoFixture;
using Client.Models;

namespace UnitTest
{
    [TestClass]
    public class TesteCliente
    {
        [TestMethod]
        public void Teste_Verifica_Clientes_Diferentes()
        {
            //Arrange
            Fixture fixture = new Fixture();
            Cliente cliente = fixture.Create<Cliente>();
            Cliente cliente1 = fixture.Create<Cliente>();

            //Act
            bool result = cliente.Equals(cliente1);

            //Assert
            Assert.IsFalse(result);

        }

        [TestMethod]
        public void Teste_Verifica_Clientes_Iguais()
        {
            //Arrange
            Fixture fixture = new Fixture();
            Cliente cliente = fixture.Create<Cliente>();

            //Act
            bool result = cliente.Equals(cliente);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
