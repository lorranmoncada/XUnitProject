using Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Features.Tests._01___Traits
{
    public class ClienteTests
    {
        [Fact(DisplayName = "Cliente Válido")]
        [Trait("Categoria","Cliente")]
        public void Cliente_Cadastrar_ClienteDeveSerValido()
        {
            // Arrange
            var cliente = new Cliente(
                "Lorran",
                "Moncada",
                DateTime.Now.AddYears(-30),
                DateTime.Now,
                "Lorran@hotmail.com",
                true);

            //Act
            var ehValido = cliente.EhValido();

            //Assert
            Assert.True(ehValido);
            Assert.Empty(cliente.ValidationResult.Errors);
        }

        [Fact(DisplayName = "Cliente Menor de Idade")]
        [Trait("Categoria", "Cliente")]
        public void Cliente_Cadastrar_VerificaMensagemClienteMenorDeIdade()
        {
            // Arrange
            var cliente = new Cliente(
                "Lorran",
                "Moncada",
                DateTime.Now.AddYears(-10),
                DateTime.Now,
                "Lorran@hotmail.com",
                true);

            //Act
            var ehValido = cliente.EhValido();

            //Assert
            Assert.False(ehValido);
            Assert.Equal("Cliente deve ter 18 anos ou mais", cliente.ValidationResult.Errors[0].ErrorMessage);
        }
    }
}
