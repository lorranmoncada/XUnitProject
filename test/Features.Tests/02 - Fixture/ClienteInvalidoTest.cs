using Xunit;

namespace Features.Tests._02___Fixture
{
    [Collection(nameof(ClienteCollection))]
    public class ClienteFixtureTests
    {
        private readonly ClienteTestFixture _clienteTestFixture;

        public ClienteFixtureTests(ClienteTestFixture clienteTestFixture)
        {
            _clienteTestFixture = clienteTestFixture;
        }

        [Fact(DisplayName = "Cliente Menor de idade usando Fixture")]
        [Trait("Categoria", "Cliente Fixture")]
        public void Cliente_Cadastrar_VerificaMensagemClienteMenorDeIdade()
        {
            // Arrange
            var cliente = _clienteTestFixture.GerarClienteInvalido();

            //Act
            var ehValido = cliente.EhValido();

            //Assert
            Assert.False(ehValido);
            Assert.Equal("Cliente deve ter 18 anos ou mais", cliente.ValidationResult.Errors[0].ErrorMessage);
        }
    }
}
