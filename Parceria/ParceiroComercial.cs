using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using bytebankfunc.SistemaInterno;

namespace bytebankfunc.Parceria
{
    public class ParceiroComercial:IAutenticavel
    {
        public string Senha { get; set; }
        public string Login {get; set;}

        

        public bool Autenticar(string login,string senha)
        {
            return this.Senha == senha && this.Login == login;
        }
    }
}