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
    public partial class CadastroDeAluno : Form
    {
        public CadastroDeAluno()
        {
            InitializeComponent();
        }

        private void CadastAlunBot_Click(object sender, EventArgs e)
        {
            String Nome = NomeBox.Text;

            Object turmaPura = TurmaCombo.SelectedItem;
            String turma = "";

            String Erros = "";

            if (String.IsNullOrWhiteSpace(Nome))
            {
                Erros += "O campo nome é obrigatório.\n";
            }

            if (turmaPura != null)
            {
                turma = turmaPura.ToString();
            }
            else
            {
                Erros += "O campo turma é obrigatório.\n";
            }

            if (Erros.Equals(""))
            {
                Aluno aluno = new Aluno(Nome, turma);
                Program._alunosRepo.criar_aluno_novo(aluno);
                MessageBox.Show("Cadastro realizado com sucesso!");
            }
            else
            {
                MessageBox.Show(Erros);
            }
        }


        private void IrParaCadastroAlunoBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ir_para_tela_do_calculo_da_media();
        }

        private void CadastroDeAluno_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
