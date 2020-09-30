using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Model
{
    [Serializable]
    public class Nota
    {
        public long Id;
        public string ClienteCPF;
        public string FuncionarioCPF;
        public string Placa;
        public double Preco;

        public Nota(string clienteCPF, string funcionarioCPF, string placa, double preco, long id)
        {
            this.Id = id;
            this.ClienteCPF = clienteCPF;
            this.FuncionarioCPF = funcionarioCPF;
            this.Placa = placa;
            this.Preco = preco;
        }

    }
}
