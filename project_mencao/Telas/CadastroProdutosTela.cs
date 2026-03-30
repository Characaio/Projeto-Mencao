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

            bool PreçoValido = decimal.TryParse(ValorBox.Text, out decimal Preco);
            
            String Erros = Program._produtoservice.cadastrar_produto(
                new ProdutoDTO(
                    NomeBox.Text,
                    Preco,
                    DescriMultiLineBox.Text,
                    MarcaBox.Text,
                    TipoComboBox.SelectedItem.ToString()
                ));

            

            if (Erros.Equals(""))
            {
                

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
