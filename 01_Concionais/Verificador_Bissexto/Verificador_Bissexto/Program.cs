using System;

namespace Verificador_Bissexto
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("==============================");
            Console.WriteLine("===Verificando Ano Bissexto===");
            Console.WriteLine("==============================");
            Console.WriteLine();

            Console.Write("Informe um ano: ");
            int ano = int.Parse(Console.ReadLine());

            if (ano % 400 == 0 || (ano % 4 == 0 && ano % 100 != 0))
            {
                Console.WriteLine($"O ano de {ano}, é um ano bissexto");
            }
            else
            {
                Console.WriteLine("O ano informador não é bissexto");
            }
        }
    }
}