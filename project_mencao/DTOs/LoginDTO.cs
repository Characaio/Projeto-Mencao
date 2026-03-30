using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mencao.DTOs
{
    internal class LoginDTO
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Senha { get; set; }
        public String MateriaLecionada { get; set; }


        public LoginDTO(String Email, String Senha)
        {
            this.Email = Email;
            this.Senha = Senha;
        }

        public LoginDTO(String Nome, String Telefone, String Email, String Senha, String MateriaLecionada)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;
            this.Email = Email;
            this.Senha = Senha;
            this.MateriaLecionada = MateriaLecionada;
        }
    }
}
