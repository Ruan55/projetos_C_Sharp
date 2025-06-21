using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex010
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite a sua data de nascimento: (dd/mm/yyyy): ");
            DateTime dataDeNascimento = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);

            DateTime hoje = DateTime.Today;
            int idade = hoje.Year - dataDeNascimento.Year;

            DateTime data = DateTime.Now;
            string dataDeHoje = data.ToString("dd/MM/yyyy");

            // Criar a data de nascimento no ano atual
            DateTime Aniversario = new DateTime(hoje.Year, dataDeNascimento.Month, dataDeNascimento.Day);

            // Se o aniversário já passou este ano, adicionar um ano
            if(Aniversario < hoje)
            {

                idade--;

            }

            // Calculando quantos dias restam para o próximo aniversário
            TimeSpan proximoAniversario = Aniversario - hoje;
            int diasRestantes = proximoAniversario.Days;

            Console.WriteLine("\n");

            Console.WriteLine($"Data de hoje: {dataDeHoje}");
            Console.WriteLine($"Sua idade: {idade} anos");
            Console.WriteLine($"Dias até o próximo aniversário: {diasRestantes} dias");

        }
    }
}
