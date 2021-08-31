using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Core
{
    public abstract class Entity
    {
        public Guid Id { get; private set; }

        public ValidationResult ValidationResult { get; protected set; }

        public Entity()
        {
            Id = Guid.NewGuid();
        }

        public abstract bool EhValido();
    }
}
