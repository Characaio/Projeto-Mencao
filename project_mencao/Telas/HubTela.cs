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
    public partial class HubTela : Form
    {
        public HubTela()
        {
            InitializeComponent();
        }

        private void IrParaCalculoDeMedia_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.ir_para_tela_do_calculo_da_media();
        }

        private void IrParaCompraDeProdutos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program._compraprodutostela.limpar_dados();
            Program._compraprodutostela.Show();
            
        }

        private void DeslogarBot_Click(object sender, EventArgs e)
        {
            Program._usuarioLogado = null;
            this.Hide();
            Program._logintela.Show();
            
        }

        private void HubTela_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
