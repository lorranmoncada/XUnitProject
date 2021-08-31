using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demostracao
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Apelido { get; set; }
    }

    public enum NivelProfissional
    {
        Junior = 0,
        Senior = 3,
        Pleno = 2
    }

    public class Funcionario : Pessoa
    {
        public double Salario { get; set; }
        public NivelProfissional NivelProfissional { get; set; }
        public List<string> Habilidades { get; set; }
        public Funcionario(double salario, string nome)
        {

            if (string.IsNullOrWhiteSpace(nome))
            {
                Apelido = "Fulano";
                Nome = "Sem nome";
            }
            else
            {
                Nome = nome;
            }
            DefinirSalario(salario);
            DefinirHabilidades();
        }

        private void DefinirSalario(double salario)
        {
            if (salario < 500) throw new Exception("Salário abaxo do permitido");

            if (salario <= 2000)
            {
                NivelProfissional = NivelProfissional.Junior;
            }
            else if (salario > 2000 && salario <= 8000)
            {
                NivelProfissional = NivelProfissional.Pleno;
            }
            else
            {
                NivelProfissional = NivelProfissional.Senior;
            }


            Salario = salario;
        }

        private void DefinirHabilidades()
        {
            Habilidades = new List<string>() { "Lógica de Programação", "Banco de Dados", "Devops" };

            switch (NivelProfissional)
            {
                case NivelProfissional.Senior:
                    Habilidades.Add("Testes");
                    Habilidades.Add("MicroServices");
                    break;
                case NivelProfissional.Pleno:
                    Habilidades.Add("Testes");
                    break;
                default:
                    break;
            }
        }
    }

    public static class FuncionarioFactory
    {
        public static Funcionario Criar(string nome, double salario)
        {
            return new Funcionario(salario, nome);
        }
    }
}
