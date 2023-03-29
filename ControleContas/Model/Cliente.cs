namespace ControleContas.Model;

public class Cliente
{
    public string? Nome { get; private set; }
    public string? Cpf { get; private set; }
    public int AnoNascimento { get; private set; }
    public string? IdConta { get; private set; }


public Cliente(string nome,
               string cpf,
               int anoNascimento)
    {
        if( cpf.Length != 11 ) 
            throw new ArgumentException($"{Nome}, CPF deve conter 11 digitos, sem pontos ou traços."); 
        
        if(DateTime.Now.Year - anoNascimento >= 18)
            throw new ArgumentException($"{Nome}, é preciso ter mais de 18 anos para abrir uma conta."); 

        Nome = nome;
        Cpf = cpf;
        AnoNascimento = anoNascimento; 
    }
}



