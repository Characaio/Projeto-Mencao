using Org.BouncyCastle.Tls;
using project_mencao.DTOs;
using project_mencao.Models;
using project_mencao.Utilidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project_mencao.Services
{
    internal class ProdutoService
    {


        static Dictionary<String, decimal> ValoresDoFrete = new Dictionary<String, decimal>()
        {
            {"SP", 3},
            {"RJ", 5},
            {"BA", 10}
        };

        public String cadastrar_produto(ProdutoDTO produtoDto)
        {
            String Erros = "";

            if (String.IsNullOrWhiteSpace(produtoDto.Nome))
            {
                Erros += "O nome do produto é obrigatório.\n";
            }

            if (produtoDto.Preco < 0)
            {
                Erros += "Digite um preço válido para o produto.\n";
            }

            if (String.IsNullOrWhiteSpace(produtoDto.Descricao))
            {
                Erros += "A descrição do produto é obrigatória.\n";
            }

            if (String.IsNullOrWhiteSpace(produtoDto.Marca))
            {
                Erros += "A marca do produto é obrigatória.\n";
            }
            if (String.IsNullOrWhiteSpace(produtoDto.Tipo)) {
                Erros += "Selecione um tipo para o produto.\n";
            }

            if (Erros.Equals(""))
            {
                Program._produtosRepo.cadastrar_produto(new Produto(
                    produtoDto.Nome,
                    produtoDto.Descricao,
                    produtoDto.Marca,
                    produtoDto.Tipo,
                    produtoDto.Preco
                    ));
            }

            return Erros;
        }

        public List<TabelaDePedidosDTO> carregar_historico()
        {
            List<Pedido> pedidos = Program._pedidosrepo.listar_pedidos(
                Program._loginRepo.pegar_id_do_usuario(Program._usuarioLogado)
                );
            List<TabelaDePedidosDTO> tabelaDePedidosDTOs = new List<TabelaDePedidosDTO>();
            foreach (Pedido pedido in pedidos)
            {

                TabelaDePedidosDTO linha = new TabelaDePedidosDTO(
                    pedido.GetIdDoPedido(),
                    Program._produtosRepo.pegar_nome_do_produto(pedido.GetIdDoProduto()),
                    Program._loginRepo.pegar_nome_do_usuario(pedido.GetIdDoUsuario()),
                    pedido.GetDataDoPedido(),
                    pedido.GetQuantidade());
                tabelaDePedidosDTOs.Add(linha);
            }

            return tabelaDePedidosDTOs;
        }

        public List<String> atualizar_lista_de_produtos()
        {
            if (Program._produtosRepo.listar_produtos().Count == 0)
            {
                Program._produtosRepo.criar_produto_base();
            }
            return Program._produtosRepo.listar_produtos();
        }

        public PedidoCalculoRespostaDTO calcular_frete(PedidoDTO pedidoDTO)
        {
            String Erros = "";

            decimal Frete = 15;

            if (pedidoDTO.Estado == null || pedidoDTO.Estado.Equals(""))
            {
                Erros += "Selecione Um Estado";
            }

            if (pedidoDTO.Quantidade < 0)
            {
                Erros += "Coloque uma Quantidade Valida";
            }

            bool FreteDiferente = ValoresDoFrete.TryGetValue(pedidoDTO.Estado.Split('-')[0].Trim(), out decimal _Frete);


            if (FreteDiferente)
            {
                Frete = _Frete;
            }

            decimal ValorFinal = (pedidoDTO.ValorBase * pedidoDTO.Quantidade) + Frete;

            return new PedidoCalculoRespostaDTO(
                    Erros,
                    Frete,
                    ValorFinal
                );
        }
    }
}
