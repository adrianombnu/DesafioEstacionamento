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


    }
}
