using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ex009
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<string> frasesUsuario = new List<string>();

            for(int i = 1; i <= 5; i++)
            {

                Console.WriteLine($"Digite a frase {i}: ");
                string frases = Console.ReadLine();
                frasesUsuario.Add(frases);

            }

            string caminhoArquivo = "frases.txt";

            // Salvar todas as frases no arquivo de uma vez
            File.WriteAllLines(caminhoArquivo, frasesUsuario);

            Console.WriteLine("\nConteúdo do arquivo frase.txt: ");

            // Ler e exibir o conteudo
            string[] linhasArquivo = File.ReadAllLines(caminhoArquivo);

            foreach(string linha in linhasArquivo)
            {

                Console.WriteLine(linha);

            }

        }
    }
}
