using MediatR;
using System.Collections.Generic;

namespace Features.Clientes
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IMediator _mediator;

        public ClienteService(IClienteRepository clienteRepository, IMediator mediator)
        {
            _clienteRepository = clienteRepository;
            _mediator = mediator;
        }

        public void Adicionar(Cliente cliente)
        {
            _clienteRepository.Adicionar(cliente);
        }

        public void Atualizar(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Cliente> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public void Inativar(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Remover(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Dispose()
        {
            _clienteRepository.Dispose();
        }
    }

}
