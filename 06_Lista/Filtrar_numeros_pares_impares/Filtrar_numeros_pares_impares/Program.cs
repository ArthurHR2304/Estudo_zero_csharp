namespace Filtrar_numeros_pares_impares
{
    class Progran
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int opcao = 0;

            do
            {
                Console.WriteLine("|===========================|");
                Console.WriteLine("|1 - Cadastrar valores      |");
                Console.WriteLine("|2 - Separação dos valores  |");
                Console.WriteLine("|3 - Sair                   |");
                Console.WriteLine("|===========================|");
                Console.WriteLine();
                Console.Write("Escolha uma opção: ");

                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:

                            string novocadastro = "S";
                            do
                            {
                                Console.Clear();
                                Console.Write("Digite um número inteiro para cadastrar: ");
                                int valorValido;
                             
                                while (!int.TryParse(Console.ReadLine(), out valorValido))
                                {
                                    Console.WriteLine("[Erro] Entrada inválida! Digite apenas números inteiros.");
                                    Console.Write("Tente novamente: ");
                                }

                                // Quando o laço termina, 'numeroValido' já contém o número digitado com segurança!
                                Console.WriteLine($"Número aceito com sucesso: {valorValido}");
                                numeros.Add(valorValido);
                                Console.WriteLine();

                                novocadastro = "";
                                while (novocadastro != "S" && novocadastro != "N")
                                {
                                    Console.Write("Deseja cadastrar um novo produto? (S/N): ");
                                    novocadastro = Console.ReadLine()?.Trim().ToUpper();

                                    if (novocadastro != "S" && novocadastro != "N")
                                    {
                                        Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.\n");
                                    }
                                    Console.Clear();
                                }
                                
                            } while (novocadastro == "S"); // Fim loop case 1

                            break;

                        case 2:

                            if (numeros.Count == 0)
                            {
                                Console.Clear();
                                Console.WriteLine("Sem números cadastrados! Cadastre um número primeiro!");
                                Console.Write("Aperte qualquer tecla para voltar ao menu principal: ");
                                Console.ReadLine();
                                Console.WriteLine();
                            }

                            foreach (int valor in numeros)
                            {
                                Console.WriteLine();
                                if (valor % 2 == 0)
                                {
                                    Console.WriteLine("|======================================|");
                                    Console.WriteLine($"|Valor par: O número {valor} é par ");
                                    Console.WriteLine("|======================================|");
                                    Console.WriteLine(); 
                                }
                                else
                                {
                                    Console.WriteLine("|===========================================|");
                                    Console.WriteLine($"|Valor ímpar: O número {valor} é ímpar ");
                                    Console.WriteLine("|===========================================|");
                                    Console.WriteLine();
                                    
                                }
                            }
                            break;

                        default:
                            Console.Clear();
                            Console.WriteLine();
                            Console.WriteLine("|===============================|");
                            Console.WriteLine("|        Opção inválida!        |");
                            Console.WriteLine("|===============================|");
                            Console.WriteLine();
                            break;
                           

                    }
                    
                }
                else
                {
                    Console.WriteLine("Esse valor é inválido!");
                }
            } while (opcao != 3);

            Console.WriteLine("Saindo do Sistema");

        }
    }
}