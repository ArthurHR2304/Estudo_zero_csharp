using System;
using System.Collections.Generic;

namespace Adicionar_Remover_Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> produtos = new List<string>();
            int opcao = 0;
            string reload = "S";

            do
            {
                Console.WriteLine("|=========================|");
                Console.WriteLine("|===Estoque de Produtos===|");
                Console.WriteLine("|=========================|");
                Console.WriteLine("| 1 - Adicionar Produtos  |");
                Console.WriteLine("| 2 - Remover Produtos    |");
                Console.WriteLine("| 3 - Exibir Produtos     |");
                Console.WriteLine("| 4 - Editar Produtos     |");
                Console.WriteLine("| 5 - Sair                |");
                Console.WriteLine("|=========================|");
                Console.WriteLine();

                Console.Write("Escilha um opção: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {

                    switch (opcao)
                    {
                        case 1: // case para cadastrar

                            string CadastrarNovamente = "S";
                            do
                            {
                                Console.Clear();
                                string ProdutoDigitado = "";

                                while (string.IsNullOrWhiteSpace(ProdutoDigitado) || ProdutoDigitado.Trim().Length < 3)
                                {
                                    Console.Write("Cadastre um produto (MÍNIMO 3 LETRAS) : ");
                                    ProdutoDigitado = Console.ReadLine().ToUpper();

                                    if (string.IsNullOrWhiteSpace(ProdutoDigitado) || ProdutoDigitado.Length < 3)
                                    {
                                        Console.WriteLine("Nome de produto inválido! O nome do produto deve conter pelo menos 3 caracteres.\n");
                                    }
                                }

                                produtos.Add(ProdutoDigitado);
                                Console.WriteLine($"Produto '{ProdutoDigitado}' cadastrado com sucesso!\n");

                                // Validação do S/N
                                CadastrarNovamente = "";
                                while (CadastrarNovamente != "S" && CadastrarNovamente != "N")
                                {
                                    Console.Write("Deseja cadastrar um novo produto? (S/N): ");
                                    CadastrarNovamente = Console.ReadLine()?.Trim().ToUpper();

                                    if (CadastrarNovamente != "S" && CadastrarNovamente != "N")
                                    {
                                        Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.\n");
                                    }
                                    Console.Clear();
                                }



                            } while (CadastrarNovamente == "S"); // Fim loop case 1

                            break; // case 1

                        case 2: // case para remover                

                            if (produtos.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Sem produtos cadastrados! Cadastre um produto primeiro!");
                                Console.Write("Aperte qualquer tecla para voltar ao menu principal: ");
                                Console.ReadLine();
                                Console.WriteLine();
                            }

                            else
                            {
                                string RemoverNovamnete = "S";
                                do
                                {
                                    Console.Clear();
                                    string RemoverProduto = "";

                                    while (string.IsNullOrWhiteSpace(RemoverProduto) || RemoverProduto.Trim().Length < 3)
                                    {
                                        Console.Write("Delete um produto (MÍNIMO 3 LETRAS) : ");
                                        RemoverProduto = Console.ReadLine().ToUpper();

                                        if (string.IsNullOrWhiteSpace(RemoverProduto) || RemoverProduto.Length < 3)
                                        {
                                            Console.WriteLine("Nome de produto inválido! O nome do produto deve conter pelo menos 3 caracteres.\n");
                                        }
                                    }

                                    if (produtos.Contains(RemoverProduto))
                                    {
                                        produtos.Remove(RemoverProduto);
                                        Console.WriteLine($"Produto '{RemoverProduto}' excluido com sucesso com sucesso!\n");
                                    }
                                    else
                                    {
                                        Console.WriteLine();
                                        Console.WriteLine("Esse produto não foi localizado!");

                                    }

                                    // Validação do S/N
                                    RemoverNovamnete = "";
                                    while (RemoverNovamnete != "S" && RemoverNovamnete != "N")
                                    {
                                        Console.Write("Deseja remover um novo produto? (S/N): ");
                                        RemoverNovamnete = Console.ReadLine()?.Trim().ToUpper();

                                        if (RemoverNovamnete != "S" && RemoverNovamnete != "N")
                                        {
                                            Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.\n");
                                        }
                                        Console.Clear();
                                    }
                                } while (RemoverNovamnete == "S"); // Fim loop case 2
                            }

                            break; //case 2

                        case 3:
                            if (produtos.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Sem produtos cadastrados! Cadastre um produto primeiro!");
                                Console.Write("Aperte qualquer tecla para voltar ao menu principal: ");
                                Console.ReadLine();
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("|===============================|");
                                Console.WriteLine("| Lista de Produtos Cadastrados |");
                                Console.WriteLine("|===============================|");
                                

                                foreach (string prod in produtos) // renomeia lista de "produtos" para prod
                                {
                                    Console.WriteLine(prod); // exibe os produtos cadastrados
                                }
                                Console.WriteLine();
                            }
                            break;

                        case 4:

                            if (produtos.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Sem produtos cadastrados! Cadastre um produto primeiro!");
                                Console.Write("Aperte qualquer tecla para voltar ao menu principal: ");
                                Console.ReadLine();
                                Console.WriteLine();
                            }
                            else
                            {
                                string EditarNovamente = "S";

                                do
                                {
                                    Console.Clear();

                                    // Exibe a lista para o usuário ver os índices disponíveis
                                    Console.WriteLine("--- LISTA DE PRODUTOS ---");
                                    for (int i = 0; i < produtos.Count; i++)
                                    {
                                        Console.WriteLine($"[{i}] - {produtos[i]}");
                                    }
                                    Console.WriteLine("-------------------------\n");

                                    int indiceEscolhido = -1;
                                    bool indiceValido = false;

                                    // Loop para validar a escolha do índice
                                    while (!indiceValido)
                                    {
                                        Console.Write("Informe o índice do produto que deseja alterar: ");
                                        string entradaIndice = Console.ReadLine();

                                        // Valida se é um número e se está dentro dos limites da lista
                                        if (int.TryParse(entradaIndice, out indiceEscolhido) && indiceEscolhido >= 0 && indiceEscolhido < produtos.Count)
                                        {
                                            indiceValido = true;
                                        }
                                        else
                                        {
                                            Console.WriteLine("[Erro] Índice inválido! Digite um número que esteja na lista.\n");
                                        }
                                    }

                                    // Loop para validar o NOVO nome do produto
                                    string novoNome = "";
                                    while (string.IsNullOrWhiteSpace(novoNome) || novoNome.Trim().Length < 3)
                                    {
                                        Console.Write($"\nDigite o novo nome para '{produtos[indiceEscolhido]}' (MÍNIMO 3 LETRAS): ");
                                        novoNome = Console.ReadLine()?.Trim().ToUpper();

                                        if (string.IsNullOrWhiteSpace(novoNome) || novoNome.Length < 3)
                                        {
                                            Console.WriteLine("[Erro] Nome inválido! O produto deve conter pelo menos 3 caracteres.");
                                        }
                                    }

                                    // Faz a alteração na posição correta
                                    produtos[indiceEscolhido] = novoNome;
                                    Console.WriteLine($"\n[Sucesso] Produto alterado para '{novoNome}'!");

                                    // Validação do S/N para continuar editando
                                    EditarNovamente = "";
                                    while (EditarNovamente != "S" && EditarNovamente != "N")
                                    {
                                        Console.Write("\nDeseja editar outro produto? (S/N): ");
                                        EditarNovamente = Console.ReadLine()?.Trim().ToUpper();

                                        if (EditarNovamente != "S" && EditarNovamente != "N")
                                        {
                                            Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.");
                                        }
                                    }




                                } while (EditarNovamente == "S"); // Fim case 4
                            }
                    
                    break;

                        case 5:  // case para finalizar o sistema
                        Console.WriteLine();
                        Console.WriteLine("|===============================|");
                        Console.WriteLine("|      Finalzando Sistema!      |");
                        Console.WriteLine("|===============================|");
                        break; // Fim case 5

                    default: // case para opções inválidas

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine("|===============================|");
                        Console.WriteLine("|        Opção inválida!        |");
                        Console.WriteLine("|===============================|");
                        Console.WriteLine();
                            
                        break; // Opção de erro

                    }
                }


            } while (opcao != 5); // Loop principal



        }
    }
}