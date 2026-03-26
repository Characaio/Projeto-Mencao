using project_mencao.Models;
using project_mencao.Repositories;
using project_mencao.Telas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao
{
    static class Program
    {
        static public LoginTela _logintela;
        static public RegisterTela _registertela;
        static public CalcularMediaTela _calcularmediatela;
        static public CadastroDeAluno _cadastrodealuno;
        static public LoginRepository _loginRepo;
        static public AlunosRepository _alunosRepo;
        static public NotasRepository _notasRepo;
        static public Usuario _usuarioLogado;  
        static public Form _telaAtual;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            _logintela = new LoginTela();
            _registertela = new RegisterTela();
            _calcularmediatela = new CalcularMediaTela();
            _cadastrodealuno = new CadastroDeAluno();
            _loginRepo = new LoginRepository();
            _alunosRepo = new AlunosRepository();
            _notasRepo = new NotasRepository();
            _telaAtual = _registertela;
            Application.Run(_telaAtual);
        }
        public static void ir_para_tela_do_calculo_da_media()
        {
            _calcularmediatela.AtualizarCombo = true;
            _calcularmediatela.atualizar_materia();
            _calcularmediatela.carregar_tabela();
            _calcularmediatela.Show();

        }
    }
}
