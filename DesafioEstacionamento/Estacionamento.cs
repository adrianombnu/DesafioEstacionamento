using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public class Estacionamento
    {
        private List<Veiculo> _veiculo;
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public IReadOnlyList<Veiculo> Veiculo => _veiculo;

        public Estacionamento(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
            _veiculo ??= new List<Veiculo>(); 
        }

        public void AcionarVeiculo(Veiculo veiculo, bool diariaAdquirida, bool duchaAdquirida)
        {
            if (veiculo is null)
                throw new Exception("Não foi iniciado um veiculo");

            veiculo.IniciarDiaria(new Diaria(DateTime.Now, veiculo,diariaAdquirida,duchaAdquirida));

            _veiculo.Add(veiculo);

        }

        public void FinalizarDiaria(string placa)
        {
            var veiculo = _veiculo.SingleOrDefault(c => c.Placa == placa );

            if(veiculo is null)
                throw new Exception("Veiculo não encontrado");

            veiculo.Diaria.AtualizarDiaria(DateTime.Now.AddMinutes(30));
            //c.Diaria.AtualizarDiaria(DateTime.Now);

        }

        public void GerarTicket(string placa)
        {
            var veiculo = _veiculo.SingleOrDefault(c => c.Placa == placa);

            if (veiculo is null)
                throw new Exception("Veiculo não encontrado");

            Console.WriteLine("Resumo diaria:");
            Console.WriteLine(@"Placa: " + veiculo.Placa + 
                               "\nHora de entrada: " + veiculo.Diaria.DataHoraInicio +
                               "\nHora de saída: " + veiculo.Diaria.DataHoraFim +
                                "\nTotal da diaria: " + veiculo.Diaria.ValorDiaria);

        }

    }
}
