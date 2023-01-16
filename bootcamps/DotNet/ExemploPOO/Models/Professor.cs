namespace ExemploPOO.Models
{
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
        }
        
        public Professor()
        {
        }
        
        public decimal Salario { get; set; }

        public sealed override void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, sou um professor de {Idade} anos de idade e ganho {Salario} reais.");
        }
    }
}
