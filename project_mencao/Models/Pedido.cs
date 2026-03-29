using Org.BouncyCastle.Asn1.Mozilla;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Models
{
    internal class Pedido
    {

        private long IdDoPedido;
        private long IdDoUsuario;
        private long IdDoProduto;
        private int Quantidade;
        private DateTime DataDoPedido;
        public Pedido()
        {
        }

        public Pedido(long IdDoPedido, long IdDoUsuario, long IdDoProduto)
        {
            this.IdDoPedido = IdDoPedido;
            this.IdDoUsuario = IdDoUsuario;
            this.IdDoProduto = IdDoProduto;
        }

        public Pedido(long IdDoPedido, long IdDoUsuario, long IdDoProduto,DateTime DataDoPedido)
        {
            this.IdDoPedido = IdDoPedido;
            this.IdDoUsuario = IdDoUsuario;
            this.IdDoProduto = IdDoProduto;
            this.DataDoPedido = DataDoPedido;
        }

        public Pedido(long IdDoPedido, long IdDoUsuario, long IdDoProduto,int Quantidade, DateTime DataDoPedido)
        {
            this.IdDoPedido = IdDoPedido;
            this.IdDoUsuario = IdDoUsuario;
            this.IdDoProduto = IdDoProduto;
            this.Quantidade = Quantidade;
            this.DataDoPedido = DataDoPedido;
        }

        public long GetIdDoPedido()
        {
            return IdDoPedido;
        }

        public long GetIdDoUsuario()
        {
            return IdDoUsuario;
        }
        public long GetIdDoProduto()
        {
            return IdDoProduto;
        }

        public DateTime GetDataDoPedido()
        {
            return DataDoPedido;
        }

        public int GetQuantidade()
        {
            return Quantidade;
        }
    }
}
