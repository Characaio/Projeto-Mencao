using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Repositories
{
    /// <summary>
    /// <para>Classe responsavel para cuidar da conexão entre o sistema e o banco de dados.</para>
    /// <para>Ela é responsavel de cuidar das notas dos alunos.</para>
    /// <para>Ela posta, atualiza,verifica existencia e pega as notas dos alunos.</para>
    /// </summary>
    internal class NotasRepository
    {

        /// <summary>
        /// <para>Posta a nota com base em seu Bimestre, Id do aluno e a nota</para>
        /// </summary>
        /// <param name="bimestre">Bimestre atual, o bimestre 5 representa o bimestre final</param>
        /// <param name="Matricula">Id do aluno</param>
        /// <param name="nota">Nota para ser postada</param>
        public void postar_nota(Bimestre bimestre, long Matricula, Nota nota)
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
                    cmd.Parameters.AddWithValue("@AlunoId", Matricula);
                    cmd.Parameters.AddWithValue("@Bimestre", bimestre);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// <para>Verifica a existencia de uma nota puxando as notas que bate com o Id do aluno e bimestre selecionado</para>
        /// </summary>
        /// <param name="Matricula">Id do aluno</param>
        /// <param name="bimestre"></param>
        /// <returns></returns>
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

        /// <summary>
        /// <para>Atualiza os dados da nota, essa função sobreescreve a nota que estava la</para>
        /// </summary>
        /// <param name="bimestre">Bimestre usada para atualizar a nota, o bimestre 5 é a nota final</param>
        /// <param name="Matricula">Id do Aluno</param>
        /// <param name="nota">Nota do bimestre</param>
        public void atualizar_nota(Bimestre bimestre,long Matricula, Nota nota)
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
                    cmd.Parameters.AddWithValue("@AlunoId", Matricula);
                    cmd.Parameters.AddWithValue("@Bimestre", bimestre);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        /// <summary>
        /// <para>Pega as notas de todos os bimestres do aluno</para>
        /// </summary>
        /// <param name="aluno">Aluno usado para extair sua matricula</param>
        /// <returns>Lista com todas as notas do aluno</returns>
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
