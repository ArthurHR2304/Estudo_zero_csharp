using System;
using System.Collections.Generic;
using System.Collections.Immutable;

namespace Ordenacao_listas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            int opcao = 0;


            do
            {
                
                Console.WriteLine("|=========================|");
                Console.WriteLine("|1 - Cadastrar nomes      |");
                Console.WriteLine("|2 - Separação crescente  |");
                Console.WriteLine("|3 - Separação decrescente|");
                Console.WriteLine("|4 - Sair                 |");
                Console.WriteLine("==========================|");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("|==================================|");
                            Console.WriteLine("|1 - Voltar ao menu principal      |");
                            Console.WriteLine("|2 - Proseguir para cadastro       |");
                            Console.WriteLine("===================================|");
                            Console.WriteLine();

                            Console.Write("Escolha uma opção: ");
                            if (!int.TryParse(Console.ReadLine(), out opcao))
                            {
                                while (!int.TryParse(Console.ReadLine(), out opcao) || (opcao != 1 && opcao != 2))
                                {
                                    Console.WriteLine("[Erro] Opção inválida! Digite apenas 1 ou 2.");
                                    Console.Write("Escolha uma opção: ");
                                }

                            }
                            else
                            {
                                switch (opcao)
                                {
                                    case 1:
                                        Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
                                        Console.ReadLine();
                                        break;

                                    case 2:
                                        string NovoCadastro = "S";
                                        do
                                        {
                                            Console.Clear();
                                            Console.WriteLine("|=============================================================|");
                                            Console.WriteLine("|=====================CADASTRO DE NOMES=======================|");
                                            Console.WriteLine("|=============================================================|");
                                            Console.WriteLine();

                                            string AdionarNome = "";

                                            while (string.IsNullOrWhiteSpace(AdionarNome) || AdionarNome.Trim().Length < 3)
                                            {
                                                Console.Write("Cadastre um nome (MÍNIMO 3 LETRAS) : ");
                                                AdionarNome = Console.ReadLine().ToUpper();

                                                if (string.IsNullOrWhiteSpace(AdionarNome) || AdionarNome.Trim().Length < 3)
                                                {
                                                    Console.WriteLine("Cadastro de nome inválido! O nome deve conter pelo menos 3 caracteres.");
                                                }
                                            }

                                            nomes.Add(AdionarNome);
                                            Console.WriteLine($"Nome {AdionarNome} cadastrado com sucesso!");


                                            NovoCadastro = "";
                                            while (NovoCadastro != "S" && NovoCadastro != "N")
                                            {
                                                Console.Write("Deseja cadastrar outro nome? (S/N): ");
                                                NovoCadastro = Console.ReadLine().ToUpper();

                                                if (NovoCadastro != "S" && NovoCadastro != "N")
                                                {
                                                    Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.");
                                                }

                                                Console.Clear();
                                            }

                                        } while (NovoCadastro == "S");
                                        break;
                                }
                            }                           
                            break;

                        case 2:

                            Console.Clear();
                            Console.WriteLine("|=========================================|");
                            Console.WriteLine("|Nomes cadastrados (ordenados crescente)  |");
                            Console.WriteLine("|=========================================|");
                            Console.WriteLine();

                            if (nomes.Count == 0)
                            {
                                Console.WriteLine("Nenhum nome cadastrado para ordenar!");
                            }
                            else
                            {
                                nomes.Sort();
                                foreach (var nome in nomes)
                                {
                                    Console.WriteLine(nome);
                                }
                            }

                            Console.WriteLine();
                            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
                            Console.ReadLine();
                            Console.Clear();

                            break;

                            case 3:
                            Console.Clear();
                            Console.WriteLine("|=========================================|");
                            Console.WriteLine("|Nomes cadastrados (ordenados decrescente)|");
                            Console.WriteLine("|=========================================|");
                            Console.WriteLine();

                            if (nomes.Count == 0)
                            {
                                Console.WriteLine("Nenhum nome cadastrado para ordenar!");
                            }
                            else
                            {
                                nomes.Reverse();
                                foreach (var nome in nomes)
                                {
                                    Console.WriteLine(nome);
                                }
                            }

                            Console.WriteLine();
                            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                        case 4:
                            Console.WriteLine("Saindo do programa...");
                            break;

                        default:
                            Console.WriteLine("Opção inválida! Digite apenas números de 1 a 4.");
                            Console.Write("Pressione qualquer tecla para voltar ao menu principal...");
                            Console.ReadLine();
                            Console.Clear();
                            break;

                    }

                }
            } while (opcao != 4);
        }
    }
}
