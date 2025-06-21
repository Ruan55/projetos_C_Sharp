using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex008
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Aluno> alunos = new List<Aluno>();

            for(int i = 1; i <= 3; i++)
            {

                Aluno aluno = new Aluno();
                Console.WriteLine($"Digite o nome do {i}º aluno: ");
                aluno.nome = Console.ReadLine();

                Console.WriteLine("Digite a nota: ");

                // O programa entende como decimal mesmo que o Windows esteja esperando vírgula.
                aluno.nota = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);  
                
                Console.WriteLine("\n");

                alunos.Add(aluno);

            }

            Console.WriteLine("Lista de alunos: ");
            foreach(var aluno in alunos)
            {
                
                Console.WriteLine($"Nome: {aluno.nome} - Nota: {aluno.nota}");

            }

        }
    }
}
