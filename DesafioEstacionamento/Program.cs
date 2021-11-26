using System;

namespace DesafioEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando o estacionamento...");

            Estacionamento estacionamento = new Estacionamento("Estapar Estacionamento", "13.531.881/0001-19");

            Veiculo veiculo = new Veiculo("ASD-2335", "Gol", "Preto",ETipoVeiculo.Carro);
            Diaria diaria = new Diaria(DateTime.Now, veiculo, false, false);
            veiculo.IniciarDiaria(diaria);

            estacionamento.IniciarEstacionamento(veiculo, diaria);

            estacionamento.FinalizarDiaria(DateTime.Now);

            veiculo = new Veiculo("MEJ-2635", "Twister", "Amarelo", ETipoVeiculo.Moto);
            diaria = new Diaria(DateTime.Now, veiculo, false, false);
            veiculo.IniciarDiaria(diaria);

            estacionamento.IniciarEstacionamento(veiculo, diaria);

            estacionamento.FinalizarDiaria(DateTime.Now);

        }
    }
}
