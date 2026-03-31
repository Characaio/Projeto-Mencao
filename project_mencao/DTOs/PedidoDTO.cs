using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
    /// <summary>
    /// <para>Classe que representa as informações do pedido.</para>
    /// <para>Ela serve apenas para transportar informações dada para ela, ela não tem nenhuma função alem disso.</para>
    /// </summary>
    internal class PedidoDTO
    {
        public long IdDoUsuario { get; set; }
        public long IdDoProduto { get; set; }
        public decimal ValorDoPedido { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorBase { get; set; }
            
        public String Estado { get; set; }
        public PedidoDTO(long idDoUsuario,long idDoProduto, decimal valorDoPedido,int quantidade) 
        {
            this.IdDoUsuario = idDoUsuario;
            this.IdDoProduto = idDoProduto;
            this.ValorDoPedido = valorDoPedido;
            this.Quantidade = quantidade;
        }

        public PedidoDTO(String estado,decimal valorBase, int quantidade)
        {
            this.Estado = estado;
            this.ValorBase = valorBase;
            this.Quantidade = quantidade;
        }
    }
}
