using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public class Estacionamento
    {
        private List<Estacionar> _estacionar;
        public string Nome { get; private set; }
        public string Documento { get; private set; }
        public IReadOnlyList<Estacionar> Estacionar => _estacionar;

        public Estacionamento(string nome, string documento)
        {
            Nome = nome;
            Documento = documento;
            _estacionar ??= new List<Estacionar>(); 
        }

        public void IniciarEstacionamento(Veiculo veiculo, Diaria diaria)
        {
            Estacionar estacionar = new Estacionar(veiculo, diaria);

            if (estacionar is null)
                throw new Exception("Não foi inciado um estacionamento");

            _estacionar.Add(estacionar);
        }

        public void FinalizarDiaria(DateTime dataHoraFim)
        {
            
        }


    }
}
