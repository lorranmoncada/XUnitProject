using System;
using Xunit;

namespace Demostracao.Tests
{
    public class CalculadoraTest
    {
        [Fact]
        public void RetornarSomaDEDoisValores()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Somar(1,4);

            //Assert
            Assert.Equal(5, result);
        }

        [Theory]
        [InlineData(1,1,2)]
        [InlineData(2, 5, 7)]
        [InlineData(10, 1, 11)]
        [InlineData(18, 1, 19)]
        public void RetornarSomaDosValoresCorretamente(int v1, int v2, int total)
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Somar(v1, v2);

            //Assert
            Assert.Equal(total, result);
        }

        [Fact]
        public void Calculadora_Somar_SomaNaoDeveSerIgual()
        {
            //Arrange
            var calculadora = new Calculadora();

            //Act
            var result = calculadora.Somar(1.131231123123, 2.2312313123);
            //var teste  = Math.Round(result, 1);
            //Assert
            Assert.NotEqual(3.6, result, 1);
        }

    }
}
