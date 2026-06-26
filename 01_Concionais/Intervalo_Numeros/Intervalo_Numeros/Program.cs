using System;

namespace Intervalo_Numeros 
{
    internal class Program 
    { 
        static void Main(string[] args)
        {
            // O do while foi adicionado para testes, deve ser considerado semente as codições if else
            char resposta;
            do
            {
                Console.WriteLine("==========================");
                Console.WriteLine("===Intervalo de Números===");
                Console.WriteLine("==========================");
                Console.WriteLine();
                Console.WriteLine();


                Console.Write("Informe um valor inteiro: ");
                int num = int.Parse(Console.ReadLine());

                if (num >= 10 && num <= 50)
                {
                    Console.Write("O valor está no intervalo");
                    Console.WriteLine();
                }
                else
                {
                    Console.Write("O valor está fora do intervalo");
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.Write("Deseja testar novamente? (S/N)");
                resposta = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.Clear();

            } while (char.ToLower(resposta) != 'n');
           
        }
    }
}