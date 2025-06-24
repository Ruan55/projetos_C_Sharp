using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_pratico_002
{
    internal class Cliente
    {

        public int id;
        public string nome;
        public int idade;
        public string email;

        public void ExibirDados()
        {

            Console.WriteLine($"ID: {id} \nNome: {nome} \nIdade: {idade} \nEmail: {email}");

        }

    }
}
