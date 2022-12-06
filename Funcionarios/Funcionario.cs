using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace bytebankfunc.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }
       
        public static int TotalFuncionarios { get; private set; }

        public abstract double GetBonus();

        public Funcionario(string cpf,int salario)
        {
            this.Cpf=cpf;
            this.Salario=salario;
            TotalFuncionarios++;
            // System.Console.WriteLine("Criando Funcionário");
        }

        public abstract void AumentarSalario();
    }
}