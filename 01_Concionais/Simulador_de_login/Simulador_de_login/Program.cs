using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Net.Mail;

namespace Simulador_de_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senhaCadastrada = "";
            string user;
            string pass;

            Console.WriteLine("============================");
            Console.WriteLine("===Validação de Segurança===");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.Write("Informe o seu usuário de login: ");
            user = Console.ReadLine();

            Console.Write("Informe a sua senha de login:");
            pass = Console.ReadLine();
            Console.WriteLine();

            if (pass.Length >= 8 && pass.Contains("@") || pass.Contains("!") && pass.Any(char.IsDigit))
            {
                Console.WriteLine("Bem-vindo(a) ao sistema!!");
            }
            else
            {
                Console.WriteLine("Sua senha atual é fraca e não possui a segurança adequada.");
                Console.Write("Por favor, digite uma NOVA senha (mínimo 8 dígitos, conter @ ou ! e números): ");
                pass = Console.ReadLine();

                // Valida se a nova senha atende os requisitos
                if (pass.Length >= 8 && (pass.Contains("@") || pass.Contains("!")) && pass.Any(char.IsDigit))
                {
                    senhaCadastrada = pass; // Atualiza a senha no "banco de dados"
                    Console.WriteLine();
                    Console.WriteLine("Senha atualizada com sucesso! Acesso concedido.");
                }
                else
                {
                    Console.WriteLine("A nova senha também não atende aos requisitos. Acesso bloqueado.");
                    return;
                }

                Console.WriteLine("===================================");
                Console.WriteLine("===Informe o seu login novamente===");
                Console.WriteLine("===================================");
                Console.WriteLine();


                Console.Write("Informe o seu usuário de login novamente: ");
                string loginUser = Console.ReadLine();

                Console.Write("Informe a sua senha de login novamente:");
                string loginPass = Console.ReadLine();
                Console.WriteLine();

                if (loginUser == user && loginPass == senhaCadastrada)
                {
                    Console.WriteLine("Login realizado com sucesso! Bem-vindo.");
                }
                else
                {
                    Console.WriteLine("Usuário ou senha incorretos.");
                }
            }

         
        }
    }
}
