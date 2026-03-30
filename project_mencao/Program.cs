using project_mencao.Models;
using project_mencao.Repositories;
using project_mencao.Services;
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
        static public ComprarProdutosTela _compraprodutostela;
        static public HubTela _hubtela;
        static public CadastroProdutosTela _cadastroprodutostela;
        static public HistoricoProdutoTela _historicoprodutostela;
        

        static public AlunosRepository _alunosRepo;
        static public LoginRepository _loginRepo;
        static public NotasRepository _notasRepo;
        static public PedidosRepository _pedidosrepo;
        static public ProdutosRepository _produtosRepo;

        static public AlunoService _alunoservice;
        static public LoginService _loginservice;
        static public NotaService _notaservice;
        static public PedidoService _pedidoservice;
        static public ProdutoService _produtoservice;

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
            _hubtela = new HubTela();
            _compraprodutostela = new ComprarProdutosTela();
            _cadastroprodutostela = new CadastroProdutosTela();
            _historicoprodutostela = new HistoricoProdutoTela();

            _alunoservice= new AlunoService();
            _loginservice= new LoginService();
            _notaservice= new NotaService();
            _pedidoservice= new PedidoService();
            _produtoservice= new ProdutoService();

            _loginRepo = new LoginRepository();
            _alunosRepo = new AlunosRepository();
            _notasRepo = new NotasRepository();
            _produtosRepo = new ProdutosRepository();
            _pedidosrepo = new PedidosRepository();


            _telaAtual = _registertela;
            Application.Run(_telaAtual);
        }

        /// <summary>
        /// Simples função que muda a tela para a tela do calculo de media.
        /// Ela permite que a combobox só seja atualizada quando essa função for chamada
        /// </summary>
        public static void ir_para_tela_do_calculo_da_media()
        {
            _calcularmediatela.AtualizarCombo = true;
            _calcularmediatela.atualizar_materia();
            _calcularmediatela.carregar_tabela();
            _calcularmediatela.Show();

        }
    }
}
