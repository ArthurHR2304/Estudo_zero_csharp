using System;
using System.Collections.Generic;
using System.Data.SqlTypes;

namespace Verificador_de_duplicatas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = new List<int>();
            string repete = "S";

            do
            {
                string[] opcoes = { "S", "N" }; // Opções válidas para continuar ou não

                Console.Write("Digite um número: ");
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    nums.Add(num);
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro.");
                    continue;
                }
               

                List<int> duplicados = new List<int>();

                foreach (int numero in nums)
                {
                    if (!duplicados.Contains(numero)) // Verifica se o número já foi verificado
                    {
                        int quant = nums.Count(n => n == numero); // Conta quantas vezes o número aparece na lista

                        if (quant > 1)
                        {
                            Console.WriteLine($"O número {numero} aparece {quant} vezes (DUPLICADO)."); 
                        }
                        else
                        {
                            Console.WriteLine($"O número {numero} aparece {quant} vez.");
                        }

                        duplicados.Add(numero);
                    }

                }

                
                while (true)
                {
                    Console.Write("Deseja continuar? (S/N): ");
                    repete = Console.ReadLine().ToUpper();
                    if (Array.Exists(opcoes, opcao => opcao == repete)) // Verifica se a opção digitada é válida
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Opção inválida. Por favor, digite 'S' para sim ou 'N' para não.");
                    }

                }
                Console.WriteLine();

            } while (repete == "S");
        }
    }
}
