using System;
using System.Collections.Generic;

namespace Features.Core
{
    public interface IRepository<T> where T : Entity
    {
        IEnumerable<T> GetAll();
        void Adicionar(T cliente);
        void Remover(T cliente);
        void Atualizar(T cliente);
        void Inativar(T cliente);
    }
}
