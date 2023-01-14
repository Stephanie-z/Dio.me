using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa() {}
        
        public Pessoa(string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }
                
        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        private string _nome;
        private int _idade;
        
        // propriedade que representa o nome da pessoa
        public string Nome 
        { 
            // body expressions =>
            get => _nome.ToUpper();
            
            // body expression -> set => _nome = value;
            set
            {
                if(value == "")
                {
                    throw new ArgumentException("O nome não pode ser vazio.");
                }
                
                _nome = value;
            }
        }
        
        public string Sobrenome { get; set; }
        
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
        
        // propriedade que representa a idade da pesooa
        public int Idade 
        { 
            get => _idade;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("A idade não pode ser menor que zero.");
                }
                
                _idade = value;
            }
        }
        
        public void Apresentar()
        {
            Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
        }
    }
}