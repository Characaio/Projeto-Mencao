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

namespace project_mencao
{
    public partial class CalcularMediaTela : Form
    {
        public bool AtualizarCombo = false;
        public CalcularMediaTela()
        {
            InitializeComponent();
        }


        private Dictionary<String, Bimestre> BimStrParaBimEnum = new Dictionary<String, Bimestre> {
            {"1ºBimestre", Bimestre.Primeiro},
            {"2ºBimestre", Bimestre.Segundo},
            {"3ºBimestre", Bimestre.Terceiro},
            {"4ºBimestre", Bimestre.Quarto}
        };

        /// <summary>
        /// Essa função pega os dados do sistema, valida os dados e posta a nota do aluonO.
        /// Caso não exista essa nota no sistema, ele cria a nota, mas caso exista ele atualiza a nota do aluno.
        /// </summary>
        public void postar_nota_do_aluno()
        {
            Object AlunoPuro = AlunoCombo.SelectedItem;
            long AlunoId = -1;
            String AlunoNome = "";
            if (AlunoPuro != null)
            {
                AlunoId = long.Parse(AlunoPuro.ToString().Split(' ')[0]);
                AlunoNome = AlunoPuro.ToString().Split(' ')[1];
            }
            Object BimestrePuro = BimCombo.SelectedItem;
            String BimestreStr;
            Bimestre bimestre = Bimestre.nulo;
            if (BimestrePuro != null)
            {
                BimestreStr = BimestrePuro.ToString();
                bimestre = BimStrParaBimEnum[BimestreStr];
            }

            bool NotaProvaValida = decimal.TryParse(NotaProvaBox.Text, out decimal NotaProva);
            bool NotaAtivValida = decimal.TryParse(NotaAtivBox.Text, out decimal NotaAtiv);
            bool NotaCompValida = decimal.TryParse(NotaCompBox.Text, out decimal NotaComp);
            String Erros = "";

            if (NotaProva < 0 || NotaProva > 10 || !NotaProvaValida)
            {
                Erros += "Nota de prova Invalida\n";
            }

            if (NotaAtiv < 0 || NotaAtiv > 10 || !NotaAtivValida)
            {
                Erros += "Nota da atividade Invalida\n";
            }

            if (NotaComp < 0 || NotaComp > 10 || !NotaCompValida)
            {
                Erros += "Nota de comportamento Invalida\n";

            }

            NotaAtivBox.Text = null;
            NotaProvaBox.Text = null;
            NotaCompBox.Text = null;
            if (!Erros.Equals(""))
            {
                MessageBox.Show(
                    Erros,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Nota nota = new Nota(NotaProva, NotaAtiv, NotaComp);
            if (Program._notasRepo.nota_ja_existe(AlunoId, bimestre)){
                Program._notasRepo.atualizar_nota(
                    bimestre,
                    AlunoId,
                    nota);
                MessageBox.Show(
                    AcaoResposta.NotaAtualizada,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                Program._notasRepo.postar_nota(
                    bimestre,
                    AlunoId,
                    nota);
                MessageBox.Show(
                    AcaoResposta.NotaPostada,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }

            carregar_tabela();
        }
        private void PostarButton_Click(object sender, EventArgs e)
        {
            postar_nota_do_aluno();
            
        }
        
        public void atualizar_materia()
        {
            NotaPlaceHolderLabel.Text = "Nota Da Matéria: " + Program._usuarioLogado.getMateriaLecionada();
        }

        /// <summary>
        /// Pega os dados dos alunos junto com suas notas e coloca na tabela de notas.
        /// Caso a varaivel AtualizarCombo seja true, ele tambem atualiza a combo, essa checagem existe para previnir que a comboBox seja reiniciada cada vez que postar uma nota
        /// </summary>
        public void carregar_tabela()
        {
            List<TableDataNotasDTO> resultadoDaTabela = Program._notaservice.carregar_tabela();
            List<String> resultadoDaCombo = Program._notaservice.carregar_combo();
            
            TabelaNotas.Columns.Clear();
            
            TabelaNotas.DataSource = resultadoDaTabela;
            if (AtualizarCombo)
            {
                AlunoCombo.DataSource = resultadoDaCombo;
                AtualizarCombo = false;
            }

        }
        private void IrParaCadastroAlunoBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._cadastrodealuno.Show();
        }

        

        private void CalcularMediaTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void CalcularMediaTela_Shown(object sender, EventArgs e)
        {
            BimCombo.SelectedIndex = 0;
        }

        


        private void VoltarAoHubBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._hubtela.Show();
        }
    }
}
