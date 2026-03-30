using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
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
