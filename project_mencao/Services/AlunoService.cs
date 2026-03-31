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

        /// <summary>
        /// <para>Essa função aplica a regra de negócio nos dados do aluno.</para>
        /// <para>Cadastra o aluno APENAS se não houver erros.</para>
        /// </summary>
        /// <param name="alunoDto">Dados do aluno para ser cadastrado.</param>
        /// <returns>Retorna os erros de validação ocorridos durante a função, caso não tenha, retorna uma String vazia.</returns>
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
            if (Erros.Equals("")) { 
                Program._alunosRepo.cadastrar_aluno(new Aluno(
                    alunoDto.Nome,
                    alunoDto.Turma
                    ));
            }
            return Erros;
        }
    }
}
