using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao.Telas
{
    public partial class HistoricoProdutoTela : Form
    {
        public HistoricoProdutoTela()
        {
            InitializeComponent();
        }

        public void carregar_historico()
        {
            TabelaDeHistorico.Columns.Clear();

            HistoricoCompraLabel.Text = "Historico Das Compras \n De " + Program._usuarioLogado.getNome();

            TabelaDeHistorico.DataSource = Program._produtoservice.carregar_historico();
        }
        private void HistoricoProdutoTela_Shown(object sender, EventArgs e)
        {
            carregar_historico();
        }

        private void VoltarParaComprasBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._compraprodutostela.Show();
        }

        private void HistoricoProdutoTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
