using System;

namespace DesafioEstacionamento.Models;
public class Estacionamento
{
    private decimal valorPorHora;
    private List<string> veiculos = new List<string>();

    public Estacionamento(decimal valorPorHora)
    {
        this.valorPorHora = valorPorHora;
    }

    public void CadastrarVeiculo()
    {
        Console.WriteLine("Digite a placa do veiculo que ira estacionar: ");
        string Placas = Console.ReadLine()!;
        veiculos.Add(Placas);
        Console.WriteLine("Veiculo cadastrado com sucesso!");
    }

    public void RemoverVeiculo()
    {
        Console.WriteLine("Digite a placa do veículo para remover:");
        string placa = "";
        placa = Console.ReadLine()!;

        if (veiculos.Any(x => x.Equals(placa, StringComparison.CurrentCultureIgnoreCase)))
        {
            Console.WriteLine("Quantas tempo estacionado?: ");

            int horas = 0;
            decimal valorTotal = 0;

            horas = int.Parse(Console.ReadLine());         

            veiculos.Remove(placa);

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        Console.WriteLine("Veiculos estacionados:");
        int qtdeVeiculos = 0;

        foreach(string veiculo in veiculos)
        {
            Console.WriteLine(Convert.ToString(veiculo));
            qtdeVeiculos++;
        }        
    }

}
