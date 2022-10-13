using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNet.Models
{
    public class Pessoa
    {
        private string Nome { get; set; }
        private int Idade { get; set; }

        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {GetNome()}, e tenho {GetIdade()} anos.");
        }

        public string GetNome()
        {
            return Nome;
        }
        public int GetIdade()
        {
            return Idade;
        }

        
    }
}