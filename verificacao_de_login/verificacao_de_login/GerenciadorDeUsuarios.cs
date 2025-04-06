using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacao_de_login
{
    internal class GerenciadorDeUsuarios
    {

        // Listando os usuários cadastrados
        private List<Usuario> usuarios = new List<Usuario>();

        // Método para realizar login e senha dos usuários
        public void LoginSenhaUsuario(string nomeUsuario, string senhaUsuario)
        {

            Usuario usuario = new Usuario(nomeUsuario, senhaUsuario);
            usuarios.Add(usuario);
            Console.WriteLine($"Login Bem-sucedido! Bem-vindo {nomeUsuario}");

        }

        // Método para listar os usuários cadastrados
        public void ListarUsuariosCadastrados()
        {

            // Caso não tenha nenhum usuário cadastrado, a função irá exibir esta mensagem
            if(usuarios.Count == 0)
            {

                Console.WriteLine("Não existe nenhum usuário cadastrado no momento!");

            }

            foreach(var usuario in usuarios)
            {

                usuario.exibirInformacoes();

            }

        }

        public bool usuarioExiste(string nomeUsuario)
        {

            return usuarios.Exists(u => u.NomeUsuario == nomeUsuario);

        }

        // Método que verifica se há um nome de usuário existente
        public void verificandoLoginSenhaUsuario(string nomeusuario, string senhausuario)
        {

            // Irá buscar o primeiro usuário da lista com o nome de login fornecido
            var verificandoLoginUsuario = usuarios.FirstOrDefault(u => u.NomeUsuario.Equals(nomeusuario, StringComparison.OrdinalIgnoreCase));
            var verificandoSenhaUsuario = usuarios.FirstOrDefault(u => u.SenhaUsuario.Equals(senhausuario, StringComparison.OrdinalIgnoreCase));

            if(verificandoLoginUsuario != null)
            {

                Console.WriteLine("Este nome de usuário está indisponível! Por favor tente outro");

            }

            if(verificandoSenhaUsuario != null)
            {

                Console.WriteLine("Esta senha de usuário está indisponível! Por favor tente outro!");

            }

        }

    }
}
