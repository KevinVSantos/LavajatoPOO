using LavaRapido.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Controller
{
    class VeiculoController
    {
        public Veiculo GetVeiculo(string nome, string marca, string cor,int numRodas)
        {
            if (numRodas == 2)
            {
                return new Moto(nome, marca, cor);
            }
            else {
                return new Carro(nome, marca, cor);
            }
        }

    }
}
