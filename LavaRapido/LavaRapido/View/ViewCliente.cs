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
    public partial class ViewCliente : Form
    {
        ClienteController CC;
        public ViewCliente()
        {
            InitializeComponent();
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            CC.Excluir(tb_id.Text);
            tb_id.Text = "0";
            tb_cpf.Text = "";
            tb_nome.Text = "";
            tb_end.Text = "";
            tb_idade.Text = "";
            tb_tel.Text = "";
            lb_list.Items.Clear();
            foreach (Cliente c in ViewPrincipal.instance.listaClientes)
                lb_list.Items.Add(c.CPF);
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            CC.Salvar(tb_id.Text, tb_cpf.Text, tb_nome.Text, tb_end.Text, tb_idade.Text, tb_tel.Text);
            tb_id.Text = "0";
            tb_cpf.Text = "";
            tb_nome.Text = "";
            tb_end.Text = "";
            tb_idade.Text = "";
            tb_tel.Text = "";
            lb_list.Items.Clear();
            foreach (Cliente c in ViewPrincipal.instance.listaClientes)
                lb_list.Items.Add(c.CPF);
        }

        private void ViewCliente_Load(object sender, EventArgs e)
        {
            CC = new ClienteController();
            tb_id.Text = "0";
            lb_list.Items.Clear();
            foreach (Cliente c in ViewPrincipal.instance.listaClientes)
                lb_list.Items.Add(c.CPF);

        }

        private void lb_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = ViewPrincipal.instance.listaClientes.FirstOrDefault(x => x.CPF == lb_list.SelectedItem.ToString());
            tb_id.Text = c.Id.ToString();
            tb_cpf.Text = c.CPF.ToString();
            tb_nome.Text = c.Nome.ToString();
            tb_end.Text = c.Endereco.ToString();
            tb_idade.Text = c.Idade.ToString();
            tb_tel.Text = c.Telefone.ToString();
        }
    }
}
