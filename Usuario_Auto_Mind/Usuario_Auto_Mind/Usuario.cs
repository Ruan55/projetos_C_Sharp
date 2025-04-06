using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Usuario_Auto_Mind
{
    internal class Usuario
    {

        // Propriedades do usuário
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }

        // Construtor para inicializar um usuário
        public Usuario(string nome, string email, int idade)
        {
            Nome = nome;
            Email = email;
            Idade = idade;
        }

        // Método para exibir as informações do usuário
        public void exibirMensagem()
        {

            Console.WriteLine($"Nome: {Nome}, Email: {Email}, Idade: {Idade}");

        }

    }
}
