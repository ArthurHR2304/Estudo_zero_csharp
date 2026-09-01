using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Cadastro_Simples_de_Nomes
{
    class Progran
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            string reload = "S";

            do
            {
                string nomeDigitado = "";

                while (string.IsNullOrWhiteSpace(nomeDigitado) || nomeDigitado.Trim().Length < 3)
                {
                    Console.Write("Cadastre um nome (MÍNIMO 3 LETRAS) : ");
                    nomeDigitado = Console.ReadLine().ToUpper();

                    if (string.IsNullOrWhiteSpace(nomeDigitado) || nomeDigitado.Length < 3)
                    {
                        Console.WriteLine("Nome inválido! O nome deve conter pelo menos 3 caracteres.\n");
                    }

                }

                nomes.Add(nomeDigitado);

                reload = "";
                while (reload != "S" && reload != "N")
                {
                    Console.Write("Deseja cadastrar um novo nome? (S/N): ");
                    reload = Console.ReadLine()?.Trim().ToUpper();

                    if (reload != "S" && reload != "N")
                    {
                        Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.\n");
                    }
                }

                Console.WriteLine();

            } while (reload == "S");

            Console.Clear();
            Console.WriteLine("Os nomes cadastrados foram:");

            int i = 1;
            foreach (string listaNomes in nomes)
            {
                Console.WriteLine($"{i} - {listaNomes}");
                i++; // Incrementa o contador a cada nome exibido
            }
        }
    }
}