using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao.Repositories
{
    internal class PedidosRepository
    {

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

        public Pedido carregar_pedido()
        {
            Pedido pedido = new Pedido();

            return pedido;
        }

    }
}
