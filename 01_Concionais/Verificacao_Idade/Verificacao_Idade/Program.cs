using System;

namespace Verificacao_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite sua idade:");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }
        }
    }
}