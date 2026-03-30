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
