using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demostracao.Tests
{
    public class AssertsStringsTest
    {
        [Fact]
        public void StringTools_NomeCompleto_RetornarNomeCompleto()
        {
            // Arrange
            var stringTools = new StringTools();

            // Action
            var nomeCompleto = stringTools.NomeCompleto("Lorran", "Moncada Mendes");

            // Assert
            Assert.Equal("Lorran Moncada Mendes", nomeCompleto);
        }

        [Fact]
        public void StringTools_NomeCompleto_IguinorarCase()
        {
            // Arrange
            var stringTools = new StringTools();

            // Action
            var nomeCompleto = stringTools.NomeCompleto("Lorran", "Moncada Mendes");

            // Assert
            Assert.Equal("LORRAN MONCADA MENDES", nomeCompleto, true);
        }

        [Fact]
        public void StringTools_NomeCompleto_DeveConterTrecho()
        {
            // Arrange
            var stringTools = new StringTools();

            // Action
            var nomeCompleto = stringTools.NomeCompleto("Lorran", "Moncada Mendes");

            // Assert
            Assert.Contains("endes", nomeCompleto);
        }

        [Fact]
        public void StringTools_NomeCompleto_DeveComecarCom()
        {
            // Arrange
            var stringTools = new StringTools();

            // Action
            var nomeCompleto = stringTools.NomeCompleto("Lorran", "Moncada Mendes");

            // Assert
            Assert.StartsWith("Lo", nomeCompleto);
        }

        [Fact]
        public void StringTools_NomeCompleto_DeveaAcabarCom()
        {
            // Arrange
            var stringTools = new StringTools();

            // Action
            var nomeCompleto = stringTools.NomeCompleto("Lorran", "Moncada Mendes");

            // Assert
            Assert.EndsWith("es", nomeCompleto);
        }

        [Fact]
        public void StringTools_NomeCompleto_ValidarExpressaoRegular()
        {
            // Arrange
            var stringTools = new StringTools();

            // Action
            var nomeCompleto = stringTools.NomeCompleto("Lorran", "Moncada Mendes");

            // Assert
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", nomeCompleto);
        }
    }
}
