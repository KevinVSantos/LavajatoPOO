﻿using LavaRapido.Model;
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
        public Veiculo GetVeiculo(string nomeProprietario, string placa, string modelo, int ano, int numRodas)
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
    }
}
