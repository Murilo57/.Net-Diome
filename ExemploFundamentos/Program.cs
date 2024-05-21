using dotNetDiome.ExemploFundamentos;
using System.Text;

Pessoa pessoa1 = new Pessoa();

//Variaveis
string Mensagem = "Isso é uma string";
int Idade = 23;
double NumeroFlutuante = 2.5;
decimal NumeroDecimal = 3.3M;
bool Booleano = true;
Console.WriteLine($"String: {Mensagem}. \nIsso é um inteiro:{Idade}.\nIsso é um Numero Flutuante: {NumeroFlutuante}.\nIsso é um Numero Decimal:{NumeroDecimal}.\nIsso é um Boolean:{Booleano}.");
//Console.WriteLine($"String: {Mensagem}. \nIsso é um inteiro:{Idade}.");

//Trabalhando com datas
DateTime DataAgora = DateTime.Now;
DateTime DataAtual = DateTime.Today;
DateTime SomaDia = DateTime.Now.AddDays(5);
Console.WriteLine($"Data atual: {DataAgora}.\nDia/Mes/Ano atual:{DataAtual.ToString("dd/MM/yyyy")}.\nSoma dia atual + 5:{SomaDia}.");

pessoa1.Nome = "Murilo";
pessoa1.Idade = 23;
pessoa1.Apresentar();