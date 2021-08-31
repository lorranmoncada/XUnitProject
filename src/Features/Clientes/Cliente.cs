using Features.Core;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features.Clientes
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        public string SobreNome { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public string Email { get; private set; }
        public bool Ativo { get; private set; }

        public Cliente(string nome, string sobreNome, DateTime dataNascimento, DateTime dataCadastro, string email, bool ativo)
        {
            Nome = nome;
            SobreNome = sobreNome;
            DataNascimento = dataNascimento;
            DataCadastro = DateTime.Now;
            Email = email;
            Ativo = ativo;
        }

        public bool EhEspecial() => DataCadastro < DateTime.Now.AddYears(-3) && Ativo;

        public string NomeCompleto() => $"{Nome} {SobreNome}";

        public void Inativar() => Ativo = false;

        public override bool EhValido()
        {
            ValidationResult =  new ClienteValidacao().Validate(this);
            return ValidationResult.IsValid;
        }
    }

    public class ClienteValidacao : AbstractValidator<Cliente>
    {
        public ClienteValidacao()
        {
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("Nome obrigatório")
                .Length(2, 150).WithMessage("Nome deve ter entre 2 e 150 caracteres");

            RuleFor(c => c.SobreNome)
                .NotEmpty().WithMessage("Nome obrigatório")
                .Length(2, 150).WithMessage("Sobrenome deve ter entre 2 e 150 caracteres");

            RuleFor(c => c.DataNascimento)
               .NotEmpty().WithMessage("Data cadastro é obrigatório")
               .Must(EhMaiorIdade).WithMessage("Cliente deve ter 18 anos ou mais");

            RuleFor(c => c.Email)
              .NotEmpty().WithMessage("E-mail é obrigatório")
              .EmailAddress().WithMessage("E-mail esta com formato inválido");

            RuleFor(c => c.Id)
             .NotEmpty().WithMessage("Id é obrigatório")
             .NotEqual(Guid.Empty).WithMessage("Id é obrigatório");

        }

        private bool EhMaiorIdade(DateTime dataNascimento) =>
            dataNascimento <= DateTime.Now.AddYears(-18);

    }
}
