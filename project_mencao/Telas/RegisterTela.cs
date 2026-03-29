using project_mencao.Models;
using project_mencao.Telas;
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
    public partial class RegisterTela : Form
    {
        public RegisterTela()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Nome = NomeBox.Text;
            String Telefone = TelefoneMBox.Text;
            String Email = EmailBox.Text;
            String Senha = SenhaBox.Text;
            Object MateriaLecionadaObj = MateriaComboBox.SelectedItem;
            String MateriaLecionada = "";

            String Erros = "";

            if (String.IsNullOrWhiteSpace(Nome) ) {
                Erros += "O campo nome é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(Telefone))
            {
                Erros += "O campo telefone é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(Email))
            {
                Erros += "O campo email é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(Senha))
            {
                Erros += "O campo senha é obrigatório.\n";
            }
            if (MateriaLecionadaObj != null)
            {
                MateriaLecionada = MateriaLecionadaObj.ToString();
            }
            else
            {
                Erros += "O campo matéria lecionada é obrigatório.\n";  
            }

            if (Erros.Equals(""))
            {
                Usuario usuario = new Usuario(Nome, Telefone, Email, Senha, MateriaLecionada);

                Program._loginRepo.cadastrar_usuario(usuario);
                Program._usuarioLogado = usuario;
                MessageBox.Show(
                    AcaoResposta.CadastroSucesso,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                this.Hide();
                Program._hubtela.Show();
            }
            else
            {
                MessageBox.Show(
                    Erros,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                return;
            }
        }

        private void BotVoltarRegistro_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._logintela.Show();
        }

        private void RegisterTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
