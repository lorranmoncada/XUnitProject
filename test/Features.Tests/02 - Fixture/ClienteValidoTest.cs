using Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Features.Tests._02___Fixture
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteValidoTest
    {
        private readonly ClienteTestFixture _clienteTestFixture;

        public ClienteValidoTest(ClienteTestFixture clienteTestFixture)
        {
            _clienteTestFixture = clienteTestFixture;
        }

        [Fact(DisplayName = "Cliente Válido Usando Fixture")]
        [Trait("Categoria", "Cliente Fixture")]
        public void Cliente_Cadastrar_ClienteDeveSerValido()
        {
            // Arrange
            var cliente = _clienteTestFixture.GerarClienteValido();

            //Act
            var ehValido = cliente.EhValido();

            //Assert
            Assert.True(ehValido);
            Assert.Empty(cliente.ValidationResult.Errors);
        }       
    }
}
