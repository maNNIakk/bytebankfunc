using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebankfunc.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf, 5000)
        {
        }

        public override double GetBonus()
        {
            return this.Salario * 0.5;
        }


        public override void AumentarSalario()
        {
            this.Salario *= 1.15;
        }

        public string Senha {get;set;}
        public bool Autenticar(string senha)
        {
            return this.Senha == senha;
        }
    }
}