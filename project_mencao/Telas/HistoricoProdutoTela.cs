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
            List<Pedido> pedidos = Program._pedidosrepo.listar_pedidos(
                Program._loginRepo.pegar_id_do_usuario(Program._usuarioLogado)
                );
            List<TabelaDePedidosDTO> tabelaDePedidosDTOs = new List<TabelaDePedidosDTO>();
            foreach (Pedido pedido in pedidos)
            {

                TabelaDePedidosDTO linha = new TabelaDePedidosDTO(
                    pedido.GetIdDoPedido(),
                    Program._produtosRepo.pegar_nome_do_produto(pedido.GetIdDoProduto()),
                    Program._loginRepo.pegar_nome_do_usuario(pedido.GetIdDoUsuario()),
                    pedido.GetDataDoPedido(),
                    pedido.GetQuantidade());
                tabelaDePedidosDTOs.Add(linha);
            }
            HistoricoCompraLabel.Text = "Historico Das Compras \n De " + Program._usuarioLogado.getNome();
            TabelaDeHistorico.DataSource = tabelaDePedidosDTOs;
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
