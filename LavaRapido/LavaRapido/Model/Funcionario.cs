using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Model
{
    [Serializable]
    public class Funcionario
    {
        public long Id;
        public string Nome;
        public string CPF;
        public string Endereco;
        public int Idade;
        public string Telefone;
        public double Salario;

    }
}
