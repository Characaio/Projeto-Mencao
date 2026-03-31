using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao
{
    /// <summary>
    /// <para>Classe que representa a entidade Aluno do banco de dados no sistema.</para>
    /// <para>Ela serve para transportar as informações do aluno.</para>
    /// <para>Ela permite a adição de nota para um bimestre e permite pegar a nota de um bimestre</para>
    /// </summary>
    internal class Aluno
    {
        private long Matricula;
        private String Nome;
        private String Turma;
        public String getNome() { return Nome; }
        public String getTurma() { return Turma; }
        public long getMatricula() { return Matricula; }
        public Aluno(String nome, String turma)
        {
            Nome = nome;
            Turma = turma;
        }
        public Aluno(long matricula,String nome, String turma)
        {
            Matricula = matricula;
            Nome = nome;
            Turma = turma;
        }
        private Dictionary<Bimestre, Nota>  Notas = new Dictionary<Bimestre, Nota>
        {
            {Bimestre.Primeiro, null },
            {Bimestre.Segundo, null },
            {Bimestre.Terceiro, null },
            {Bimestre.Quarto, null },
            {Bimestre.Final, null  }
        };
        
        public Nota getPrimeiroBimestre()
        {
            if (Notas[Bimestre.Primeiro] == null)
            {
                return null;
            }
            return Notas[Bimestre.Primeiro];
        }
        public Nota getSegundoBimestre()
        {
            if (Notas[Bimestre.Segundo] == null)
            {
                return null;
            }
            return Notas[Bimestre.Segundo];
        }
        public Nota getTerceiroBimestre()
        {
            if (Notas[Bimestre.Terceiro] == null)
            {
                return null;
            }
            return Notas[Bimestre.Terceiro];
        }
        public Nota getQuartoBimestre()
        {
            if (Notas[Bimestre.Quarto] == null)
            {
                return null;
            }
            return Notas[Bimestre.Quarto];
        }
        public Nota getFinalBimestre()
        {
            if (Notas[Bimestre.Final] == null)
            {
                return null;
            }
            return Notas[Bimestre.Final];

        }
        /// <summary>
        /// Adiciona uma nota com base no bimestre da nota.
        /// Ao adicionar uma nota ja se calcula a nota do bimestre final com base em notas ja adicionadas
        /// </summary>
        /// <param name="nota">Nota para ser inserida</param>
        public void adicionar_Nota(Nota nota)
        {
            
            if(nota == null)
            {
                Notas[(Bimestre)nota.getBimestre()] = null;
                return;
            }
            Notas[(Bimestre)nota.getBimestre()] = nota;

            decimal TempNotaFinal = 0;
            decimal TempQuantidadeDeNotas = 0;
            foreach (Nota notinha in Notas.Values)
            {
                if (notinha != null)
                {
                    TempQuantidadeDeNotas++;
                    TempNotaFinal += notinha.getNotaFinal();
                }
            }
            Notas[Bimestre.Final] = new Nota(
                0,
                0,
                0,
                TempNotaFinal/TempQuantidadeDeNotas,
                (int)Bimestre.Final
                );

                if (!Program._notasRepo.nota_ja_existe(getMatricula(), Bimestre.Final))
                {
                    Program._notasRepo.postar_nota(
                        Bimestre.Final,
                        getMatricula(),
                        Notas[Bimestre.Final]);
                }
                
            }
        
        }
}
