using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Repositories
{
    /// <summary>
    /// <para>Essa clase foi criada para fazer com que a conexão com o banco de dados seja simples</para>
    /// <para>Ela permite que a conexão seja fácil de mudar caso seja necessário</para>
    /// </summary>

    internal class DatabaseConnector
    {
        private String ConnectionString = "" +
            "server=localhost;" +
            "database=ProjetoMencaoCaio;" +
            "user=root;" +
            "password=123123"; //MUDAR A SENHA PARA 123456 PARA ENTREGAR

        
        public MySqlConnection GetConnection()
        {
            return new MySqlConnection(ConnectionString);
        }
    }
}
