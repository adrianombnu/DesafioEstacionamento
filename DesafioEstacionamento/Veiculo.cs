using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public class Veiculo
    {
        public Veiculo(string placa,
                       string modelo,
                       string cor,
                       ETipoVeiculo tipoVeiculo)
        {
            Placa = placa;
            Modelo = modelo;
            Cor = cor;            
            TipoVeiculo = tipoVeiculo;            

        }

        public string Placa { get;private set; }
        public string Modelo { get; private set; }
        public string Cor { get; private set; }
        public Diaria Diaria { get; private set; }
        public ETipoVeiculo TipoVeiculo { get; private set; }

        public void IniciarDiaria(Diaria diaria)
        {
            Diaria = diaria;
        }

    }
}
