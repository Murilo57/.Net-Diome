using System;

namespace DesafioEstacionamento.Models
{
    public class Estacionamento
    {
        double valorPorHora = 10;
        double tempoEstacionado = 0;
        string Placa = "";
        List<string> veiculos = new List<string>();

        public Estacionamento(double valorPorHora, double tempoEstacionado, string Placa)
        {
            this.valorPorHora = valorPorHora;
            this.tempoEstacionado = tempoEstacionado;
            this.Placa = Placa;
        }

        public CadastrarVeiculos(novaPlaca Placa)
        {
            Console.WriteLine("Digite a placa:");
            novaPlaca = Console.ReadLine();
            if (novaPlaca <> "");
            {
                veiculos.Add(novaPlaca);
                Console.WriteLine("Carro cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Erro ao cadastrar placa.");
            }
            
            
        }

        public RemoverVeiculos()
        {
            Console.WriteLine("Digite a placa do veiculo que ira sair: ");
            string veiculoSaida = Console.ReadLine();
            if (veiculos.Any(x => x.ToUpper() == veiculoSaida.ToUpper()))
            {
                double horasEstacionado = ReadLine("Quanto tempo estacionado?: ");
            }
        }
    }
}
