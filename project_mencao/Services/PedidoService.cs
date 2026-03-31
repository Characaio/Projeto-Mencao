using Mysqlx;
using project_mencao.DTOs;
using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Services
{
    internal class PedidoService
    {

        /// <summary>
        /// <para>Essa função aplica a regra de negócio nos dados do Produto.</para>
        /// <para>Compra o produto e cria o pedido caso NÃO tenha erros</para>
        /// </summary>
        /// <param name="pedidoDTO">Dados do Pedido para ser feito</param>
        /// <param name="produtoDTO">Dados do produto para ser aplicado a regra do negócio</param>
        /// <returns>Retorna os erros de validação ocorridos durante a função, caso não tenha, retorna uma String vazia.</returns>
        public String comprar_produto(ProdutoDTO produtoDTO,PedidoDTO pedidoDTO)
        {
            String Erros = "";

            if(produtoDTO.Estado == null || produtoDTO.Estado.Equals(""))
            {
                Erros += "Selecione um estado para entrega\n";
            }

            if (produtoDTO.Quantidade < 0 )
            {
                Erros += "Digite uma quantidade valida\n";
            }

            if (Erros.Equals(""))
            {
                Program._pedidosrepo.criar_pedido(
                    pedidoDTO.IdDoUsuario,
                    pedidoDTO.IdDoProduto,
                    pedidoDTO.ValorDoPedido,
                    pedidoDTO.Quantidade
                    );
            }
            
            return Erros;
        }

        
    }
}
