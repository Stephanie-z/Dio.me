using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;



int numero = 20;
bool par = false;

//par = numero % 2 == 0;
par = numero.EhPar();

string mensagem = "O número " + numero + " é " + (par ? "par" : "ímpar");

Console.WriteLine(mensagem);


/*
MeuArray<int> arrayInteiro = new MeuArray<int>();
arrayInteiro.AdicionarElementoArray(30);
Console.WriteLine($"Elemento: {arrayInteiro[0]}");

MeuArray<string> arrayString = new MeuArray<string>();
arrayString.AdicionarElementoArray("Teste");
Console.WriteLine($"Elemento: {arrayString[0]}");
*/

/*
dynamic variavelDinamica = 4;

Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = "Texto";
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

variavelDinamica = 1.70M;
Console.WriteLine($"Tipo da variável: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");
*/
/*
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);
var listaAnonimo = listaVenda.Select(x => new {x.Produto, x.Preco});

foreach(var venda in listaAnonimo)
{
    Console.WriteLine($"Produto: {venda.Produto}, Preço : {venda.Preco}");
}
*/

/*
var tipoAnonimo = new {Nome = "John", Sobrenome = "Carlos", Altura = 1.63};

Console.WriteLine($"Nome: {tipoAnonimo.Nome}\nSobrenome: {tipoAnonimo.Sobrenome}\nAltura: {tipoAnonimo.Altura}");
*/
/*
string conteudoArquivo = File.ReadAllText("Arquivos/vendas.json");
List<Venda> listaVenda = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

foreach(Venda venda in listaVenda)
{
    Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " + 
                      $"Preço: {venda.Preco}, " + 
                      $"Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}" +
                      $"{(venda.Desconto.HasValue ? $", Desconto: {venda.Desconto}" : "")}");
}

*/


/*
DateTime dataAtual = DateTime.Now;

List<Venda> listaVendas = new List<Venda>();

Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);
Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

listaVendas.Add(v1);
listaVendas.Add(v2);

string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

File.WriteAllText("Arquivos/vendas.json", serializado);

Console.WriteLine(serializado);
*/

//new ExemploExcecao().Metodo1();

/*
try
{
    string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");
    foreach(string linha in linhas)
    {
        Console.WriteLine(linha);
    }
} 
catch(FileNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
}
catch(DirectoryNotFoundException ex)
{
    Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
}
catch(Exception ex)
{
    Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}

Console.WriteLine("Chegou até aqui.");
*/

/*
string dataString = "2022-04-17 18:00";

bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

if(sucesso)
{
    Console.WriteLine($"Conversão com sucesso! Data: {data}");
} 
else 
{
    Console.WriteLine($"{dataString} não é uma data válida.");
}
*/
/*
CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

decimal valorMonetario = 1482.40M;

Console.WriteLine(valorMonetario.ToString("N2"));

double porcentagem = .3421;

Console.WriteLine(porcentagem.ToString("P"));

int numero = 123456;

Console.WriteLine(numero.ToString("##-##-##"));
*/
/*
Pessoa p1 = new Pessoa(nome: "Stephanie", sobenome: "Santos", idade: 23);
//p1.Apresentar();

Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Neves Queiroz");

Curso cursoDeIngles = new Curso("Inglês");

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);

cursoDeIngles.ListarAlunos();

*/