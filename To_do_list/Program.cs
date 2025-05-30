using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; // Permite ler e escrever em arquivos (tarefas.txt)

namespace To_do_list
{
    internal class Program
    {

        // Arquivo onde as tarefas serão salvas
        static string caminhoArquivo = "tarefas.txt"; 

        // Lista de tarefas que será manipulada pelo programa
        static List<string> tarefas = new List<string>();


        static void Main(string[] args)
        {

            // Carrega tarefas do arquivo, se existir
            CarregarTarefas();

            bool continuar = true;

            // Loop principal do menu
            while (continuar)
            {

                // Menu de opções
                Console.Clear();
                Console.WriteLine("===== GERENCIADOR DE TAREFAS =====");
                Console.WriteLine("1 - Ver Tarefas");
                Console.WriteLine("2 - Adicionar Tarefas");
                Console.WriteLine("3 - Remover Tarefas");
                Console.WriteLine("4 - Editar Tarefas");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Selecione uma das opções acima: ");

                string opcoes = Console.ReadLine();

                // Verifica qual ação o usuário escolheu
                switch (opcoes)
                {

                    case "1":
                        ListarTarefas();
                        break;

                    case "2":
                        AdicionarTarefa();
                        break;

                    case "3":
                        RemoverTarefa();
                        break;

                    case "4":
                        EditarTarefa();
                        break;

                    case "0":                        
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }

                // Aguarda o usuário pressionar uma tecla antes de voltar ao menu
                if (continuar)
                {

                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();

                }

            }

            // Salva todas as tarefas no arquivo antes de sair
            SalvarTarefas();

            Console.WriteLine("Programa encerrado....");

        }

        // Carrega as tarefas do arquivo, se ele existir
        static void CarregarTarefas()
        {

            // Caso ele exista...
            if (File.Exists(caminhoArquivo))
            {

                // Lê todas as linhas do arquivo e coloca na lista
                tarefas = new List<string>(File.ReadAllLines(caminhoArquivo));

            }

        }

        // Salva as tarefas no arquivo
        static void SalvarTarefas()
        {

            // Escreve todas as tarefas da lista no arquivo
            File.WriteAllLines(caminhoArquivo, tarefas);

        }

        // Lista todas as tarefas com numeração
        static void ListarTarefas()
        {

            Console.Clear();
            Console.WriteLine("--- TAREFAS ---");

            // Verifica se existem tarefas
            if(tarefas.Count == 0)
            {

                Console.WriteLine("Nenhuma tarefa cadastrada");

            }

            else
            {

                // Mostra cada tarefa numerada
                for(int i = 0; i < tarefas.Count; i++)
                {

                    Console.WriteLine($"{i + 1}. {tarefas[i]}");

                }

            }

        }

        // Adiciona uma nova tarefa
        static void AdicionarTarefa()
        {

            Console.WriteLine("Digite a nova tarefa: ");
            string novaTarefa = Console.ReadLine(); // Lê a descrição
            tarefas.Add(novaTarefa); // Adiciona à lista
            Console.WriteLine("Tarefa adicionada!");

        }

        // Remove uma tarefa a partir do número digitado
        static void RemoverTarefa()
        {

            ListarTarefas(); // Mostra as tarefas atuais

            // Tenta converter a entrada em número e verifica se está dentro dos limites
            if(int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tarefas.Count)
            {

                tarefas.RemoveAt(indice - 1); // Remove a tarefa pelo índice (ajustado para começar em 0)
                Console.WriteLine("Tarefa removida!");

            }

            else
            {

                Console.WriteLine("Número inválido.");

            }

        }

        // Edita um tarefa já existente
        static void EditarTarefa()
        {

            // Mostra as tarefas atuais
            ListarTarefas();

            Console.WriteLine("Digite o número da tarefa para remover: ");

            // Tenta converter a entrada em número e verifica se está dentro dos limites
            if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 1 && indice <= tarefas.Count)
            {

                Console.WriteLine("Digite a nova descrição: ");
                string novaDescricao = Console.ReadLine(); // Nova descrição digitada
                tarefas[indice - 1] = novaDescricao; // Atualiza a tarefa na lista
                Console.WriteLine("Tarefa atualizada!");

            }

            else
            {

                Console.WriteLine("Número inválido!");

            }

        }

    }
}
