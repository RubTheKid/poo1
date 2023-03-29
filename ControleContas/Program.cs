using ControleContas.Model;


Conta conta2 = new Conta("4321", 1000.99m);



//var contas = new List<Conta>
//{
//   new Conta("1234", 1244.34m),
//   new Conta("654321", 2341.42m),
//   new Conta("4040493", 19029.00m),
//   new Conta("09876543", 1000000.00m)
//};

//contas.ForEach(conta => Console.WriteLine($"Numero da conta: "+ conta.Numero + ", Saldo: " + conta.Saldo));

//Console.WriteLine("conta com maior saldo: " + conta2.ContaMaiorSaldo + " , com saldo: " + conta2.ValorMaiorSaldo);

var valorSaque = 1000.00m;
conta2.Saque(valorSaque);
Console.WriteLine($"valor do saque: {valorSaque}, saldo após operação: {conta2.Saldo}");

