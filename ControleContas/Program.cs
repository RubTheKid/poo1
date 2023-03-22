
using ControleContas.Model;

//Conta conta = new Conta("1234");
//Conta conta2 = new Conta("4321", 1000.99m);
//Console.WriteLine($"Conta: {conta.Numero}; Saldo: {conta.Saldo}");
//Conta conta3 = new Conta("654321", 2341.42m);

//Console.WriteLine($"O saldo total é {conta2.SaldoTotal}");


var contas = new List<Conta>
{
   new Conta("1234", 1244.34m),
   new Conta("654321", 2341.42m)
};

contas.ForEach(conta => Console.WriteLine($"Numero da conta: "+ conta.Numero + ", Saldo: " + conta.Saldo));