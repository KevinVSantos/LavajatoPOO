using LavaRapido.Controller;
using LavaRapido.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LavaRapido
{
    public partial class ViewFuncionario : Form
    {
        FuncionarioController FC;
        public ViewFuncionario()
        {
            InitializeComponent();
            
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            FC.Excluir(tb_id.Text);
            foreach (Funcionario f in ViewPrincipal.instance.listaFuncionarios)
                lb_list.Items.Add(f.CPF);
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            FC.Salvar(tb_id.Text, tb_cpf.Text, tb_nome.Text, tb_end.Text, tb_idade.Text, tb_tel.Text, tb_sal.Text);
            foreach (Funcionario f in ViewPrincipal.instance.listaFuncionarios)
                lb_list.Items.Add(f.CPF);
        }

        private void ViewFuncionario_Load(object sender, EventArgs e)
        {
            FC = new FuncionarioController();

            foreach (Funcionario f in ViewPrincipal.instance.listaFuncionarios)
                lb_list.Items.Add(f.CPF);
        }

        private void lb_list_SelectedIndexChanged(object sender, EventArgs e)
        {

            var f = ViewPrincipal.instance.listaFuncionarios.FirstOrDefault(x => x.CPF == lb_list.SelectedItem.ToString());
            tb_id.Text = f.Id.ToString();
            tb_cpf.Text = f.CPF.ToString();
            tb_nome.Text = f.Nome.ToString();
            tb_end.Text = f.Endereco.ToString();
            tb_idade.Text = f.Idade.ToString();
            tb_tel.Text = f.Telefone.ToString();
            tb_sal.Text = f.Salario.ToString();
        }
    }
}
