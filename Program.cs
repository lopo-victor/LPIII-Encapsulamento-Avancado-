// See https://aka.ms/new-console-template for more information

using Ativ1;



ContaCorrente c1 = new ContaCorrente("antonio", 19287, 2128,1234);

c1.infConta();

c1.DepositoCC();
Console.WriteLine("saldo atual: "+c1.Saldo);

c1.SaqueCC();
Console.WriteLine("saldo atual: "+c1.Saldo);

c1.revelaSenha();
c1.ReceberSenhaCC();
Console.WriteLine(c1.AcessoRemoto);
