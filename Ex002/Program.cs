using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a sua idade: ");
            int idadeUsuario = int.Parse(Console.ReadLine());

            if(idadeUsuario < 18)
            {

                Console.WriteLine("Menor de Idade");

            }

            else if(idadeUsuario >= 18 && idadeUsuario <= 59)
            {

                Console.WriteLine("Adulto");

            }

            else
            {

                Console.WriteLine("Idoso");

            }

            Console.WriteLine("\n");

            Console.WriteLine("Escolha um número de 1 a 7");
            int diaDaSemana = int.Parse(Console.ReadLine());

            switch (diaDaSemana)
            {

                case 1:
                    Console.WriteLine("Domingo");
                    break;

                case 2:
                    Console.WriteLine("Segunda-feira");
                    break;

                case 3:
                    Console.WriteLine("Terça-feira");
                    break;

                case 4:
                    Console.WriteLine("Quarta-feira");
                    break;

                case 5:
                    Console.WriteLine("Quinta-feira");
                    break;

                case 6:
                    Console.WriteLine("Sexta-feira");
                    break;

                case 7:
                    Console.WriteLine("Sábado");
                    break;

                default:
                    Console.WriteLine("Dia inválido");
                    break;

            }

        }
    }
}
