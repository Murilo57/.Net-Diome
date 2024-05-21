using dotNetDiome.ExemploFundamentos;
using ExemploFundamentos.Models;
using System.Text;

//Lista

List<string> listaString = new List<string>();

listaString.Add("SP");
listaString.Add("BA");
listaString.Add("RJ");

//Adicionando com FOR
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Posição Nº {contador} - {listaString[contador]}");
}

//Adicionando com FOREACH
int contadorForeach2 = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Posição Nº {contadorForeach2} - {item}");
    contadorForeach2++;
}

//Array
int[] arrayInteiros = new int[3];

arrayInteiros[0] = 23;
arrayInteiros[1] = 32;
arrayInteiros[2] = 4;

Console.WriteLine("Percorrendo o Array com o FOR");
for (int contador = 0; contador < arrayInteiros.Length; contador++)
{
    Console.WriteLine($"Posição Nº {contador} = {arrayInteiros[contador]}");
}

//Redimensionando um Array
Array.Resize(ref arrayInteiros, arrayInteiros.Length * 2);

//Passando valores de um array para outro
int[] arrayInteirosDobrado = new int[arrayInteiros.Length * 2];
Array.Copy(arrayInteiros, arrayInteirosDobrado, arrayInteiros.Length);

int contadorForeach = 0;
Console.WriteLine("Percorrendo o Array com o FOREACH");
foreach (int valor in arrayInteiros)
{
    Console.WriteLine($"Posição Nº {contadorForeach} = {valor}");
    contadorForeach++;

}


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

//Classe calculadora
Calculadora Calc = new Calculadora();

Calc.Somar(5, 4);
Calc.Subtrair(10, 5);
Calc.Multiplicar(2, 10);
Calc.Dividir(5, 2);
Calc.Potencia(12, 3);
Calc.Seno(12);
Calc.RaizQuadrada(10);


//Estruturas de Repetições
// FOR
int numero1 = 0;
Console.WriteLine($"test");
for (int Contador = 0; Contador <= 10; Contador++)
{
    Console.WriteLine($"{numero1} x {Contador} = {numero1 * Contador}");
}


//WHILE
int numero = 1;
int contador = 0;
while (contador <= 20)
{
    Console.WriteLine($"{numero}x{contador} = {numero * contador}");
    contador += 1;

    //Forma de interromper um loop
    if (contador == 19)
    {
        break;
    }
}

//DO WHILE
int soma = 0, numero2 = 0;
do
{
    Console.WriteLine("Digite um numero (0 para parar):");
    numero2 = Convert.ToInt32(Console.ReadLine());
    soma += numero;

} while (numero2 != 0);

Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");

//Menu interativo 
string opcao;

while (true)
{
    Console.WriteLine($"Digite a sua opção:");
    Console.WriteLine($"1 - Cadastrar cliente");
    Console.WriteLine($"2 - Buscar cliente");
    Console.WriteLine($"3 - Apagar cliente");
    Console.WriteLine($"4 - Encerrar");

    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Cadastro do cliente");
            break;
        case "2":
            Console.WriteLine("Busca de cliente");
            break;
        case "3":
            Console.WriteLine("Apagar cliente");
            break;
        case "4":
            Console.WriteLine("Encerrado!");
            Environment.Exit(0);
            break;
    }
}