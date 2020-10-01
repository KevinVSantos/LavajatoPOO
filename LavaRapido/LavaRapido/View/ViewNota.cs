using LavaRapido.Controller;
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
    public partial class ViewNota : Form
    {
        NotaController NC;
        public ViewNota()
        {
            InitializeComponent();
            NC = new NotaController();
            tb_id.Text = "0";
            loadListBoxNotas();
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            double preco = 0;
            if (double.TryParse(tb_preco.Text, out preco))
                NC.Salvar(tb_cliente.Text, tb_funcionario.Text, tb_carro.Text, preco, Convert.ToInt64(tb_id.Text));
            else
                MessageBox.Show("Preço errado. Formate o numero separando casa decimal com virgula.");
            loadListBoxNotas();
        }

        private void loadListBoxNotas() {

            list_Notas.Items.Clear();
            foreach (var nota in ViewPrincipal.instance.listaNotas) {
                list_Notas.Items.Add(nota.Id + " | " + nota.Placa + " | " + nota.Preco);
            }
        }

        private void tb_preco_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "0")
            {
                NC.Excluir(Convert.ToInt64(tb_id.Text));
                loadListBoxNotas();
            }
        }

        private void list_Notas_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemId = list_Notas.SelectedItem?.ToString().Split('|')[0].Trim();
            var item = NC.Get(Convert.ToInt64(itemId));

            if (item != null)
            {
                tb_carro.Text = item.Placa;
                tb_cliente.Text = item.ClienteCPF;
                tb_funcionario.Text = item.FuncionarioCPF;
                tb_id.Text = item.Id.ToString();
                tb_preco.Text = item.Preco.ToString();
            }

        }
    }
}
