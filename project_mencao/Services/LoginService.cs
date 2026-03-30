using project_mencao.DTOs;
using project_mencao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace project_mencao.Services
{
    internal class LoginService
    {
        public String logar_usuario(LoginDTO loginDto)
        {
            String Erros = "";

            if (String.IsNullOrWhiteSpace(loginDto.Email))
            {
                Erros += "O campo email é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(loginDto.Senha))
            {
                Erros += "O campo senha é obrigatório.\n";
            }

            if (Erros.Equals(""))
            {
                Usuario usuario = new Usuario(loginDto.Email, loginDto.Senha);
                if (Program._loginRepo.usuario_existe(usuario))
                {
                    Program._usuarioLogado = Program._loginRepo.pegar_usuario(usuario);
                }
                else
                {
                    Erros += "Usuario Inexistente \n";
                }
            }
            return Erros;
        }
        public String cadastrar_usuario(LoginDTO loginDto)
        {
            String Erros = "";

            if (String.IsNullOrWhiteSpace(loginDto.Nome))
            {
                Erros += "O campo nome é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(loginDto.Telefone))
            {
                Erros += "O campo telefone é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(loginDto.Email))
            {
                Erros += "O campo email é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(loginDto.Senha))
            {
                Erros += "O campo senha é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(loginDto.MateriaLecionada) || loginDto.MateriaLecionada == null)
            {
                Erros += "O campo matéria lecionada é obrigatório.\n";
            }

            if (Erros.Equals(""))
            {
                Usuario usuario = new Usuario(
                    loginDto.Nome,
                    loginDto.Telefone,
                    loginDto.Email,
                    loginDto.Senha,
                    loginDto.MateriaLecionada);

                Program._loginRepo.cadastrar_usuario(usuario);
                Program._usuarioLogado = usuario;
            }

            return Erros;
        }
        
    }
}
