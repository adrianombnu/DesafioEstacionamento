using System;

namespace DesafioEstacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando o estacionamento...");

            Estacionamento estacionamento = new Estacionamento("Estapar Estacionamento", "13.531.881/0001-19");

            estacionamento.AcionarVeiculo("ASD-2335", "Gol", "Preto", ETipoVeiculo.Carro,false, false);
            estacionamento.AcionarVeiculo("MEJ-2635", "Twister", "Amarelo", ETipoVeiculo.Moto, true, false);
            estacionamento.AcionarVeiculo("XYZ-1233", "Biz", "Preto", ETipoVeiculo.Moto, true, false);
            estacionamento.AcionarVeiculo("ABC-4897", "BMW", "Branco", ETipoVeiculo.Carro, false, true);
            estacionamento.AcionarVeiculo("FGT-9978", "Fusca", "Branco", ETipoVeiculo.Carro, true, false);

            estacionamento.FinalizarDiaria("MEJ-2635");
            estacionamento.GerarTicket("MEJ-2635");

            estacionamento.FinalizarDiaria("ABC-4897");
            estacionamento.GerarTicket("ABC-4897");

            estacionamento.FinalizarDiaria("FGT-9978");
            estacionamento.GerarTicket("FGT-9978");

            estacionamento.FinalizarDiaria("ASD-2335");
            estacionamento.GerarTicket("ASD-2335");
        }
    }
}
