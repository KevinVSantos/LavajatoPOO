using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Model
{
    [Serializable]
    public class Cliente
    {
        public long Id;
        public string Nome;
        public string CPF;
        public string Endereco;
        public int Idade;
        public string Telefone;
    }
}
