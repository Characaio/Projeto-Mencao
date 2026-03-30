using project_mencao.DTOs;
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
    public partial class CadastroDeAluno : Form
    {
        public CadastroDeAluno()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Essa função extrai os dados da tela do cadastro, valida os dados e, caso estejam corretos, cadastra o aluno
        /// </summary>
        private void fazer_cadastro()
        {


            String Erros = Program._alunoservice.cadastrar_aluno(
                new AlunoDTO(
                    NomeBox.Text,
                    TurmaCombo.SelectedItem.ToString()
                ));

            if (Erros.Equals(""))
            {
                MessageBox.Show(
                    AcaoResposta.AlunoCriado,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show(
                    Erros,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            NomeBox.Text = null;
            TurmaCombo.SelectedItem = 0;
        }
        private void CadastAlunBot_Click(object sender, EventArgs e)
        {
            fazer_cadastro();
            
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

        private void TurmaCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CadastroDeAluno_Load(object sender, EventArgs e)
        {
            
        }

        private void CadastroDeAluno_Shown(object sender, EventArgs e)
        {
            TurmaCombo.SelectedIndex = 0;
        }
    }
}
