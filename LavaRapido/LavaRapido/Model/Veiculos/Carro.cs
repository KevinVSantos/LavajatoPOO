using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Model
{
    [Serializable]
    class Carro : Veiculo
    {
        public Carro(string nomeProprietario, string placa,string modelo, int ano)
        {
            this.NomeProprietario = nomeProprietario;
            this.Placa = placa;
            this.Modelo = modelo;
            this.Ano = ano;
            this.NumeroRodas = 4;
            this.Tipo = Enumeradores.EVeiculos.Carro;
        }

    }
}
