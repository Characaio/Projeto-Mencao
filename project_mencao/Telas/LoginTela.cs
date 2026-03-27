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
    public partial class LoginTela : Form
    {
        public LoginTela()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void LoginBot_Click(object sender, EventArgs e)
        {
            String Email = EmailBox.Text;
            String Senha = SenhaBox.Text;

            String Erros = "";

            if (String.IsNullOrWhiteSpace(Email))
            {
                Erros += "O campo email é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(Senha))
            {
                Erros += "O campo senha é obrigatório.\n";
            }

            if (Erros.Equals(""))
            {
                Usuario usuario = new Usuario(Email, Senha);
                if (Program._loginRepo.usuario_existe(usuario))
                {
                    Program._usuarioLogado = Program._loginRepo.pegar_usuario(usuario);
                    MessageBox.Show(
                        "Login realizado com sucesso!",
                        "Ação Bem Sucedida",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Asterisk);
                    this.Hide();
                    Program.ir_para_tela_do_calculo_da_media();
                }
                else
                {
                    MessageBox.Show(
                        "Email ou senha incorretos.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                }
            }
            else
            {
                MessageBox.Show(
                    Erros,
                    "Erro",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void VoltarAoRegistroBot_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._registertela.Show();
        }

        private void LoginTela_Load(object sender, EventArgs e)
        {

        }

        private void LoginTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
