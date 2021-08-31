using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demostracao.Tests
{
    public class AssertingObjectTypesTests
    {
        [Fact]
        public void Funcionario_Criar_DeveRetornarTipoFuncionario()
        {
            // Arrange && Act
            var funcionario = FuncionarioFactory.Criar("Lorran", 2000);

            // Assert
            Assert.IsType<Funcionario>(funcionario);
        }
        [Fact]
        public void Funcionario_Criar_DeveRetornarTipoDerivadoPessoa()
        {
            // Arrange && Act
            var funcionario = new Funcionario(2000, "Lorran");

            //Assert
            Assert.Equal(typeof(Pessoa),funcionario.GetType().BaseType);
            Assert.IsAssignableFrom<Pessoa>(funcionario);
        }

    }
}
