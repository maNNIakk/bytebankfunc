using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.Funcionarios;

namespace bytebankfunc.Utilitario
{
    public class GerenciadorDeBonificacao
    {
        public double TotalDeBonificacao { get; private set; }

        public void  Registrar(Funcionario funcionario)
        {
            this.TotalDeBonificacao += funcionario.GetBonus();
        }
    }
}