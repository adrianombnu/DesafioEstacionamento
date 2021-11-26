using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public class Estacionar
    {
        public Estacionar(Veiculo veiculo, Diaria diaria)
        {
            Veiculo = veiculo;
            Diaria = diaria;
        }

        public Veiculo Veiculo { get; set; }
        public Diaria Diaria { get; set; }

    }
}
