using project_mencao.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Services
{
    internal class AlunoService
    {

        public String cadastrar_aluno(AlunoDTO alunoDto)
        {
            String Erros = "";

            if (String.IsNullOrWhiteSpace(alunoDto.Nome))
            {
                Erros += "O campo nome é obrigatório.\n";
            }

            if (alunoDto.Turma == null || alunoDto.Turma.Equals(""))
            {
                Erros += "O campo turma é obrigatório.\n";
            }

            Program._alunosRepo.cadastrar_aluno(new Aluno(
                alunoDto.Nome,
                alunoDto.Turma
                ));

            return Erros;
        }
    }
}
