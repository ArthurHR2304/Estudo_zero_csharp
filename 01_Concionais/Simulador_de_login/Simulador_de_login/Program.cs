using System;
using System.Linq;

namespace Simulador_de_login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============================");
            Console.WriteLine("===Validação de Segurança===");
            Console.WriteLine("============================");
            Console.WriteLine();

            string usuário = "admin@";
            string senha = "@1234";
            bool validação = false;

            Console.Write("Informe o seu usuário de login: ");
            string user = Console.ReadLine();

            Console.Write("Informe a sua senha de login:");
            string pass = Console.ReadLine();
            Console.WriteLine();

            if(senha.Length >= 8 && senha.Contains("@") || senha.Contains("!"))
                Console.Write("Cadastre uma nova senha:");
                
            
            

            if (user == usuário && pass == senha)
            {
                Console.WriteLine("Olá, bem-vindo ao sistema! ");
            }
            else if(user != usuário && pass != senha)
            {
                Console.WriteLine("Usuário não encontrado: ");
            }
            else if (user == usuário && pass != senha)
            {
                Console.WriteLine($"A senha não corresponde ao usuário {usuário} ");
            }
        }
    }
}
