using System;

namespace Positivo_Negativo_ou_Zero 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("===============================");
            Console.WriteLine("===Positivo_Negativo_ou_Zero===");
            Console.WriteLine("===============================");
            Console.WriteLine();

            Console.Write("Informe um número de valor inteiro:");

            if (int.TryParse(Console.ReadLine(), out int inteiro))
            {
                if (inteiro > 0)
                {
                    Console.WriteLine("Valor Positivo");
                }
                else if (inteiro < 0 || inteiro == 0)
                {
                    Console.Write("Valor Negativo");
                }
                else
                {
                    Console.WriteLine("Valor Inválido");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido");
            }
            
        }
    }
}

