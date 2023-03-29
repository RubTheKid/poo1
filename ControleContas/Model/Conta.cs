namespace ControleContas.Model;

public class Conta
{

    private string _numero;
    private decimal _saldo;
    private static decimal _saldoTotal;
    private static string? _contaMaiorSaldo;
    private static decimal _maiorSaldo;
    private decimal _valorSaque;
    public Cliente Titular { get; set; }


    //Polimorfismo de sobrecarga
    public Conta(string numero)
    {
        _numero = numero;
    }

    public Conta(string numero, decimal saldo) 
    {
        _saldo = saldo;
        _numero = numero;
        _saldoTotal += saldo;
        if(_saldo > _maiorSaldo)
        {
            _maiorSaldo = _saldo;
            _contaMaiorSaldo = _numero;
        }
    }

    public string Numero {
        get => _numero; 
        private set => _numero = value; 
    }
    public decimal Saldo { 
        get => _saldo; 
        private set => _saldo = value; 
    }
    public decimal SaldoTotal { 
        get => _saldoTotal; 
        private set => _saldoTotal = value; 
    }

    public string ContaMaiorSaldo
    {
        get => _contaMaiorSaldo;
    }
    public decimal ValorMaiorSaldo
    {
        get => _maiorSaldo;
    }
    
    

    public void Deposito(decimal valor)
    {
        if (valor > 0) 
            Saldo += valor;
        else
            Console.WriteLine("Valor inválido");
    }
   
    public void Saque (decimal valor)
    {
        if (valor > Saldo)
            Console.WriteLine("saldo insuficiente");
        else
            Saldo -= valor;
    }
}
