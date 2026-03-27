using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao
{
    /// <summary>
    /// <para>Classe que representa a nota do aluno no sistema.</para>
    /// <para>Ela serve para transportar as informações da nota do aluno.</para>
    /// <para>Ela permite a extração de campos como a nota da prova, nota da atividade, nota de comportamento e a nota final.</para>
    /// <para>A nota final É calculada com base nas outras notas mas pode ser passada unicamente no caso de ser a nota final do aluno.</para>
    /// </summary>
    internal class Nota
    {
        private decimal NotaFinal;
        private decimal NotaProva;
        private decimal NotaAtividade;
        private decimal NotaComportamento;
        private int Bimestre;
        public decimal getNotaFinal() { return Math.Round(NotaFinal,2); }
        public decimal getNotaProva() { return NotaProva; }
        public decimal getNotaAtividade() { return NotaAtividade; }
        public decimal getNotaComportamento() { return NotaComportamento; }
        public int getBimestre() { return Bimestre; }
        public Nota(decimal notaProva, decimal notaAtiv, decimal notaComp)
        {
            NotaProva = notaProva;
            NotaAtividade = notaAtiv;
            NotaComportamento = notaComp;
            NotaFinal = (NotaProva + NotaAtividade + NotaComportamento) / 3;
        }

        public Nota(decimal notaProva, decimal notaAtiv, decimal notaComp,int bimestre)
        {
            NotaProva = notaProva;
            NotaAtividade = notaAtiv;
            NotaComportamento = notaComp;
            NotaFinal = (NotaProva + NotaAtividade + NotaComportamento) / 3;
            Bimestre = bimestre;
        }

        public Nota(decimal notaProva, decimal notaAtiv, decimal notaComp,decimal notaFinal, int bimestre)
        {
            NotaProva = notaProva;
            NotaAtividade = notaAtiv;
            NotaComportamento = notaComp;
            NotaFinal = notaFinal;
            Bimestre = bimestre;
        }



    }
}
