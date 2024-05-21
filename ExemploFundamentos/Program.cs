using dotNetDiome.ExemploFundamentos;
using System.Text;

Pessoa pessoa1 = new Pessoa();

//Variaveis
string Mensagem = "Isso � uma string";
int Idade = 23;
double NumeroFlutuante = 2.5;
decimal NumeroDecimal = 3.3M;
bool Booleano = true;
Console.WriteLine($"String: {Mensagem}. \nIsso � um inteiro:{Idade}.\nIsso � um Numero Flutuante: {NumeroFlutuante}.\nIsso � um Numero Decimal:{NumeroDecimal}.\nIsso � um Boolean:{Booleano}.");
//Console.WriteLine($"String: {Mensagem}. \nIsso � um inteiro:{Idade}.");

//Trabalhando com datas
DateTime DataAgora = DateTime.Now;
DateTime DataAtual = DateTime.Today;
DateTime SomaDia = DateTime.Now.AddDays(5);
Console.WriteLine($"Data atual: {DataAgora}.\nDia/Mes/Ano atual:{DataAtual.ToString("dd/MM/yyyy")}.\nSoma dia atual + 5:{SomaDia}.");

//Conversor de variaveis
int a = Convert.ToInt32("5"); //String para Integer
string b = Convert.ToString(10); //Integer para String

string c = "teste";
int d = 8;

int.TryParse(c, out d);

Console.Write($"{a}.\n{b}.\n");


pessoa1.Nome = "Murilo";
pessoa1.Idade = 23;
pessoa1.Apresentar();


//Operadores condicionais
int Qtde = 20;
int QtdeVenda = 20;


if (Qtde > QtdeVenda)
{
    Console.WriteLine("Venda Realizada");
}
else if (Qtde == QtdeVenda)
{
    Console.WriteLine("Venda realizada e estoque zerado");
}
else
{
    Console.WriteLine("Estoque insuficiente");
}

Console.WriteLine("---- Digite algo ----");
string Teste = Console.ReadLine();

if (Teste == "algo")
{
    Console.WriteLine("certo");
}
else if ((Teste != "") || (Teste != "algo"))
{
    Console.WriteLine($"Você digitou: {Teste}");
}
else
{
    Console.WriteLine("Vazio");
}

//Switch Case
switch (Teste)
{
    case "algo":
    case "Teste":
        Console.WriteLine($"{Teste}");

        break;

    default:
        Console.Write("Vazio");
        break;
}

/*Operadores logicos 

OR (||)
*/

//Exercicio com operadores Lógicos
bool eMaiorDeIdade = true;
int MaiorIdade = 18;
int SuaIdade = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("---- Digite sua idade ----");
if ((Idade >= MaiorIdade) || (eMaiorDeIdade))
{
    Console.WriteLine("Você tem autorização");
}
if ((SuaIdade == MaiorIdade) & (eMaiorDeIdade))
{
    Console.WriteLine("Sua Idade é igual a maioridade e você tem autorização");
}