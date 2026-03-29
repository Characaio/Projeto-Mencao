using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.Models
{
    internal class Produto
    {

        private long Id;
        private String Nome;
        private String Descricao;
        private String Marca;
        private String Tipo;
        private decimal Preco;
        public Produto()
        {
        }
        public Produto(String Nome, String Descricao, String Marca, String Tipo, decimal Preco)
        {
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.Preco = Preco;
        }

        public Produto(long Id,String Nome, String Descricao, String Marca, String Tipo, decimal Preco)
        {
            this.Id = Id;
            this.Nome = Nome;
            this.Descricao = Descricao;
            this.Marca = Marca;
            this.Tipo = Tipo;
            this.Preco = Preco;
        }
        public long GetId()
        {
            return Id;
        }
        public String GetNome()
        {
            return Nome;
        }
        public String GetDescricao()
        {
            return Descricao;
        }
        public String GetMarca()
        {
            return Marca;
        }
        public String GetTipo()
        {
            return Tipo;
        }
        public decimal GetPreco()
        {
            return Preco;
        }
    }
}
