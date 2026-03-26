using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Repositories
{
    internal class NotasRepository
    {

        public void postar_nota(Bimestre bimestre, long alunoId, Nota nota)
        {

            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "INSERT INTO notas (NotaFinal,NotaProva,NotaAtividade,NotaComportamento,AlunoId,Bimestre)" +
                    " VALUES (@NotaFinal,@NotaProva,@NotaAtividade,@NotaComportamento,@AlunoId,@Bimestre)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NotaFinal", nota.getNotaFinal());
                    cmd.Parameters.AddWithValue("@NotaProva", nota.getNotaProva());
                    cmd.Parameters.AddWithValue("@NotaAtividade", nota.getNotaAtividade());
                    cmd.Parameters.AddWithValue("@NotaComportamento", nota.getNotaComportamento());
                    cmd.Parameters.AddWithValue("@AlunoId", alunoId);
                    cmd.Parameters.AddWithValue("@Bimestre", bimestre);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public bool nota_ja_existe(long Matricula, Bimestre bimestre)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT COUNT(*) FROM notas WHERE AlunoId = @AlunoId AND Bimestre = @Bimestre";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AlunoId", Matricula);
                    cmd.Parameters.AddWithValue("@Bimestre", bimestre);
                    var count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public void atualizar_nota(Bimestre bimestre,long Alunoid, Nota nota)
        {
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "UPDATE notas " +
                    "SET NotaFinal = @NotaFinal, " +
                    "NotaProva = @NotaProva, " +
                    "NotaAtividade = @NotaAtividade, " +
                    "NotaComportamento = @NotaComportamento " +
                    "WHERE AlunoId = @AlunoId AND Bimestre = @Bimestre";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@NotaFinal", nota.getNotaFinal());
                    cmd.Parameters.AddWithValue("@NotaProva", nota.getNotaProva());
                    cmd.Parameters.AddWithValue("@NotaAtividade", nota.getNotaAtividade());
                    cmd.Parameters.AddWithValue("@NotaComportamento", nota.getNotaComportamento());
                    cmd.Parameters.AddWithValue("@AlunoId", Alunoid);
                    cmd.Parameters.AddWithValue("@Bimestre", bimestre);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public List<Nota> pegar_notas_aluno(Aluno aluno)
        {
            List<Nota> notas = new List<Nota>();
            using (var conn = new DatabaseConnector().GetConnection())
            {
                conn.Open();
                String query = "SELECT * FROM notas WHERE AlunoId = @AlunoId";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@AlunoId", aluno.getMatricula());
                    var reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Nota nota = new Nota(
                            decimal.Parse(reader["NotaProva"].ToString()),
                            decimal.Parse(reader["NotaAtividade"].ToString()),
                            decimal.Parse(reader["NotaComportamento"].ToString()),
                            decimal.Parse(reader["NotaFinal"].ToString()),
                            int.Parse(reader["Bimestre"].ToString()));
                        notas.Add(nota);
                    }
                }
            }
            return notas;
        }
    }
}
