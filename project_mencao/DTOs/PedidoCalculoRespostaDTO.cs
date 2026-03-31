using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
    /// <summary>
    /// <para>Classe que representa as informações da tabela de notas.</para>
    /// <para>Ela serve apenas para transportar informações dada para ela, ela não tem nenhuma função alem disso.</para>
    /// </summary>
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
