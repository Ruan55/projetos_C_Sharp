using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verificacao_de_login
{
    internal class Program
    {
        static void Main(string[] args)
        {

            GerenciadorDeUsuarios gerenciarusuarios = new GerenciadorDeUsuarios();

            while (true) {

                Console.WriteLine("Escolha uma das opções abaixo: ");
                Console.WriteLine("1 - Login usuário");
                Console.WriteLine("2 - Exibir usuários cadastrados");
                Console.WriteLine("3 - Sair");
                Console.WriteLine("Opção escolhida: ");

                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                switch (opcao) {

                    case 1:
                        Console.WriteLine("Digite o seu nome de usuário: ");
                        string nomeUsuario = Console.ReadLine();
                        Console.WriteLine("Digite a sua senha de usuário: ");
                        string senhaUsuario = Console.ReadLine();

                        if (gerenciarusuarios.usuarioExiste(nomeUsuario))
                        {

                            gerenciarusuarios.verificandoLoginSenhaUsuario(nomeUsuario, senhaUsuario); 

                        }

                        else
                        {

                            gerenciarusuarios.LoginSenhaUsuario(nomeUsuario, senhaUsuario);

                        }

                        break;

                    case 2:

                        gerenciarusuarios.ListarUsuariosCadastrados();
                        break;

                    case 3:

                        Console.WriteLine("Programa encerrado!");
                        return;
                
                }
            
            }

        }
    }
}
