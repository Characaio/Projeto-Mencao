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

        /// <summary>
        /// <para>Essa função aplica a regra de negócio nos dados do usuario.</para>
        /// <para>Faz o login do usuario APENAS se não houver erros E se ele NÃO existe</para>
        /// </summary>
        /// <param name="usuarioDto">Dados do Usuario para ser cadastrado.</param>
        /// <returns>Retorna os erros de validação ocorridos durante a função, caso não tenha, retorna uma String vazia.</returns>
        public String logar_usuario(UsuarioDTO usuarioDto)
        {
            String Erros = "";

            if (String.IsNullOrWhiteSpace(usuarioDto.Email))
            {
                Erros += "O campo email é obrigatório.\n";
            }
            if (String.IsNullOrWhiteSpace(usuarioDto.Senha))
            {
                Erros += "O campo senha é obrigatório.\n";
            }

            if (Erros.Equals(""))
            {
                Usuario usuario = new Usuario(usuarioDto.Email, usuarioDto.Senha);
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

        /// <summary>
        /// <para>Essa função aplica a regra de negócio nos dados do usuario.</para>
        /// <para>Cadastra o usuario APENAS se não houver erros E se ele NÃO existe</para>
        /// </summary>
        /// <param name="usuarioDto">Dados do Usuario para ser cadastrado.</param>
        /// <returns>Retorna os erros de validação ocorridos durante a função, caso não tenha, retorna uma String vazia.</returns>
        public String cadastrar_usuario(UsuarioDTO loginDto)
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
                if (!Program._loginRepo.usuario_existe(usuario))
                {
                    Program._loginRepo.cadastrar_usuario(usuario);
                    Program._usuarioLogado = usuario;
                } else
                {
                    Erros += "Usuario Ja Existe.";
                }
            }

            return Erros;
        }
        
    }
}
