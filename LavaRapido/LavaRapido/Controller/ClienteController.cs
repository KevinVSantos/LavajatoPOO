using LavaRapido.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Controller
{
    class ClienteController
    {
        public static bool LoadAllClientes()
        {
            var FileName = "clientes.bin";

            if (File.Exists(FileName))
            {
                Stream openFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                ViewPrincipal.instance.listaClientes = (List<Cliente>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();

                return true;
            }

            return false;
        }

        public static bool SaveAllClientes()
        {
            try
            {
                var FileName = "clientes.bin";
                Stream SaveFile = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFile, ViewPrincipal.instance.listaClientes);
                SaveFile.Close();
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
