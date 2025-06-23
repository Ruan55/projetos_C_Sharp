using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pratico_001
{
    internal class Cliente
    {

        public string nome;
        public int idade;
        public string email;

        public void ExibirDados()
        {

            Console.WriteLine($"Nome: {nome} \nIdade: {idade} \nEmail: {email}");

        }

    }
}
