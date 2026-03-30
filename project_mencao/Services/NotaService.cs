using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Services
{
    internal class NotaService
    {
        static bool AtualizarCombo = false;
        public List<TableDataNotasDTO> carregar_tabela() 
        {
            List<TableDataNotasDTO> resultadoDaTabela = new List<TableDataNotasDTO>();
            List<String> resultadoDaCombo = new List<String>();
            List<Aluno> alunos = Program._alunosRepo.pegar_alunos();

            foreach (Aluno aluno in alunos)
            {
                TableDataNotasDTO linha = new TableDataNotasDTO();
                linha.Matricula = aluno.getMatricula();
                linha.Nome = aluno.getNome();
                List<Nota> notas = Program._notasRepo.pegar_notas_aluno(aluno);
                foreach (Nota nota in notas)
                {
                    aluno.adicionar_Nota(nota);
                }
                Nota Bim1 = aluno.getPrimeiroBimestre();
                Nota Bim2 = aluno.getSegundoBimestre();
                Nota Bim3 = aluno.getTerceiroBimestre();
                Nota Bim4 = aluno.getQuartoBimestre();
                Nota BimFinal = aluno.getFinalBimestre();

                if (Bim1 != null)
                {
                    linha.Nota1Bim = Bim1.getNotaFinal();
                }
                else
                {
                    linha.Nota1Bim = 0;
                }


                if (Bim2 != null)
                {
                    linha.Nota2Bim = Bim2.getNotaFinal();
                }
                else
                {
                    linha.Nota2Bim = 0;
                }


                if (Bim3 != null)
                {
                    linha.Nota3Bim = Bim3.getNotaFinal();
                }
                else
                {
                    linha.Nota3Bim = 0;
                }


                if (Bim4 != null)
                {
                    linha.Nota4Bim = Bim4.getNotaFinal();
                }
                else
                {
                    linha.Nota4Bim = 0;
                }


                if (BimFinal != null)
                {
                    linha.NotaFinal = BimFinal.getNotaFinal();
                }
                else
                {
                    linha.NotaFinal = 0;
                }
                resultadoDaTabela.Add(linha);
                String linhaCombo = String.Format("{0} {1}", aluno.getMatricula(), aluno.getNome());
                resultadoDaCombo.Add(linhaCombo);

            }

            return resultadoDaTabela;
            
        }

        public List<String> carregar_combo()
        {
            List<String> resultadoDaCombo = new List<String>();
            List<Aluno> alunos = Program._alunosRepo.pegar_alunos();

            foreach (Aluno aluno in alunos)
            { 
                String linhaCombo = String.Format("{0} {1}", aluno.getMatricula(), aluno.getNome());
                resultadoDaCombo.Add(linhaCombo);
            }

            return resultadoDaCombo;
        }
    }
}
