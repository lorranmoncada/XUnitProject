using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demostracao.Tests
{
    public class FuncionarioTest
    {
        [Fact]
        public void Funcionario_Nome_NaoDeveSerNulo()
        {
            // Arrange & Act
            var funcionario = new Funcionario(1000, "");

            //Assert
            Assert.False(string.IsNullOrEmpty(funcionario.Nome));
        }

        [Fact]
        public void Funcionario_Nome_NaoDeveTerApelido()
        {
            // Arrange & Act
            var funcionario = new Funcionario(13000, "Lorran");

            //Assert
            Assert.NotEqual("Apelido", funcionario.Nome);
        }
    }
}
