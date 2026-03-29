using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao.Repositories
{
    /// <summary>
    /// <para>Classe responsavel para conectar o sistema com o banco de dados.</para>
    /// <para>Ela é responsavel sobre os Pedidos dos clientes.</para>
    /// <para>Ele cria o pedido, lista os pedidos com base no Id do usuario</para>
    /// </summary>
    internal class PedidosRepository
    {

        /// <summary>
        /// Cria um pedido Com base nas informações dadas
        /// </summary>
        /// <param name="UsuarioId">Id do usuario, FK</param>
        /// <param name="ProdutoId">Id do usuario, FK</param>
        /// <param name="ValorDaCompra">Valor total da compra</param>
        /// <param name="QuantidadeComprada">Quantidade Comprada</param>
        public void criar_pedido(long UsuarioId, long ProdutoId,decimal ValorDaCompra,int QuantidadeComprada)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "INSERT INTO pedidos (UsuarioId,ProdutoId,ValorDaCompra,Quantidade)" +
                    " VALUES (@UsuarioId,@ProdutoId,@ValorDaCompra,@Quantidade)";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                    cmd.Parameters.AddWithValue("@ProdutoId", ProdutoId);
                    cmd.Parameters.AddWithValue("@ValorDaCompra", ValorDaCompra);
                    cmd.Parameters.AddWithValue("@Quantidade", QuantidadeComprada);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// Lista todos os pedidos com base no id do usuario
        /// </summary>
        /// <param name="UsuarioId">Id do Usuario Atual</param>
        /// <returns>Lista com todos os pedidos recolhidos</returns>
        public List<Pedido> listar_pedidos(long UsuarioId)
        {
            List<Pedido> pedidos = new List<Pedido>();

            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM pedidos WHERE UsuarioId = @UsuarioId";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UsuarioId", UsuarioId);
                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            
                            Pedido pedido = new Pedido(
                                reader.GetInt64("PedidoId"),
                                reader.GetInt64("UsuarioId"),
                                reader.GetInt64("ProdutoId"),
                                reader.GetInt32("Quantidade"),
                                reader.GetDateTime("DataDaCompra")
                            );
                            pedidos.Add(pedido);
                        }
                    }
                }
            }

            return pedidos;
        }


    }
}
