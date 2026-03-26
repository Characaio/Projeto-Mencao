using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Models
{
    internal class  TableDataDTO
    {
        public long Matricula { get; set; }
        public String Nome { get; set; }
        public decimal Nota1Bim { get; set; }
        public decimal Nota2Bim { get; set; }
        public decimal Nota3Bim { get; set; }
        public decimal Nota4Bim { get; set; }
        public decimal NotaFinal { get; set; }
    }
}
