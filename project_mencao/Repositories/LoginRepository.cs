using project_mencao.Models;
using project_mencao.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao
{
    /// <summary>
    /// <para>Classe responsavel para conectar o sistema com o banco de dados.</para>
    /// <para>Ela é responsavel sobre os usuarios.</para>
    /// <para>Ela cadastra, loga e verifica o usuario</para>
    /// </summary>
    class LoginRepository
    {



        /// <summary>
        /// <para>Cadastra o usuario com seus dados</para>
        /// </summary>
        /// <param name="usuario">Usuario usado para extrair seus dados</param>
        public void cadastrar_usuario(Usuario usuario)
        {
            try
            {
                using (var conn = new DatabaseConnector().GetConnection())
                {
                    conn.Open();
                    String query = "INSERT INTO usuarios (Nome,Telefone,Email,Senha,MateriaLecionada)" +
                        " VALUES (@Nome,@Telefone,@Email,@Senha,@MateriaLecionada)";
                    using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Nome", usuario.getNome());
                        cmd.Parameters.AddWithValue("@Telefone", usuario.getTelefone());
                        cmd.Parameters.AddWithValue("@Email", usuario.getEmail());
                        cmd.Parameters.AddWithValue("@Senha", usuario.getSenha());
                        cmd.Parameters.AddWithValue("@MateriaLecionada", usuario.getMateriaLecionada());

                        cmd.ExecuteNonQuery();
                        Program._usuarioLogado = usuario;

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Deu Erro: " + ex.Message);
            }
        }
        /// <summary>
        /// <para>Verifica a existencia do usuario</para>
        /// </summary>
        /// <param name="usuario">Usuario usada para extrair informações</param>
        /// <returns></returns>
        public bool usuario_existe(Usuario usuario)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM usuarios WHERE Email = @Email AND Senha = @Senha";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", usuario.getEmail());
                    cmd.Parameters.AddWithValue("@Senha", usuario.getSenha());
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        return true;
                    }

                    return false;

                }
            }

        }

        /// <summary>
        /// <para>Essa função pega o usuario com base em seu Email e Senha</para>
        /// </summary>
        /// <param name="usuario">Usuario usado para extrair o email e senha</param>
        /// <returns></returns>
        public Usuario pegar_usuario(Usuario usuario)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM usuarios WHERE Email = @Email AND Senha = @Senha";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Email", usuario.getEmail());
                    cmd.Parameters.AddWithValue("@Senha", usuario.getSenha());
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Usuario usuarioLogado = new Usuario(
                            reader["Nome"].ToString(),
                            reader["Telefone"].ToString(),
                            reader["Email"].ToString(),
                            reader["Senha"].ToString(),
                            reader["MateriaLecionada"].ToString()
                            );
                        return usuarioLogado;
                    }
                    return null;
                }
            }
        }
    }
}
