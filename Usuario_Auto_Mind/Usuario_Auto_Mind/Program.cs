using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_Auto_Mind
{
    internal class Program
    {
        
        // Método principal da aplicação, que será executado ao rodar o programa
        static void Main(string[] args)
        {

            // Criação de um objeto GerenciadorUsuarios que será responsável por gerenciar os usuários
            GerenciadorUsuarios gereciarusuarios = new GerenciadorUsuarios();

            // Inicia um loop infinito que será só interrompido quando o usuário escolher a opção '4' (Sair)
            while (true) {

                // Exibe um menu de opções para o usuário
                Console.WriteLine("Escolha uma opção: ");
                Console.WriteLine("1 - Cadastrar usuário");
                Console.WriteLine("2 - Listar usuário");
                Console.WriteLine("3 - Buscar usuário pelo nome");
                Console.WriteLine("4 - Sair");
                Console.WriteLine("Opção: ");

                // Lê a opção escolhida pelo usuário
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine(); // Linha em branco para separar visualmente as opções

                // Switch para tratar as diferentes opção selecionadas pelo usuário
                switch (opcao)
                {

                    case 1:
                        Console.WriteLine("Digite o seu nome: ");
                        string nome = Console.ReadLine();

                        Console.WriteLine("Digite o seu email: ");
                        string email = Console.ReadLine();

                        Console.WriteLine("Digite a sua idade: ");

                        // Tenta converter a entrada para um número inteiro
                        if (int.TryParse(Console.ReadLine(), out int idade)){

                            // Chama o método para cadastrar o usuário na lista
                            gereciarusuarios.cadastrarUsuarios(nome, email, idade);

                        }

                        else
                        {

                            // Caso a idade fornecida não seja válida, exibe uma mensagem de erro
                            Console.WriteLine("Idade inválida! Tente novamente!\n");

                        }

                        break;

                    case 2:

                        // Chama o método que lista todos os usuários cadastrados
                        gereciarusuarios.listarUsuarios();
                        break;

                    case 3:

                        Console.WriteLine("Digite o nome do usuário: ");
                        string buscaNome = Console.ReadLine();

                        // Chama o método para buscar o usuário pelo nome
                        gereciarusuarios.buscarUsuario(buscaNome);
                        break;

                    case 4:

                        // Exibe uma mensagem e encerra o programa
                        Console.WriteLine("Programa encerrado!");
                        return;

                    default:
                        Console.WriteLine("Opção inválida! Tente novamente!\n");
                        break;

                }

            }

        }
    }
}
