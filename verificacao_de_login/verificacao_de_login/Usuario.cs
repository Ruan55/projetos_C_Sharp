using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacao_de_login
{
    internal class Usuario
    {

        // Criando os atributos do usuário
        public string NomeUsuario { get; set; }
        public string SenhaUsuario { get; set; }

        // Construtor para inicializar um usuário
        public Usuario(string nomeusuario, string senhausuario) { 
        
            NomeUsuario = nomeusuario;
            SenhaUsuario = senhausuario;
        
        }

        // Criação de método para exibir as informações do usuário
        public void exibirInformacoes()
        {

            Console.WriteLine($"Nome do usuário: {NomeUsuario}");
            Console.WriteLine($"Senha do usuário: {SenhaUsuario}");

        }


    }
}
