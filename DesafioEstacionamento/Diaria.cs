using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public class Diaria
    {
        public Diaria(DateTime dataHoraInicio,Veiculo veiculo, bool diariaAdquirida,
                      bool duchaAdquirida)
        {
            DataHoraInicio = dataHoraInicio;
            Veiculo = veiculo;
            DiariaAdquirida = diariaAdquirida;
            DuchaAdquirida = duchaAdquirida;
            
        }

        public DateTime DataHoraInicio { get; private set; }
        public DateTime DataHoraFim { get; private set; }
        public Veiculo Veiculo { get; private set; }
        public bool DiariaAdquirida { get; private set; }
        public bool DuchaAdquirida { get; private set; }
        public decimal ValorDiaria { get; private set; }

        public void AtualizarDiaria(DateTime horaFim)
        {
            DataHoraFim = horaFim;

            TimeSpan ts = DataHoraFim - DataHoraInicio;

            if (Veiculo.TipoVeiculo == ETipoVeiculo.Carro)
            {
                if (DiariaAdquirida)
                    ValorDiaria = (decimal)EValorDiariaCarro.Diaria;
                else if (DuchaAdquirida)
                    ValorDiaria = (decimal)EValorDiariaCarro.Ducha;
                else if (ts.TotalMinutes < 15)
                    ValorDiaria = (decimal)EValorDiariaCarro.AbaixoQuinzeMinutos;
                else 
                    ValorDiaria = (decimal)EValorDiariaCarro.AcimaQuinzeMinutos;
            }
            else
            {
                if (DiariaAdquirida)
                    ValorDiaria = (decimal)EValorDiariaMoto.Diaria;
                else if (ts.TotalMinutes < 15 )
                    ValorDiaria = (decimal)EValorDiariaMoto.AbaixoQuinzeMinutos;
                else ValorDiaria = (decimal)EValorDiariaMoto.AcimaQuinzeMinutos;
                
            }

        }

    }
}
