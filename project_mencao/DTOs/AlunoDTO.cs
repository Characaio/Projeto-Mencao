using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
    /// <summary>
    /// <para>Classe que representa as informações do aluno.</para>
    /// <para>Ela serve apenas para transportar informações dada para ela, ela não tem nenhuma função alem disso.</para>
    /// </summary>
    internal class AlunoDTO
    {

        public String Nome { get;set;  }
        public String Turma { get;set; }

        public AlunoDTO(String Nome,String Turma) {
            this.Nome = Nome;
            this.Turma = Turma;
        }
    }
}
