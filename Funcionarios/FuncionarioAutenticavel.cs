using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.SistemaInterno;

namespace bytebankfunc.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        protected FuncionarioAutenticavel(string cpf, int salario) : base(cpf, salario)
        {
        }

        public string Senha { get; set; }
        public string Login { get; set; }

        public bool Autenticar(string login, string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}