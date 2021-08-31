using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demostracao.Tests
{
    public class AssertingCollectionsTests
    {
        [Fact]
        public void Funcionario_Habilidades_NaoDevePossuirHabilidadesVazias()
        {
            //Arrange && Act
            var funcionario = new Funcionario(5000, "Lorran");
            //Assert
            Assert.All(funcionario.Habilidades,  habilidade => Assert.False(string.IsNullOrEmpty(habilidade)));
        }

        [Fact]
        public void Funcionario_Habilidades_Junior_deveConterHabilidadesBasicas()
        {
            //Arrange && Act
            var funcionario = new Funcionario(2000, "Lorran");

            var habilidades = new List<string>() { "Lógica de Programação", "Banco de Dados", "Devops" };
            //Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.Contains(habilidade, habilidades));
        }

        [Fact]
        public void Funcionario_Habilidades_Junior_deveConterHabilidadeDeLogica()
        {
            //Arrange && Act
            var funcionario = new Funcionario(2000, "Lorran");

            //Assert
            Assert.Contains("Lógica de Programação", funcionario.Habilidades);
        }

        [Fact]
        public void Funcionario_Habilidades_Junior_NaoDeveConterHabilidadesAvancadas()
        {
            //Arrange && Act
            var funcionario = new Funcionario(2000, "Lorran");
            var habilidadesAvancadas = new List<string>() { "Testes", "MicroServices" };

            //Assert
            Assert.All(funcionario.Habilidades, habilidade => Assert.DoesNotContain(habilidade, habilidadesAvancadas));
        }

        [Fact]
        public void Funcionario_Habilidades_SeniorDevePossuirTodasAsHabilidades()
        {
            //Arrange && Act
            var funcionario = new Funcionario(10000, "Lorran");
            var habilidades = new List<string>() { "Lógica de Programação", "Banco de Dados", "Devops", "Testes", "MicroServices" };

            //Assert
            Assert.Equal(habilidades,funcionario.Habilidades);
        }


    }
}
