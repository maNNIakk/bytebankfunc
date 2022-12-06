using bytebankfunc.Funcionarios;
using bytebankfunc.Parceria;
using bytebankfunc.SistemaInterno;
using bytebankfunc.Utilitario;
#region
// Funcionario pedro = new Funcionario("123456789", 2000);
// pedro.Nome = "Pedro Predo";

// System.Console.WriteLine(pedro.Nome);
// System.Console.WriteLine("Bonificação do Pedro: " + pedro.GetBonus());

// Diretor roberta = new Diretor("987654321");
// roberta.Nome = "Roberta Xerebecanto";

// System.Console.WriteLine(roberta.Nome);
// System.Console.WriteLine("Bonificação da Roberta: " + roberta.GetBonus());

// Auxiliar xablau = new Auxiliar("789654123");
// xablau.Nome = "Xablauzinho da Névoa";

// System.Console.WriteLine(xablau.Nome);
// System.Console.WriteLine("Bonificação do Xablau: " + xablau.GetBonus());

// Designer amanda = new Designer("123654789");
// amanda.Nome = "Amanda Marques";

// System.Console.WriteLine(amanda.Nome);
// System.Console.WriteLine("Bonificação da Amanda: " + amanda.GetBonus());

// GerenteDeContas renato = new GerenteDeContas("951357456");
// renato.Nome = "Renato Santos";

// System.Console.WriteLine(renato.Nome);
// System.Console.WriteLine("Bonificação do Renato: " + renato.GetBonus());



// GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(roberta);
// gerenciador.Registrar(xablau);
// gerenciador.Registrar(amanda);
// gerenciador.Registrar(renato);

// System.Console.WriteLine("Total de bonificações: " + gerenciador.TotalDeBonificacao);
// System.Console.WriteLine("Total de funcionários: " + Funcionario.TotalFuncionarios);

// pedro.AumentarSalario();
// roberta.AumentarSalario();
// xablau.AumentarSalario();
// amanda.AumentarSalario();
// renato.AumentarSalario();

// System.Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);
// System.Console.WriteLine("Novo salário da Roberta: " + roberta.Salario);
// System.Console.WriteLine("Novo salário do Xablau: " + xablau.Salario);
// System.Console.WriteLine("Novo salário da Amanda: " + amanda.Salario);
// System.Console.WriteLine("Novo salário do Renato: " + renato.Salario);
#endregion


UsarSistema();
void CalcularBonificao()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("456987123");
    ulisses.Nome = "Ulisses";

    Auxiliar ana = new Auxiliar("32456897");
    ana.Nome = "Ana";

    Diretor paulo = new Diretor("456897123");
    paulo.Nome = "Paulo";

    GerenteDeContas marcos = new GerenteDeContas("346521987");
    marcos.Nome = "Marcos";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(ana);
    gerenciador.Registrar(paulo);
    gerenciador.Registrar(marcos);

    System.Console.WriteLine("Total de Bonificaçao: " + gerenciador.TotalDeBonificacao);


}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("123654789");
    ingrid.Nome = "Ingrid Sharp";
    ingrid.Senha = "123";
    ingrid.Login = "indi";

    GerenteDeContas marquinho = new GerenteDeContas("321789654");
    marquinho.Nome = "Markin";
    marquinho.Senha = "987";
    marquinho.Login = "Markin";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Login = "Caiozin";
    caio.Senha = "123";


    sistema.Logar(ingrid,ingrid.Login,"123");
    sistema.Logar(marquinho,marquinho.Login,"789");
    sistema.Logar(caio,caio.Login,caio.Senha);
}