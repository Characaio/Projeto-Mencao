using project_mencao.DTOs;
using project_mencao.Models;
using project_mencao.Utilidades;
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
    public partial class ComprarProdutosTela : Form
    {
        /// <summary>
        /// Dicionario para converter Estado Para Frete
        /// </summary>
        
        public ComprarProdutosTela()
        {
            InitializeComponent();
        }

        private void ComprarProdutosTela_Load(object sender, EventArgs e)
        {

        }

        private void VoltarTelaPrincipalBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._hubtela.Show();
        }

        private void CarregarProdutoBot_Click(object sender, EventArgs e)
        {
            carregar_dados_do_produto();
        }

        public void carregar_dados_do_produto()
        {
            Object ProdutoSelecionadoPuro = ProdutoSelecionadoCombo.SelectedItem;
            String ProdutoSelecionadoString;
            long ProdutoSelecionadoId = -1;

            if (ProdutoSelecionadoPuro != null)
            {
                ProdutoSelecionadoString = ProdutoSelecionadoPuro.ToString();
                ProdutoSelecionadoId = long.Parse(ProdutoSelecionadoString.Split('-')[0].Trim());
            }
            else
            {
                MessageBox.Show(
                    AcaoResposta.SelecioneProduto,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Produto produtoSelecionado = Program._produtosRepo.carregar_produto(ProdutoSelecionadoId);

            NomeBox.Text = produtoSelecionado.GetNome();
            ValorBox.Text = produtoSelecionado.GetPreco().ToString();
            DescriMultiLineBox.Text = produtoSelecionado.GetDescricao();
            MarcaBox.Text = produtoSelecionado.GetMarca();
            TipoBox.Text = produtoSelecionado.GetTipo();

            QuantBox.Text = "1";
            PainelDeCompra.Show();
        }
        private void CompraProdutoBot_Click(object sender, EventArgs e)
        {

            bool QuantValida = int.TryParse(QuantBox.Text, out int Quantidade);

            decimal ValorFinal = decimal.Parse(ValorFinalLabel.Text);

            decimal ValorDoPedido = ValorFinal * Quantidade;
            String Erros = Program._pedidoservice.comprar_produto(
                new ProdutoDTO(
                    EstadoComboBox.SelectedItem.ToString(),
                    Quantidade
                ), 
                new PedidoDTO(
                    Program._loginRepo.pegar_id_do_usuario(Program._usuarioLogado),
                    long.Parse(ProdutoSelecionadoCombo.SelectedItem.ToString().Split('-')[0].Trim()),
                    ValorDoPedido,
                    Quantidade)
                );

            if (Erros.Equals(""))
            {
                MessageBox.Show(
                    AcaoResposta.ProdutoComprado,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(
                    Erros,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void IrParaHistoricoDeCompraBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._historicoprodutostela.carregar_historico();
            Program._historicoprodutostela.Show();  
        }
        
        public void atualizar_lista_de_produtos()
        {

            ProdutoSelecionadoCombo.DataSource = Program._produtoservice.atualizar_lista_de_produtos();
            
        }
        private void ComprarProdutosTela_Shown(object sender, EventArgs e)
        {
            atualizar_lista_de_produtos();
            MessageBox.Show(
                "Por favor selecione um produto no campo de seleção do lado esquerdo",
                AcaoResposta.Atencao,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );

        }

        private void EstadoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizar_valor_final();
        }

        private void IrParaCadastro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._cadastroprodutostela.Show();
        }

        private void ComprarProdutosTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void atualizar_valor_final()
        {


            bool QuantValida = int.TryParse(QuantBox.Text, out int Quantidade);

            PedidoCalculoRespostaDTO resposta = Program._produtoservice.calcular_frete(
                new PedidoDTO(
                    EstadoComboBox.SelectedItem.ToString(),
                    decimal.Parse(ValorBox.Text),
                    Quantidade));

            

            if (resposta.Erros.Equals(""))
            {

                ValorDoFreteLabel.Text = resposta.Frete.ToString();
                ValorFinalLabel.Text = resposta.ValorFinal.ToString();

            }
        }
        private void QuantBox_TextChanged(object sender, EventArgs e)
        {
            
            atualizar_valor_final();
        }

        private void ProdutoSelecionadoCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            carregar_dados_do_produto();
        }

        public void limpar_dados()
        {
            NomeBox.Text = "";
            ValorBox.Text = "";
            DescriMultiLineBox.Text = "";
            MarcaBox.Text = "";
            TipoBox.Text = "";
            PainelDeCompra.Hide();
            EstadoComboBox.SelectedIndex = 1;
            ProdutoSelecionadoCombo.SelectedIndex = 1;
        }

        private void ComprarProdutosTela_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void CarregarProdutoBot_Click_1(object sender, EventArgs e)
        {
            carregar_dados_do_produto();
        }
    }
}
