using LavaRapido.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace LavaRapido.Controller
{
    class NotaController
    {

        public bool Salvar(string cpfCliente, string cpfFuncionario, string placaCarro, double preco, long id) {

            try {

                if (id == 0)
                {
                    id = GetMaxId();
                }

                var newNota = new Nota(cpfCliente, cpfFuncionario, placaCarro, preco, id);

                if (ViewPrincipal.instance.listaNotas.Any(x => x.Id == id))
                {
                    Excluir(id);
                }

                ViewPrincipal.instance.listaNotas.Add(newNota);
                SaveAllNotas();

                return true;
            }
            catch (Exception ex) {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public bool Excluir(long Id) 
        {
            var removeNota = ViewPrincipal.instance.listaNotas.FirstOrDefault(x => x.Id == Id);
            if (removeNota != null)
            {
                ViewPrincipal.instance.listaNotas.Remove(removeNota);
                SaveAllNotas();
                return true;
            }
            else {
                return false;
            }
            
        }

        public Nota Get(long Id) {

            return ViewPrincipal.instance.listaNotas.FirstOrDefault(x => x.Id == Id);
        }

        public long GetMaxId() {
            if(ViewPrincipal.instance.listaNotas.Any())
                return ViewPrincipal.instance.listaNotas.Max(x => x.Id) + 1;
            else
                return 1;
        }

        public static bool LoadAllNotas()
        {
            var FileName = "notas.bin";

            if (File.Exists(FileName))
            {
                Stream openFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                ViewPrincipal.instance.listaNotas = (List<Nota>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();

                return true;
            }

            return false;
        }

        public static bool SaveAllNotas()
        {
            try
            {
                var FileName = "notas.bin";
                Stream SaveFile = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFile, ViewPrincipal.instance.listaNotas);
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
