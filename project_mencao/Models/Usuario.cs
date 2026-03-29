using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;
using Org.BouncyCastle.Crypto.Generators;
namespace project_mencao.Models
{
    /// <summary>
    /// <para>Classe que representa o usuario no sistema.</para>
    /// <para>Ela serve para transportar informações tanto do banco de dados para o sistema e vice-versa</para>
    /// </summary>
    internal class Usuario
    {
        static private String Salt = "ProjectMencaoCaio";
        private String Nome { get; set; }
        private String Telefone { get; set; }
        private String Email { get; set; }
        private String Senha { get; set; }
        private String MateriaLecionada { get; set; }

        public Usuario(String Nome, String Telefone, String Email, String Senha, String MateriaLecionada)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Senha = converter_para_hash(Senha);
            this.MateriaLecionada = MateriaLecionada;
        }
        public Usuario(String Email, String Senha)
        {
            this.Email = Email;
            this.Senha = converter_para_hash(Senha);
        }

        private String converter_para_hash(String Senha)
        {
            return Senha;
            //return BCrypt.Net.BCrypt.HashPassword(Senha);
        }
        public String getNome() { return Nome; }
        public String getTelefone() {return Telefone;}
        public String getEmail() { return Email; }

        public String getSenha() { return Senha;}
        public String getMateriaLecionada() { return MateriaLecionada; }

    }
}
