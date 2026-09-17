using System;
using System.Collections.Generic;

namespace Buscar_item
{
    class Progran
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            int opcao = 0;

            do
            {
                Console.Clear();
                Console.WriteLine("|=========================|");
                Console.WriteLine("|====Consulta de Nomes====|");
                Console.WriteLine("|=========================|");
                Console.WriteLine("| 1 - Adicionar Nomes     |");
                Console.WriteLine("| 2 - Exibir Nomes        |");
                Console.WriteLine("| 3 - Sair                |");
                Console.WriteLine("|=========================|");

                Console.Write("Digite um opção do menu: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:

                            Console.Clear();
                            opcao = 0;

                            Console.WriteLine("|==================================|");
                            Console.WriteLine("|=========Consulta de Nomes========|");
                            Console.WriteLine("|==================================|");
                            Console.WriteLine("| 1 - Adicionar Nomes              |");
                            Console.WriteLine("| 2 - Voltar ao Menu Principal     |");
                            Console.WriteLine("|==================================|");

                            Console.Write("Escolha uma opção no menu: ");
                            if (int.TryParse(Console.ReadLine(), out opcao))
                            {
                                switch (opcao)
                                {
                                    case 1:
                                        string repetir = "S";

                                        do
                                        {
                                            Console.Clear();
                                            string NomeDigitado = "";

                                            while (string.IsNullOrWhiteSpace(NomeDigitado) || NomeDigitado.Trim().Length < 3)
                                            {
                                                Console.Write("Cadastre pelo menos 3 nomes");
                                                Console.Write("Cadastre um nome (MÍNIMO 3 LETRAS) : ");
                                                NomeDigitado = Console.ReadLine().ToUpper();

                                                if (string.IsNullOrWhiteSpace(NomeDigitado) || NomeDigitado.Length < 3)
                                                {
                                                    Console.WriteLine("Nome de produto inválido! O nome do produto deve conter pelo menos 3 caracteres.\n");
                                                }
                                            }

                                            nomes.Add(NomeDigitado);
                                            Console.WriteLine($"Produto '{NomeDigitado}' cadastrado com sucesso!\n");

                                            // Validação do S/N
                                            repetir = "";
                                            while (repetir != "S" && repetir != "N")
                                            {
                                                Console.Write("Deseja cadastrar um novo produto? (S/N): ");
                                                repetir = Console.ReadLine()?.Trim().ToUpper();

                                                if (repetir != "S" && repetir != "N")
                                                {
                                                    Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.\n");
                                                }
                                                Console.Clear();
                                            }

                                        } while (opcao != 2 && repetir == "S");
                                        break;
                                }
                            }

                            break;

                        case 2:

                            Console.Clear();
                            opcao = 0;

                            Console.WriteLine("|==================================|");
                            Console.WriteLine("|=========Consulta de Nomes========|");
                            Console.WriteLine("|==================================|");
                            Console.WriteLine("| 1 - Buscar Nomes na Lista        |");
                            Console.WriteLine("| 2 - Voltar ao Menu Principal     |");
                            Console.WriteLine("|==================================|");

                            Console.Write("Escolha uma opção no menu: ");
                            if (int.TryParse(Console.ReadLine(), out opcao))
                            {
                                switch (opcao)
                                {
                                    case 1:

                                        if (nomes.Count == 0)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("Sem produtos cadastrados! Cadastre um produto primeiro!");
                                            Console.Write("Aperte qualquer tecla para voltar ao menu principal: ");
                                            Console.ReadLine();
                                            Console.WriteLine();
                                        }
                                        else
                                        {
                                            string repetir = "S";
                                            do
                                            {
                                                Console.Clear();
                                                string BuscarNome = "";

                                                Console.Write($"Digite o nome ou um índice (de 0 a {nomes.Count - 1}): ");
                                                BuscarNome = Console.ReadLine();

                                                if (int.TryParse(BuscarNome, out int indice))
                                                {
                                                    if (indice >= 0 && indice < nomes.Count)
                                                    {
                                                        Console.WriteLine($"\n[Sucesso] Item encontrado no índice [{indice}]: '{nomes[indice]}'");
                                                    }
                                                    else
                                                    {
                                                        Console.WriteLine($"\n[Erro] Índice inválido! Digite um número entre 0 e {nomes.Count - 1}.");
                                                    }
                                                }
                                                // 2. Se não for número, trata como Nome do Produto
                                                else
                                                {
                                                    if (string.IsNullOrWhiteSpace(BuscarNome) || BuscarNome.Length < 3)
                                                    {
                                                        Console.WriteLine("\n[Erro] Para buscar por nome, digite no mínimo 3 caracteres.");
                                                    }
                                                    else
                                                    {
                                                        string nomeBusca = BuscarNome.ToUpper();

                                                        if (nomes.Contains(nomeBusca))
                                                        {
                                                            int posicao = nomes.IndexOf(nomeBusca);
                                                            Console.WriteLine($"\n[Sucesso] Item '{nomeBusca}' encontrado no índice [{posicao}]!");
                                                        }
                                                        else
                                                        {
                                                            Console.WriteLine($"\n[Aviso] O produto '{nomeBusca}' não foi localizado no estoque.");
                                                        }
                                                    }
                                                }

                                                repetir = "";
                                                while (repetir != "S" && repetir != "N")
                                                {
                                                    Console.Write("\nDeseja realizar outra busca? (S/N): ");
                                                    repetir = Console.ReadLine()?.Trim().ToUpper();

                                                    if (repetir != "S" && repetir != "N")
                                                    {
                                                        Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.");
                                                    }
                                                }

                                            } while (repetir == "S");
                                        }
                                        break;
                                }
                            }
                            break;
                    }
                }
            } while (opcao != 3);
        }
    }
}