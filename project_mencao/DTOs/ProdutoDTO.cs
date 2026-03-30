using Org.BouncyCastle.Bcpg.OpenPgp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
    internal class ProdutoDTO
    {
        public String Nome { get; set; }
        public decimal Preco { get; set; }
        public String Descricao { get; set; }
        public String Marca { get; set; }
        public String Tipo { get; set; }
        public String Estado { get; set; }
        public int Quantidade { get; set; }
        public ProdutoDTO(String estado, int quantidade) 
        {
            this.Estado = estado;
            this.Quantidade = quantidade;
        }

        public ProdutoDTO(String Nome, decimal Preco, String Descricao, String Marca, String Tipo) 
        {
            this.Nome = Nome;
            this.Preco = Preco;
            this.Descricao = Descricao;
            this.Marca = Marca;
            this.Tipo = Tipo;
        }
    }
}
