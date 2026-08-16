namespace Menu_Selecionavel
{
    class Progran
    {
        static void Main(string[] args)
        {

            int opcao = 0;
            
            do
            {
                Console.Clear();

                Console.WriteLine("|===================|");
                Console.WriteLine("| 1 -   Ver Saldo   |");
                Console.WriteLine("| 2 - Fazer Depósito|");
                Console.WriteLine("| 3 -     Sair      |");
                Console.WriteLine("|===================|");
                Console.WriteLine();

                Console.Write("Informe o número referente a opção que deseja: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Seu saldo atual é R$ 1.000,00");
                        break;

                        case 2:
                            Console.WriteLine("Insira o valor do depósito");
                        break;

                        case 3:
                            Console.WriteLine("Saindo do sistema!");
                        break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();

            } while (opcao != 3);         
        }
    }
}