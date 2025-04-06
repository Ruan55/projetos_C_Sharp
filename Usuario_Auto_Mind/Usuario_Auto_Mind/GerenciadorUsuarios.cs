using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_Auto_Mind
{
    internal class GerenciadorUsuarios
    {

        // Lista privada que armazena os usuários cadastrados
        private List<Usuario> usuarios = new List<Usuario>();

        // Método para cadastrar um novo usuário
        public void cadastrarUsuarios(string nome, string email, int idade)
        {

            // Cria um novo objeto Usuário com as informações fornecidas
            Usuario usuario = new Usuario(nome, email, idade);

            // Adiciona o novo usuário à lista de usuários
            usuarios.Add(usuario);

            // Exibe uma mensagem informando que o usuário foi cadastrado com sucesso
            Console.WriteLine("Usuário cadastrado com sucesso!\n");
        }

        // Método para listar todos os usuários cadastrados
        public void listarUsuarios()
        {

            // Verifica se a lista de usuários está vazia
            if (usuarios.Count == 0) {

                // Se não houver usuários, exibe uma mensagem informando isso
                Console.WriteLine("Nenhum usuário cadastrado!\n");
                return; // Retorna da função sem fazer mais nada
            
            }

            // Exibe o título para a lista de usuários
            Console.WriteLine("Lista de usuários: ");

            // Percorre cada usuário na lista e chama o método exibirMensagem() para mostrar os dados
            foreach (var usuario in usuarios) { 
            
                usuario.exibirMensagem();
            
            }

            // Exibe uma linha em branco para separar a listagem
            Console.WriteLine();

        }

        // Método para buscar um usuário pelo nome
        public void buscarUsuario(string nome)
        {
            
            // Utiliza o LINQ para buscar o primeiro usuário com o nome fornecido, ignorando maiúsculas/minúsculas
            var usuarioEncontrado = usuarios.FirstOrDefault(u => u.Nome.Equals(nome, StringComparison.OrdinalIgnoreCase));

            // Verifica se o usuário foi encontrado
            if(usuarioEncontrado != null)
            {

                // Se encontrado, exibe as informações do usuário
                Console.WriteLine("Usuário Encontrado!");
                usuarioEncontrado.exibirMensagem();
                Console.WriteLine();

            }

            else
            {

                // Caso não encontre o usuário, exibe uma mensagem informando que ele não foi encontrado
                Console.WriteLine("Usuário não encontrado!");

            }

        }

    }
}
