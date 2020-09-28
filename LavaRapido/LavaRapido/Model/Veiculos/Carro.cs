using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Model
{
    class Carro : Veiculo
    {
        public Carro(string nome, string marca, string cor)
        {
            this.nome = nome;
            this.marca = marca;
            this.cor = cor;
            this.numeroRodas = 4;
        }

    }
}
