namespace ExemploPOO.Models
{
    public class Aluno : Pessoa
    {
       public Aluno(string nome) : base(nome)
       {
       }
        
       public Aluno()
       {
       }
        
       public double Nota { get; set; }

       public override void Apresentar()
       {
           Console.WriteLine($"Olá, meu nome é {Nome}, tenho {Idade} anos, e sou um aluno nota {Nota}");
       }
    }
}
