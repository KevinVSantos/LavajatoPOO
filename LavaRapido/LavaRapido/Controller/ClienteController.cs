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

        public void Excluir(String idc)
        {
            if(idc != "0")
            {
                long id = Convert.ToInt32(idc);
                var c = ViewPrincipal.instance.listaClientes.FirstOrDefault(x => x.Id == id);
                ViewPrincipal.instance.listaClientes.Remove(c);
            }
               
        }

        public long GetId()
        {
            return ViewPrincipal.instance.listaClientes.Max<Cliente>().Id + 1;
        }

        public void  Salvar(String idc, String cpf, String nome, String end, String idade, String tel)
        {
            long id = idc == "0" ? GetId() : Convert.ToInt32(idc);
            Cliente cliente = new Cliente();
            cliente.Id = id;
            cliente.CPF = cpf;
            cliente.Nome = nome;
            cliente.Endereco = end;
            cliente.Idade = Convert.ToInt32(idade);
            cliente.Telefone = tel;
            if (idc == "0") { 
                ViewPrincipal.instance.listaClientes.Add(cliente); 
            } else {
               var c =  ViewPrincipal.instance.listaClientes.FirstOrDefault(x => x.Id == id);
                ViewPrincipal.instance.listaClientes.Remove(c);
                ViewPrincipal.instance.listaClientes.Add(cliente);
            } 


            SaveAllClientes();
        }
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
