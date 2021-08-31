using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demostracao.Tests
{
    public class AssertingRangesTests
    {
        [Theory]
        [InlineData(700)]
        [InlineData(1500)]
        [InlineData(2000)]
        [InlineData(7500)]
        [InlineData(8001)]
        [InlineData(15000)]
        public void Funcionario_Salario_FaixaSalarialDevemRespeitarNivelProfissional(double salario)
        {
            //Arrange & Act
            var funcionario = new Funcionario(salario, "Lorran");

            //Assert
            if (funcionario.NivelProfissional == NivelProfissional.Junior)
                Assert.InRange(funcionario.Salario, 500, 2000);

            if (funcionario.NivelProfissional == NivelProfissional.Pleno)
                Assert.InRange(funcionario.Salario, 2001, 8000);

            if (funcionario.NivelProfissional == NivelProfissional.Senior)
                Assert.InRange(funcionario.Salario, 8001, double.MaxValue);

            Assert.NotInRange(funcionario.Salario, 0, 499);
        }
    }
}
