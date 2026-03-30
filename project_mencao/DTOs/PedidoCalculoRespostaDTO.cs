using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
    internal class PedidoCalculoRespostaDTO
    {
        public string Erros { get; set; }
        public decimal Frete { get; set; }
        public decimal ValorFinal { get; set; }

        public PedidoCalculoRespostaDTO(String erros,decimal frete, decimal valorFinal) 
        {
            this.Erros = erros;
            this.Frete = frete;
            this.ValorFinal = valorFinal;
        }
    }
}
