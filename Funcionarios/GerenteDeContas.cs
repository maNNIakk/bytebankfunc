using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.SistemaInterno;

namespace bytebankfunc.Funcionarios
{
    public class GerenteDeContas : FuncionarioAutenticavel
    {
        public GerenteDeContas(string cpf) : base(cpf, 4000)
        {

        }

        public override double GetBonus()
        {
            return this.Salario * 0.25;
        }

        public override void AumentarSalario()
        {
            this.Salario *= 1.05;
        }

}
}