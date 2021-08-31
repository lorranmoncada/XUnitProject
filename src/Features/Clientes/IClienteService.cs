using System;
using System.Collections.Generic;

namespace Features.Clientes
{
    public interface IClienteService : IDisposable
    {
        IEnumerable<Cliente> GetAll();
        void Adicionar(Cliente cliente);
        void Remover(Cliente cliente);
        void Atualizar(Cliente cliente);
        void Inativar(Cliente cliente);
    }

}
