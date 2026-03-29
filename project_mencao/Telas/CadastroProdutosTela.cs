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
    public partial class CadastroProdutosTela : Form
    {
        public CadastroProdutosTela()
        {
            InitializeComponent();
        }

        private void TipoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroBot_Click(object sender, EventArgs e)
        {
            String Nome = NomeBox.Text;
            bool PreçoValido = decimal.TryParse(ValorBox.Text, out decimal Preco);
            String Descricao = DescriMultiLineBox.Text;
            String Marca = MarcaBox.Text;

            String Erros = "";

            if (String.IsNullOrWhiteSpace(Nome))
            {
                Erros += "O nome do produto é obrigatório.\n";
            }

            if (!PreçoValido || Preco < 0)
            {
                Erros += "Digite um preço válido para o produto.\n";
            }

            if (String.IsNullOrWhiteSpace(Descricao))
            {
                Erros += "A descrição do produto é obrigatória.\n";
            }

            if (String.IsNullOrWhiteSpace(Marca))
            {
                Erros += "A marca do produto é obrigatória.\n";
            }
            Object TipoSelecionadoPuro = TipoComboBox.SelectedItem;
            String Tipo = "";
            if (TipoSelecionadoPuro != null)
            {
                Tipo = TipoSelecionadoPuro.ToString();
            }
            else
            {
                Erros += "Selecione um tipo para o produto.\n";
            }

            if (Erros.Equals(""))
            {
                Program._produtosRepo.cadastrar_produto(new Produto(
                    Nome,
                    Descricao,
                    Marca,
                    Tipo,
                    Preco
                    ));

                NomeBox.Text = "";
                MarcaBox.Text = "";
                DescriMultiLineBox.Text = "";
                ValorBox.Text = "";
                TipoComboBox.SelectedIndex = 0;

                

                MessageBox.Show(
                    AcaoResposta.ProdutoCadastrado,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
            else
            {
                MessageBox.Show(
                    Erros,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void VoltarBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._compraprodutostela.atualizar_lista_de_produtos();
            Program._compraprodutostela.Show();
        }

        private void CadastroProdutosTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
