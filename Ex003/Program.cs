using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex003
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("\n");

            Console.WriteLine("Usando for: ");
            for (int i = 1; i <= numero; i++)
            {
                
                Console.WriteLine(i);

            }

            Console.WriteLine("\n");

            Console.WriteLine("Usando While: ");

            int contador = 0;

            while (contador < numero)
            {

                Console.WriteLine(contador + 1);
                contador++;

            }

            Console.WriteLine("\n");

            Console.WriteLine("Lista de frutas: ");

            string[] frutas = {"Maçã", "Banana", "Laranja", "Uva", "Melancia"};

            foreach(string fruta in frutas)
            {

                Console.WriteLine(fruta);

            }

        }
    }
}
