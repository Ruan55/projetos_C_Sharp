using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex005
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o primeiro número: ");
            int primeiroNumero = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            int segundoNumero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Resultado da soma: {SomarNumeros(primeiroNumero, segundoNumero)}");

            Console.WriteLine("\n");

            Console.WriteLine("Digite um número para verificar se é par ou impar: ");
            int numeroParOuImpar = int.Parse(Console.ReadLine());

            VerificarParOuImpar(numeroParOuImpar);

        }

       static int SomarNumeros(int primeiroNumero, int segundoNumero)
        {

            return primeiroNumero + segundoNumero;

        }

       static int VerificarParOuImpar(int numero)
        {

            if(numero % 2 == 0)
            {

                Console.WriteLine("O número é par");

            }

            else
            {

                Console.WriteLine("O número é impar");

            }

            return numero;

        }

    }
}
