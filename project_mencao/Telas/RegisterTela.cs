using project_mencao.DTOs;
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

            String Erros = Program._loginservice.cadastrar_usuario(
                new LoginDTO
                    (
                        NomeBox.Text,
                        TelefoneMBox.Text,
                        EmailBox.Text,
                        SenhaBox.Text,
                        MateriaComboBox.SelectedItem.ToString()
                    )
                );

            

            if (Erros.Equals(""))
            {
                
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
