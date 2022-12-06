using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.Funcionarios;
using bytebankfunc.Parceria;

namespace bytebankfunc.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario,string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login,senha);
            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema " + funcionario.Login);
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta para o usuário " + funcionario.Login);
                return false;
            }
        }

        public bool Logar(ParceiroComercial funcionario,string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login,senha);
            if (usuarioAutenticado)
            {
                System.Console.WriteLine("Boas vindas ao nosso sistema " + funcionario.Login);
                return true;
            }
            else
            {
                System.Console.WriteLine("Senha incorreta para o usuário " + funcionario.Login);
                return false;
            }
        }
    }
}