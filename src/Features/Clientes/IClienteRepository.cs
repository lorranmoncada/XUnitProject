
using Features.Core;
using System;

namespace Features.Clientes
{
    public interface IClienteRepository: IRepository<Cliente>,IDisposable
    {
        Cliente ObterEmail(string email);
    }

}
