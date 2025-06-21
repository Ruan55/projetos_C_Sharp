using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex007
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Produto produto1 = new Produto("Notebook", 3000);
            CalculadoraDesconto calculardesconto1 = new CalculadoraDesconto();

            produto1.ExibirProduto();

            Console.WriteLine("\n");

            Console.WriteLine($"Preço com 10% de desconto: {calculardesconto1.CalcularDesconto(3000, 10):F2}");

            Console.WriteLine($"Preço com 10% de desconto + desconto adicional de 100: {calculardesconto1.CalcularDesconto(3000, 10, 100):F2}");

        }
    }
}
