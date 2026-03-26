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

namespace project_mencao
{
    public partial class CalcularMediaTela : Form
    {
        public CalcularMediaTela()
        {
            InitializeComponent();
        }

        private void CalcularMediaTela_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        



        private Dictionary<String, Bimestre> BimStrParaBimEnum = new Dictionary<String, Bimestre> {
            {"1ºBimestre", Bimestre.Primeiro},
            {"2ºBimestre", Bimestre.Segundo},
            {"3ºBimestre", Bimestre.Terceiro},
            {"4ºBimestre", Bimestre.Quarto}
        };
        public bool AtualizarCombo = false;
        private void PostarButton_Click(object sender, EventArgs e)
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

            Nota nota = new Nota(NotaProva, NotaAtiv, NotaComp);
            if (Program._notasRepo.nota_ja_existe(AlunoId, bimestre)){
                Program._notasRepo.atualizar_nota(
                    bimestre,
                    AlunoId,
                    nota);
            }
            else
            {
                Program._notasRepo.postar_nota(
                    bimestre,
                    AlunoId,
                    nota);
            }

            carregar_tabela();
        }
        
        public void atualizar_materia()
        {
            NotaPlaceHolderLabel.Text = "Nota Da Matéria: " + Program._usuarioLogado.getMateriaLecionada();
        }
        public void carregar_tabela()
        {
            List<TableDataDTO> resultadoDaTabela = new List<TableDataDTO>();
            List<String> resultadoDaCombo = new List<String>();
            List<Aluno> alunos = Program._alunosRepo.pegar_alunos();

            foreach (Aluno aluno in alunos)
            {
                TableDataDTO linha = new TableDataDTO();
                linha.Matricula = aluno.getMatricula();
                linha.Nome = aluno.getNome();
                List<Nota> notas = Program._notasRepo.pegar_notas_aluno(aluno);
                foreach (Nota nota in notas)
                {
                    aluno.adicionar_Nota(nota);
                }
                Nota Bim1 = aluno.getPrimeiroBimestre();
                Nota Bim2 = aluno.getSegundoBimestre();
                Nota Bim3 = aluno.getTerceiroBimestre();
                Nota Bim4 = aluno.getQuartoBimestre();
                Nota BimFinal = aluno.getFinalBimestre();

                if (Bim1 != null)
                {
                    linha.Nota1Bim = Bim1.getNotaFinal();
                }
                else
                {
                    linha.Nota1Bim = 0;
                }


                if (Bim2 != null){
                    linha.Nota2Bim = Bim2.getNotaFinal();
                }
                else
                {
                    linha.Nota2Bim = 0;
                }


                if (Bim3 != null){
                    linha.Nota3Bim = Bim3.getNotaFinal();
                }
                else
                {
                    linha.Nota3Bim = 0;
                }


                if (Bim4 != null){
                    linha.Nota4Bim = Bim4.getNotaFinal();
                }
                else
                {
                    linha.Nota4Bim = 0;
                }


                if (BimFinal != null)
                {
                    linha.NotaFinal = BimFinal.getNotaFinal();
                }
                else
                {
                    linha.NotaFinal = 0;
                }
                resultadoDaTabela.Add(linha);
                String linhaCombo = String.Format("{0} {1}", aluno.getMatricula(), aluno.getNome());
                resultadoDaCombo.Add(linhaCombo);
                
            }
            TabelaNotas.Columns.Clear();
            resultadoDaCombo.Reverse();
            resultadoDaTabela.Reverse();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CalcularMediaTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
