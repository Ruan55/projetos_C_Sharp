using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex006
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Carro carro1 = new Carro();
            Carro carro2 = new Carro();

            carro1.marca = "Toyota";
            carro1.modelo = "Corolla";
            carro1.ano = 2020;

            carro2.marca = "Honda";
            carro2.modelo = "Civic";
            carro2.ano = 2018;

            Console.WriteLine("Carro 1: ");
            carro1.ExibirInformacoes();

            Console.WriteLine("\n");

            Console.WriteLine("Carro 2: ");
            carro2.ExibirInformacoes();

        }
    }
}
