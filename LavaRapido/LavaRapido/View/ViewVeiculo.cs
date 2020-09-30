using LavaRapido.Controller;
using LavaRapido.Model.Enumeradores;
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
    public partial class ViewVeiculo : Form
    {
        VeiculoController VC;
        public ViewVeiculo()
        {
            InitializeComponent();
            VC = new VeiculoController();
            tb_id.Text = "0";
            loadListBoxVeiculos();

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ViewVeiculo_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof(EVeiculos)))
                tb_tipo.Items.Add(item.ToString());
        }

        private void list_Veiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            var itemId = list_Veiculos.SelectedItem?.ToString().Split('|')[0].Trim();
            var item = VC.Get(Convert.ToInt64(itemId));

            if (item != null)
            {
                tb_ano.Text = item.Ano.ToString();
                tb_modelo.Text = item.Modelo;
                tb_nome.Text = item.NomeProprietario;
                tb_id.Text = item.Id.ToString();
                tb_placa.Text = item.Placa;
                tb_tipo.Text = item.Tipo.ToString();
            }
        }

        private void loadListBoxVeiculos()
        {
            list_Veiculos.Items.Clear();
            foreach (var veiculo in ViewPrincipal.instance.listaVeiculos)
            {
                list_Veiculos.Items.Add(veiculo.Id + " | " + veiculo.Placa + " | " + veiculo.NomeProprietario);
            }
        }

        private void b_excluir_Click(object sender, EventArgs e)
        {
            if (tb_id.Text != "0")
            {
                VC.Excluir(Convert.ToInt64(tb_id.Text));
                loadListBoxVeiculos();
            }
        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            int ano = 0;
            if (int.TryParse(tb_ano.Text, out ano))
                if(!string.IsNullOrEmpty(tb_tipo.Text))
                    VC.Salvar(tb_nome.Text, tb_placa.Text, tb_modelo.Text, ano, tb_tipo.Text,Convert.ToInt64(tb_id.Text));
                else
                    MessageBox.Show("Escolha um tipo");
            else
                MessageBox.Show("Ano errado. Formate o numero.");
            loadListBoxVeiculos();
        }
    }
}
