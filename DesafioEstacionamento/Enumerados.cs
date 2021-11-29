using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioEstacionamento
{
    public enum ETipoVeiculo
    {
        Carro = 0,
        Moto = 1
    }

    public enum EValorDiariaCarro
    {
        AbaixoQuinzeMinutos = 2,
        AcimaQuinzeMinutos = 10,
        Diaria = 50,
        Ducha = 65

    }

    public enum EValorDiariaMoto
    {
        AbaixoQuinzeMinutos = 2,
        AcimaQuinzeMinutos = 5,
        Diaria = 25        

    }

}
