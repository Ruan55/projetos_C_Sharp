using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorDeMoeda
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Variável para representar uma condição
            bool continuar = true;

            // Loop infinito para rodar o programa até quando o usuário desejar
            while (continuar)
            {

                // Menu de opções
                Console.Clear();
                Console.WriteLine("=== Conversor ===");
                Console.WriteLine("1 - Conversor de Temperatura");
                Console.WriteLine("2 - Conversor de Moeda");
                Console.WriteLine("0 - Sair");
                Console.WriteLine("Selecione uma opção: ");
                string opcao = Console.ReadLine();

                switch (opcao) {

                    case "1":
                        converterTemperatura();
                        break;

                    case "2":
                        converterMoeda();
                        break;

                    case "0":
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opção inválida");
                        break;

                }

                // Caso o usuário deseja continuar no programa, ele deverá pressionar uma tecla qualquer
                if (continuar)
                {

                    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu...");
                    Console.ReadKey();

                }

            }

            // Mensagem que será exibida caso o usuário encerre o programa
            Console.WriteLine("Encerrando o programa...");

        }

        // Função para converter a temperatura
        static void converterTemperatura()
        {

            // Menu de opções para conversão de temperatura
            Console.Clear();
            Console.WriteLine("---- Conversor de temperatura ----");
            Console.WriteLine("1 - Celsius para Fahrenheit");
            Console.WriteLine("2 - Celsius para Kelvin");
            Console.WriteLine("3 - Fahrenheit para Celsius");
            Console.WriteLine("Selecione uma das opções acima: ");
            string escolhaTemperatura = Console.ReadLine();

            // Iniciando o processo de tratamento de erros na função para converter a temperatura
            try
            {

                // Solicitando o valor que o usuário deseja converter
                Console.WriteLine("Digite o valor da temperatura");
                double valorTemperatura = double.Parse(Console.ReadLine());
                double resultadoTemperatura = 0;

                switch (escolhaTemperatura)
                {

                    case "1":
                        // Calculo para a conversão de Celsius para Fahrenheit
                        resultadoTemperatura = (valorTemperatura * 9 / 5) + 32;
                        Console.WriteLine($"Resultado: {resultadoTemperatura} ºF");
                        break;

                    case "2":
                        // Calculo para a conversão de Celsius para Kelvin
                        resultadoTemperatura = valorTemperatura + 273.15;
                        Console.WriteLine($"Resultado: {resultadoTemperatura} K");
                        break;

                    case "3":
                        // Calculo para a conversão de Fahrenheit para Celsius
                        resultadoTemperatura = (valorTemperatura - 32) * 5 / 9;
                        Console.WriteLine($"Resultado: {resultadoTemperatura} °C");
                        break;

                        // Caso nenhuma conversão seja válida, esta mensagem será exibida
                    default:
                        Console.WriteLine("Conversão inválida!");
                        break;

                }

            }

            // Finalizando o tratamento de erros na função para converter a temperatura
            catch (FormatException)
            {

                Console.WriteLine("Formato inválido! Digite um número...");

            }

        }

        // Função para converter a moeda
        static void converterMoeda()
        {

            // Menu de opções
            Console.Clear();
            Console.WriteLine("---- Conversor de moeda ----");
            Console.WriteLine("1 - Real para Dolar");
            Console.WriteLine("2 - Real para euro");
            Console.WriteLine("Selecione uma das opções acima: ");
            string escolhaMoeda = Console.ReadLine();

            // Iniciando o processo de tratamento de erros para a função de converter moeda
            try
            {

                // Solicitando o valor que o usuário deseja converter
                Console.WriteLine("Digite o valor em Reais(BRL): ");
                double valorMoeda = double.Parse(Console.ReadLine());

                // Valores base das moedas
                const double TAXADOLAR = 5.67;
                const double TAXAEURO = 6.41;

                switch (escolhaMoeda)
                {

                    case "1":
                        // Calculo para conversão de Real para Dolar
                        Console.WriteLine($"Resultado: {(valorMoeda / TAXADOLAR):F2} USD");
                        break;

                    case "2":
                        // Calculo para conversão de Real para Euro
                        Console.WriteLine($"$Resultado: {(valorMoeda / TAXAEURO):F2} EUR");
                        break;

                    default:
                        // Caso nenhuma conversão seja válida, esta mensagem será exibida
                        Console.WriteLine("Conversão inválida!");
                        break;

                }
            }

            // Finalizando o tratamento de erros na função para converter moeda
            catch (FormatException) {

                Console.WriteLine("Entrada inválida");
            
            }

        }

    }
}
