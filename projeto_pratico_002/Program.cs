using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace projeto_pratico_002
{
    internal class Program
    {        

        static void Main(string[] args)
        {

            while (true)
            {   

                Console.WriteLine("--- Sistema de Cadastro de Clientes ---");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Listar Clientes");
                Console.WriteLine("3 - Atualizar Clientes");
                Console.WriteLine("4 - Remover Clientes");
                Console.WriteLine("0 - Sair");

                Console.WriteLine("\nEscolha uma das opções acima: ");
                string opcoes = Console.ReadLine();

                Console.Clear();

                switch (opcoes)
                {

                    case "1":
                        CadastrarCliente();
                        break;

                    case "2":
                        ListarClientes();
                        break;

                    case "3":
                        AtualizarClientes();
                        break;

                    case "4":
                        ExcluirClientes();
                        break;

                    case "0":
                        Console.WriteLine("Programa encerrado....");
                        return;

                }

            }

        }

        static List<Cliente> clientes = new List<Cliente>();
        static int novoID = 1;

        // Cadastrar Clientes
        public static void CadastrarCliente()
        {

            Cliente cliente = new Cliente();
            cliente.id = novoID;
            novoID++;

            Console.WriteLine("Digite seu nome: ");
            cliente.nome = Console.ReadLine();

            Console.WriteLine("Digite a sua idade: ");
            cliente.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o seu email: ");
            cliente.email = Console.ReadLine();

            clientes.Add(cliente);

        }

        // Listar os clientes cadastrados
        public static void ListarClientes()
        {

            if (clientes.Count == 0)
            {

                Console.WriteLine("Nenhum usuário cadastrado!");

            }

            else
            {

                Console.WriteLine("\nLista de clientes cadastrados: ");

                foreach (Cliente cliente in clientes)
                {

                    cliente.ExibirDados();
                    Console.WriteLine("---------------");

                }

            }

        }

        // Atualizar dados dos clientes
        public static void AtualizarClientes()
        {

            Console.WriteLine("Digite o ID do cliente que deseja atualizar; ");
            int buscaID = int.Parse(Console.ReadLine());

            // Pra procurar o cliente certo dentro da lista.
            Cliente clienteEncontrado = clientes.Find(c => c.id == buscaID);

            if (clienteEncontrado != null)
            {

                Console.WriteLine("Digite um novo nome: ");
                clienteEncontrado.nome = Console.ReadLine();

                Console.WriteLine("Digite a nova idade: ");
                clienteEncontrado.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o novo email");
                clienteEncontrado.email = Console.ReadLine();

                Console.WriteLine("Dados atualizados com sucesso!");

            }

            else
            {

                Console.WriteLine("Cliente com esse ID não encontrado.");

            }

        }

        // Excluir clientes cadastrados
        public static void ExcluirClientes()
        {

            Console.WriteLine("Digite o ID do cliente que deseja remover: ");
            int removerID = int.Parse(Console.ReadLine());

            // Pra excluir o cliente dentro da lista.
            Cliente clienteRemover = clientes.Find(c => c.id == removerID);

            if (clienteRemover != null)
            {

                clientes.Remove(clienteRemover);
                Console.WriteLine("Cliente removido com sucesso!");

            }

            else
            {

                Console.WriteLine("Cliente com esse ID não encontrado.");

            }

        }

    }
}

