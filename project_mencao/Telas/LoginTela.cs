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
            String Erros = Program._loginservice.logar_usuario(
                new LoginDTO(
                        EmailBox.Text,
                        SenhaBox.Text
                    )
                );

            

            if (Erros.Equals(""))
            {                
                MessageBox.Show(
                    AcaoResposta.LoginSucesso,
                    AcaoResposta.Sucesso,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);

                this.Hide();
                Program._hubtela.Show();
                EmailBox.Text = "";
                SenhaBox.Text = "";
            } else if (Erros.Contains("Usuario Inexistente"))
            {
                MessageBox.Show(
                    AcaoResposta.EmailSenhaErro,
                    AcaoResposta.Erro,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }else
                {
                    MessageBox.Show(
                        Erros,
                        AcaoResposta.Erro,
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
