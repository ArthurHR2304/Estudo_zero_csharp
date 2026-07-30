using System.Diagnostics;

namespace Senha_Numerica_Simples 
{
    class Progran
    {
        static void Main(string[] args) 
        {
            string senha = "1234";
            string digito = "";

            while(digito != senha)
            {
                Console.Write("Informe a senha cadastrada: ");
                digito = Console.ReadLine();
                Console.WriteLine();

                if(digito == senha)
                {
                    Console.WriteLine("Senha correta");
                }
                else
                {
                    Console.WriteLine("Senha incorreta, favor digitar novamente!");
                }
            }
        }
    }
}

