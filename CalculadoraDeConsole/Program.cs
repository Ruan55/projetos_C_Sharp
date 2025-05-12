using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool continuar = true;

            // Estrutura de repetição para rodar o programa até que o usuário escolha sair 
            while (continuar) {
                        
                // Menu de opções
                Console.Clear(); // Limpa o console a caso o usuário escolha realizar outra operação
                Console.WriteLine("==== Calculadora ====");
                Console.WriteLine("Escolha uma operação: ");
                Console.WriteLine("1 - Soma (+)");
                Console.WriteLine("2 - Subtração (-)");
                Console.WriteLine("3 - Multiplicação (*)");
                Console.WriteLine("4 - Divisão (/)");
                Console.WriteLine("0 - Sair");

                string opcao = Console.ReadLine();

                // Configuração para caso o usuário deseje sair do programa
                if(opcao == "0")
                {

                    continuar = false;
                    Console.WriteLine("Encerrando o programa....");
                    break;

                }

                // Solicita dois números do usuário
                try
                {

                    // Solicitando o primeiro número ao usuário
                    Console.WriteLine("Digite o primeiro número: ");
                    double primeiroNumero = double.Parse(Console.ReadLine());

                    // Solicitando o segundo número ao usuário
                    Console.WriteLine("Digite o segundo número: ");
                    double segundoNumero = double.Parse(Console.ReadLine());

                    // Váriavel para armazenar o resultado das contas
                    double resultado = 0;

                    // Váriavel para verificar se a operação de divisão é válida
                    bool operacaoValida = true;

                    switch (opcao)
                    {


                        case "1":
                            resultado = primeiroNumero + segundoNumero;
                            break;

                        case "2":
                            resultado = primeiroNumero - segundoNumero; 
                            break;

                        case "3":
                            resultado = primeiroNumero * segundoNumero;
                            break;

                        case "4":


                            // Condicional para garantir que nenhum número seja divisivel por 0
                            if(primeiroNumero != 0 && segundoNumero != 0)
                            {

                                resultado = primeiroNumero / segundoNumero;

                            }

                            else
                            {

                                Console.WriteLine("Erro: Divisão por Zero!!!");
                                operacaoValida = false;

                            }

                            break;

                        // Caso o usuário selecione uma opção inválida, esta mensagem será exibida
                        default:
                            Console.WriteLine("Opção inválida!!!");
                            operacaoValida = false;
                            break;

                    }

                    // Se a operação for válida, o resultado será exibido
                    if (operacaoValida)
                    {

                        Console.WriteLine($"Resultado: {resultado}");

                    }

                }

                // Tratamento de exceção para garantir que apenas números serão digitados
                catch (FormatException)
                {

                    Console.WriteLine("Entrada inválida! Digite apenas números!");

                }

                // Caso o usuário deseje continuar usando o programa, ele ter de pressionar um tecla
                Console.WriteLine("\nPressione qualquer tecla para continuar....");
                Console.ReadKey();
            
            }

        }
    }
}
