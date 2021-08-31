using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demostracao.Tests
{
    public class AssertExceptionTests
    {

        [Fact]
        public void Calculadora_Dividir_RetornarErroAoDividirPorZero()
        {
            //Arrange && Act
            var calculadora = new Calculadora();

            //Assert
            Assert.Throws<DividirByZeroException>(() => calculadora.Dividir(0, 1));
        }
        [Fact]
        public void Calculadora_Dividir_RetornarErroAoDividirPorZeroVerificandoMenssagem()
        {
            //Arrange && Act
            var calculadora = new Calculadora();

            //Assert
            var exception = Assert.Throws<DividirByZeroException>(() => calculadora.Dividir(0, 1));
            Assert.Equal("Não é possível dividir valor por zero!", exception.Message);
        }
    }
}
