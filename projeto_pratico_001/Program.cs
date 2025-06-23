using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pratico_001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Cliente> clientes = new List<Cliente>();

            for(int i = 1; i <= 3; i++)
            {

                Cliente cliente = new Cliente();
                Console.WriteLine($"Digite o nome do cliente {i}: ");
                cliente.nome = Console.ReadLine();

                Console.WriteLine("Digite a idade: ");
                cliente.idade = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite o email: ");
                cliente.email = Console.ReadLine();

                Console.WriteLine("\n");

                clientes.Add(cliente);

            }

            Console.WriteLine("Lista de Clientes Cadastrados: ");
            foreach(var cliente in clientes)
            {

                cliente.ExibirDados();
                Console.WriteLine("\n");

            }

        }
    }
}
