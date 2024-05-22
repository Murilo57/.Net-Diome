using System;

public class Estacionamento
{
    double valorPorHora = 10;
    List<string> veiculos = new List<string>();

    public Estacionamento(decimal valorPorHora, decimal tempoEstacionado)
    {
      this.valorPorHora     = valorPorHora;
      this.tempoEstacionado = tempoEstacionado;
    }

    public void AdicionarVeiculos()
    {        
      Console.WriteLine("Digite a placa do veiculo que ira estacionar: ");
      string Placas = Console.ReadLine();
      veiculos.Add(Placas);
    }

    public void RemoverVeiculos()
    {
      Console.WriteLine("Digite a placa do veiculo que ira sair: ");
      veiculoSaida = Console.ReadLine();
      if (veiculos.Any(x => x.ToUpper() == veiculoSaida.ToUpper()))
      {
        double horasEstacionado = ReadLine("Quanto tempo estacionado?: ");
      }
    }    
}
