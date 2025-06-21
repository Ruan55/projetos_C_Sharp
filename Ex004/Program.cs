using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex004
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5];

            Console.WriteLine("Digite 5 números: ");

            for(int i = 0; i < numeros.Length; i++)
            {

                numeros[i] = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("\n");

            Console.WriteLine("Número digitados: ");
            foreach (int numero in numeros)
            {
                
                Console.WriteLine(numero);

            }

            Console.WriteLine("\n");

            int[,] matriz = new int[2, 3];

            matriz[0, 0] = 1;
            matriz[0, 1] = 2;
            matriz[0, 2] = 3;
            matriz[1, 0] = 4;
            matriz[1, 1] = 5;
            matriz[1, 2] = 6;

            Console.WriteLine("Matriz: ");
            for(int i = 0; i < 2; i++)
            {

                for(int j = 0; j < 3; j++)
                {

                    Console.Write(matriz[i, j] + " ");

                }
                Console.WriteLine();

            }

        }
    }
}
