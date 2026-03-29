using Mysqlx;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Utilidades
{
    /// <summary>
    /// Classe com constantes para representar respostas de uma MessageBox, facilitando a leitura e modificação de codigo
    /// </summary>
    internal class AcaoResposta
    {
        public static String Erro = "Erro";
        public static String Sucesso = "Ação Bem Sucedida";
        public static String Atencao = "Atenção";
        public static String Informacao = "Informação";

        public static String AlunoCriado = "Cadastrado Do Aluno Realizado Com Sucesso";

        public static String NotaPostada = "Nota Postada";
        public static String NotaAtualizada = "Nota Atualizada";

        public static String ProdutoCadastrado = "Produto Cadastrado com Sucesso";
        public static String ProdutoComprado = "Produto comprado com Sucesso";
        public static String SelecioneProduto = "Selecione um produto para carregar";

        public static String SucessoAtualizacao = "Atualização Bem Sucedida";

        public static String CadastroSucesso = "Cadastro realizado com sucesso!";
        public static String LoginSucesso = "Login realizado com sucesso!";
        public static String EmailSenhaErro = "Email ou senha incorretos.";

    }
}
