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
    class FuncionarioController
    {

        public void Excluir(String idf)
        {
            if (idf != "" && idf != "0")
            {
                    long id = Convert.ToInt32(idf);
                    var f = ViewPrincipal.instance.listaFuncionarios.FirstOrDefault(x => x.Id == id);
                    ViewPrincipal.instance.listaFuncionarios.Remove(f);
                    SaveAllFuncionarios();

            }

        }

        public long GetId()
        {
            if (ViewPrincipal.instance.listaFuncionarios.Count() == 0)
            {
                return 1;
            }
            else
            {
                return ViewPrincipal.instance.listaFuncionarios.Max<Funcionario>().Id + 1;
            }
        }

        public void Salvar(String idf, String cpf, String nome, String end, String idade, String tel, String sal)
        {

            if (idf != "" && cpf != "")
            {
                long id = idf == "0" ? GetId() : Convert.ToInt32(idf);
                Funcionario funcionario = new Funcionario();
                funcionario.Id = id;
                funcionario.CPF = cpf;
                funcionario.Nome = nome;
                funcionario.Endereco = end;
                funcionario.Idade = Convert.ToInt32(idade);
                funcionario.Telefone = tel;
                funcionario.Salario = Convert.ToDouble(sal);
                if (idf == "0")
                {
                    ViewPrincipal.instance.listaFuncionarios.Add(funcionario);
                }
                else
                {
                    var f = ViewPrincipal.instance.listaFuncionarios.FirstOrDefault(x => x.Id == id);
                    ViewPrincipal.instance.listaFuncionarios.Remove(f);
                    ViewPrincipal.instance.listaFuncionarios.Add(funcionario);
                }


                SaveAllFuncionarios();
            }
        }
        public static bool LoadAllFuncionarios()
        {
            var FileName = "funcionarios.bin";

            if (File.Exists(FileName))
            {
                Stream openFileStream = File.OpenRead(FileName);
                BinaryFormatter deserializer = new BinaryFormatter();
                ViewPrincipal.instance.listaFuncionarios = (List<Funcionario>)deserializer.Deserialize(openFileStream);
                openFileStream.Close();

                return true;
            }

            return false;
        }

        public static bool SaveAllFuncionarios()
        {
            try
            {
                var FileName = "funcionarios.bin";
                Stream SaveFile = File.Create(FileName);
                BinaryFormatter serializer = new BinaryFormatter();
                serializer.Serialize(SaveFile, ViewPrincipal.instance.listaFuncionarios);
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
