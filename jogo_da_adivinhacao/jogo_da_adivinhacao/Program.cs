using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jogo_da_adivinhacao
{
    internal class Program
    {

        static int recorde = int.MaxValue; // Inicia com um valor muito alto

        static void Main(string[] args)
        {

            Random random = new Random(); // Gera números aleatórios
            int numeroSecreto = random.Next(1, 101); // Número entre 1 e 100
            int tentativas = 0, maxTentativas = 10, palpite = 0;

            // Menu para o usuário selecionar a dificuldade que deseja
            Console.WriteLine("Bem-vindo ao jogo da adivinhação!");
            Console.WriteLine("Escolha a dificulade:");
            Console.WriteLine("1 - Fácil (15 tentativas)");
            Console.WriteLine("2 - Médio (10 tentativas)");
            Console.WriteLine("3 - Difícil (5 tentativas)");
            Console.WriteLine("Selecione uma dificuldade: ");

            int dificulade = int.Parse(Console.ReadLine());

            // Configurando o número de tentativas baseados na dificuldade
            switch (dificulade) {

                case 1:
                    maxTentativas = 15;
                    break;
                case 2:
                    maxTentativas = 10;
                    break;
                case 3:
                    maxTentativas = 5;
                    break;
                default:
                    Console.WriteLine("Dificuldade inválida! Definido como médio.");
                    break;
            
            }

            Console.WriteLine($"\nVocê têm {maxTentativas} tentativas para adivinhar um número entre 1 a 100");

            // Enquanto o usuário não acertar o número secreto, o programa irá contabilizar o número de tentativas
            while (palpite != numeroSecreto && tentativas < maxTentativas) {

                Console.WriteLine("Digite o seu palpite: ");

                // Condicional para verificar se o usuário acertou o número secreto
                if (int.TryParse(Console.ReadLine(), out palpite)) {

                    // Contabilizando o número de tentativas, contanto que o número seja inteiro
                    tentativas++;

                    if (palpite < numeroSecreto)
                    {

                        Console.WriteLine($"O número secreto é maior do que esse! Restam {maxTentativas - tentativas} tentativas");

                    }

                    else if (palpite > numeroSecreto)
                    {

                        Console.WriteLine($"O número secreto é menor do que esse! Restam {maxTentativas - tentativas} tentativas");

                    }

                    else {

                        Console.WriteLine($"Parabéns!!! Você acertou o número {numeroSecreto} em {tentativas} tentativas");


                        // Se o usuário bater o recorde, esta mensagem será exibida
                        if(tentativas < recorde)
                        {

                            recorde = tentativas;
                            Console.WriteLine($"Novo recorde: {recorde} tentativas!!!");

                        }
                        return;
                    
                    }
                
                }

                // Caso o usuário digite um número inválido, esta mensagem será exibida
                else
                {

                    Console.WriteLine("Entrada inválida! Digite um número inteiro!");

                }
            }

            // Se o usuário errar todas as tentativas, esta mensagem será exibida
            if(palpite != numeroSecreto)
            {

                Console.WriteLine($"\nVocê perdeu! O número era {numeroSecreto}. Tente novamente!");

            }

        }
    }
}
