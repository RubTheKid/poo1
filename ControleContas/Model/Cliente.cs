using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleContas.Model
{
    public class Cliente
    {
        public string? Nome { get; private set; }
        public string? Cpf { get; private set; }
        public int AnoNascimento { get; private set; }
        public string? IdConta { get; private set; }
    }

    public Cliente(string Nome, string Cpf, int AnoNascimento)
        {
            Nome = Nome;

            if( Cpf.Length == 11 ){ Cpf = Cpf; }
            else { Console.WriteLine( $"{Nome}, CPF deve conter 11 digitos"); }
            
            if(DateTime.Now.Year - AnoNascimento >= 18) { AnoNascimento = AnoNascimento; }
            else { Console.WriteLine($"{Nome}, é preciso ter mais de 18 anos para abrir uma conta."); }
        }

        
        //public Cliente()
        //{

        //}
    }

