using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex001
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string nome = "Ruan";
            int idade = 22;
            float altura = 1.80f;
            bool souEstudante = true;

            Console.WriteLine($"\nNome: {nome}\nIdade: {idade}\nAltura: {altura}\nSou Estudante: {souEstudante}\nDobro da idade: {idade * 2}");

        }
    }
}
