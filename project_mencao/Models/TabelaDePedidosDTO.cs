using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Models
{
    /// <summary>
    /// <para>Classe que representa as informações do Hisotrico de Notas.</para>
    /// <para>Ela serve apenas para transportar informações dada para ela, ela não tem nenhuma função alem disso.</para>
    /// </summary>
    internal class TabelaDePedidosDTO
    {

        public long IdDoPedido { get; set; }
        public String NomeDoProduto { get; set; }
        public String NomeDoUsuario { get; set; }
        public int Quantidade { get; set; }
        public DateTime DataDoPedido { get; set; }

        public TabelaDePedidosDTO()
        {
        }

        public TabelaDePedidosDTO(long IdDoPedido, String NomeDoProduto, String NomeDoUsuario, DateTime DataDoPedido, int Quantidade)
        {
            this.IdDoPedido = IdDoPedido;
            this.NomeDoProduto = NomeDoProduto;
            this.NomeDoUsuario = NomeDoUsuario;
            this.DataDoPedido = DataDoPedido;
            this.Quantidade = Quantidade;
        }


    }
}
