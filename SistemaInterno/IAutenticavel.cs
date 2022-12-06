using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.Funcionarios;

namespace bytebankfunc.SistemaInterno
{
    public interface IAutenticavel
    {
        public string Senha {get;set;}
        public string Login {get;set;}
        public bool Autenticar(string login,string senha);
    }
}