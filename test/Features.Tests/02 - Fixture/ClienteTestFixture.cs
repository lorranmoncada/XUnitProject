using Features.Clientes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Features.Tests._02___Fixture
{
    [CollectionDefinition(nameof(ClienteCollection))]
    public class ClienteCollection: ICollectionFixture<ClienteTestFixture> { };
    public class ClienteTestFixture : IDisposable
    {

        public Cliente GerarClienteValido() =>
            new Cliente("Lorran", "Moncada", DateTime.Now.AddYears(-30), DateTime.Now, "Lorran@hotmail.com", true);

        public Cliente GerarClienteInvalido() =>
            new Cliente("Lorran", "Moncada", DateTime.Now.AddYears(-10), DateTime.Now, "Lorran@hotmail.com", true);

        public void Dispose()
        {
            // se usar banco em memoria pro exemplo destruiria ele aqui
        }
    }
}
