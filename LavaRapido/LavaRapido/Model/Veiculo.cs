using LavaRapido.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Model
{
    [Serializable]
    public abstract class Veiculo
    {
        public long Id;
        public string NomeProprietario;
        public string Placa;
        public string Modelo;
        public int Ano;
        public int NumeroRodas;
        public EVeiculos Tipo;
    }
}
