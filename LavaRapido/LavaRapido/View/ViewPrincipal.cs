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
    public partial class ViewPrincipal : Form
    {
        public ViewPrincipal()
        {
            InitializeComponent();
        }

        private void carroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCarro = new ViewVeiculo();

            formCarro.ShowDialog();

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formCliente = new ViewCliente();

            formCliente.ShowDialog();

        }

        private void funcionárioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFuncionario = new ViewFuncionario();

            formFuncionario.ShowDialog();

        }

        private void notaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formNotas = new ViewNota();

            formNotas.ShowDialog();
        }
    }
}
