using LavaRapido.Model;
using LavaRapido.Model.Enumeradores;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Controller
{
    class VeiculoController
    {
        public Veiculo GetNewVeiculo(string nomeProprietario, string placa, string modelo, int ano, int numRodas)
        {
            if (numRodas == 2)
            {
                return new Moto(nomeProprietario,placa , modelo, ano);
            }
            else {
                return new Carro(nomeProprietario, placa, modelo, ano);
            }
        }

        public static bool LoadAllVeiculos()
        {
            var FileName = "veiculos.bin";

            if (File.Exists(FileName))
            {
                Stream openFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                ViewPrincipal.instance.listaVeiculos = (List<Veiculo>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();

                return true;
            }

            return false;
        }

        public static bool SaveAllVeiculos() 
        {
            try
            {
                var FileName = "veiculos.bin";
                Stream SaveFile = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFile, ViewPrincipal.instance.listaVeiculos);
                SaveFile.Close();
                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public Veiculo Get(long Id)
        {
            return ViewPrincipal.instance.listaVeiculos.FirstOrDefault(x => x.Id == Id);
        }

        public long GetMaxId()
        {
            if (ViewPrincipal.instance.listaVeiculos.Any())
                return ViewPrincipal.instance.listaVeiculos.Max(x => x.Id) + 1;
            else
                return 1;
        }

        public bool Excluir(long Id)
        {
            var removeVeiculo = ViewPrincipal.instance.listaVeiculos.FirstOrDefault(x => x.Id == Id);
            if (removeVeiculo != null)
            {
                ViewPrincipal.instance.listaVeiculos.Remove(removeVeiculo);
                SaveAllVeiculos();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Salvar(string nome, string placa, string modelo, int ano, string tipo, long id)
        {

            try
            {

                if (id == 0)
                {
                    id = GetMaxId();
                }

                Veiculo newVeiculo;
                if(tipo == EVeiculos.Moto.ToString())
                    newVeiculo = GetNewVeiculo(nome, placa, modelo, ano, 2);
                else
                    newVeiculo = GetNewVeiculo(nome, placa, modelo, ano, 4);

                newVeiculo.Id = id;

                if (ViewPrincipal.instance.listaVeiculos.Any(x => x.Id == id))
                {
                    Excluir(id);
                }

                ViewPrincipal.instance.listaVeiculos.Add(newVeiculo);
                SaveAllVeiculos();

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
