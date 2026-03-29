using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Repositories
{
    /// <summary>
    /// <para>Classe responsavel para conectar o sistema com o banco de dados.</para>
    /// <para>Ela é responsavel sobre os Produtos.</para>
    /// <para>Ela cadastra, carrega, pega nome, lista os produtos e cria os produtos base</para>
    /// </summary>
    internal class ProdutosRepository
    {
        /// <summary>
        /// Cadastra um produto com base nos dados entregue
        /// </summary>
        /// <param name="produto">Dados para ser colocado ao banco de dados</param>
        public void cadastrar_produto(Produto produto)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "INSERT INTO produtos (Nome,Descricao,Valor,Marca,Tipo)" +
                    " VALUES (@Nome,@Descricao,@Valor,@Marca,@Tipo)";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", produto.GetNome());
                    cmd.Parameters.AddWithValue("@Descricao", produto.GetDescricao());
                    cmd.Parameters.AddWithValue("@Valor", produto.GetPreco());
                    cmd.Parameters.AddWithValue("@Marca", produto.GetMarca());
                    cmd.Parameters.AddWithValue("@Tipo", produto.GetTipo());
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// Carrega produto os dados do produto com base no Id
        /// </summary>
        /// <param name="ProdutoId">Id do produto</param>
        /// <returns></returns>
        public Produto carregar_produto(long ProdutoId)
        {
            Produto produto = null;

            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM produtos WHERE ProdutoId = @ProdutoId";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            produto = new Produto(
                                reader.GetString("Nome"),
                                reader.GetString("Descricao"),
                                reader.GetString("Marca"),
                                reader.GetString("Tipo"),
                                reader.GetDecimal("Valor")
                                );
                        }
                    }
                }
            }

            return produto;
        }

        /// <summary>
        /// Pega o nome do produto com base no Id dele
        /// </summary>
        /// <param name="ProdutoId">Id do produto</param>
        /// <returns></returns>
        public String pegar_nome_do_produto(long ProdutoId)
        {

            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT Nome FROM produtos WHERE ProdutoId = @ProdutoId";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader.GetString("Nome");
                        }
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Lista todos os produtos retornando com o Id e Nome
        /// </summary>
        /// <returns>Formato da resposta: {ID-NOME}</returns>
        public List<String> listar_produtos()
        {
            List<String> produtos = new List<String>();

            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM produtos";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            String produtoString = String.Format(
                                "{0}-{1}",
                                reader.GetInt64("ProdutoId"), reader.GetString("Nome")
                                );
                            produtos.Add(produtoString);

                        }
                    }
                }
            }

            return produtos;
        }

        /// <summary>
        /// Cria um produto de exemplo para o sistema começar levemente populado
        /// </summary>
        public void criar_produto_base()
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "INSERT INTO produtos (Nome,Descricao,Valor,Marca,Tipo)" +
                    " VALUES (@Nome,@Descricao,@Valor,@Marca,@Tipo)";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", "Item1");
                    cmd.Parameters.AddWithValue("@Descricao", "Descrição do Item1");
                    cmd.Parameters.AddWithValue("@Valor", 10.0m);
                    cmd.Parameters.AddWithValue("@Marca", "Marca do Item1");
                    cmd.Parameters.AddWithValue("@Tipo", "Tipo do Item1");
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Verifica se os valores base existe
        /// </summary>
        /// <returns>Resposta</returns>
        public bool valores_base_existem()
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT COUNT(*) FROM produtos WHERE nome = @Nome";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", "Item1");
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return true;
                        }
                    }
                }

            }
            return false;

        }
    }
}
