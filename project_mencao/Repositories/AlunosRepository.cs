using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao.Repositories
{

    /// <summary>
    /// <para>Classe Responsavel para cuidar da conexão entre o sistema e o banco de dados. </para>
    /// <para>Ela serve para cuidar dos alunos.</para>
    /// <para>Ela cadastra, pega todos os alunos e pega um aluno com base em seu ID</para>
    /// </summary>
    internal class AlunosRepository
    {

        /// <summary>
        /// <para>Cadastra um novo aluno para o sistema</para>
        /// </summary>
        /// <param name="aluno">Aluno para ser cadastrado</param>
        public void cadastrar_aluno(Aluno aluno)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "INSERT INTO alunos (Nome,Turma) VALUES (@Nome,@Turma)";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", aluno.getNome());
                    cmd.Parameters.AddWithValue("@turma", aluno.getTurma());
                    cmd.ExecuteNonQuery();
                }
            }

        }




        /// <summary>
        /// <para>Pega todos alunos em ordem alfabetica</para>
        /// </summary>
        /// <returns>Retorna uma lista com todos os alunos em ordem alfabetica</returns>
        public List<Aluno> pegar_alunos()
        {
            List<Aluno> alunos = new List<Aluno>();
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM alunos ORDER BY Nome";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Aluno aluno = new Aluno(
                            long.Parse(reader["AlunoId"].ToString()),
                            reader["Nome"].ToString(),
                            reader["Turma"].ToString());
                        alunos.Add(aluno);
                    }
                }
            }
            return alunos;
        }

        /// <summary>
        /// <para>Pega um aluno com base em seu ID</para>
        /// </summary>
        /// <param name="Matricula">Matricula do aluno</param>
        /// <returns>Aluno que foi encontrado</returns>
        public Aluno pegar_aluno_por_id(long Matricula)
        {
            Aluno aluno = null;
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM alunos WHERE AlunoId = @AlunoId";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AlunoId", Matricula);
                    var reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        aluno = new Aluno(
                            long.Parse(reader["AlunoId"].ToString()),
                            reader["Nome"].ToString(),
                            reader["Turma"].ToString());
                    }
                }
            }
            return aluno;
        }
    }
}
