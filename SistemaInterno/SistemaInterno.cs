using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.Funcionarios;

namespace bytebankfunc.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema " + funcionario.Nome);
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta para o usuário " + funcionario.Nome);
                return false;
            }
        }

        public bool Logar(GerenteDeContas funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema " + funcionario.Nome);
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta para o usuário " + funcionario.Nome);
                return false;
            }
        }
    }
}