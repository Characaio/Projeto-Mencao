using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao.Repositories
{
    internal class AlunosRepository
    {


        public void criar_aluno_novo(Aluno aluno)
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

        public void atualizar_nota(Aluno aluno, Nota nota)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "UPDATE alunos SET";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@nome", aluno.getNome());
                    cmd.Parameters.AddWithValue("@turma", aluno.getTurma());
                    cmd.ExecuteNonQuery();
                }
            }
        }

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

        public Aluno pegar_aluno_por_id(long id)
        {
            Aluno aluno = null;
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM alunos WHERE AlunoId = @AlunoId";
                using (var cmd = new MySql.Data.MySqlClient.MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AlunoId", id);
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
