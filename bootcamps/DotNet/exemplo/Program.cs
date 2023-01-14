DotNet.Models.Pessoa pessoa1 = new DotNet.Models.Pessoa("Duda", 23);
pessoa1.Apresentar();

string apresentacao = "Olá, seja bem vindo";
int quantidade = 1;
double altura = 1.80;
decimal preco = 1.80M;
bool condicao = true;

Console.WriteLine(apresentacao);
Console.WriteLine($"Valor da variável quantidade: {quantidade}");
Console.WriteLine("Valor da variável altura: " + altura);
Console.WriteLine("Valor da variável preco: " + preco);
Console.WriteLine("Valor da variável condicao: " + condicao);

DotNet.Models.Calculadora calc = new DotNet.Models.Calculadora();
calc.Somar(4,4);
calc.Subtrair(4,2);
calc.Multiplicar(4,4);
calc.Dividir(16,4);
calc.Potencia(2,3);
calc.RaizQuadrada(25);
calc.Seno(30);
calc.Cosseno(30);
calc.Tangente(30);
