using System;

namespace Maior_de_Dois_Numeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===========================");
            Console.WriteLine("===Maior de Dois Números===");
            Console.WriteLine("===========================");
            Console.WriteLine();

            Console.Write("Digite o primeiro número: ");
            int numero1 = int.TryParse(Console.ReadLine(), out int num1) ? num1 : 0; // O ?? operador de coalescência nula (??) é usado para fornecer um valor padrão caso a conversão falhe.

            Console.Write("Digite o segundo número: ");
            int numero2 = int.TryParse(Console.ReadLine(), out int num2) ? num2 : 0; // O num2 : 0 é usado para fornecer um valor padrão caso a conversão falhe.

            if (numero1 > numero2)
            {
                Console.WriteLine("O maior número é: " + numero1);
            }
            else
            {
                Console.WriteLine("O maior número é: " + numero2);
            }
        }
    }
}
