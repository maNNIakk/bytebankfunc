using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebankfunc.Funcionarios
{
    public class Designer : Funcionario
    {
        public Designer(string cpf) : base(cpf, 3000)
        {
        }

        public override double GetBonus()
        {
            return this.Salario * 0.15;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.10;
        }
    }
}