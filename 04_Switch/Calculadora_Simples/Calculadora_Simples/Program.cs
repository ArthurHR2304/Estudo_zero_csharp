namespace Calculadora_Simples
{
    class Progran
    {
        static void Main(string[] args)
        {
            double[] num = new double[2];
            int opcao = 0;
            string continuar = "S";

            do
            {
                Console.Clear();

                for(int i = 0; i < num.Length; ++i)
                {
                    bool entradaValida = false;

                    while (!entradaValida)
                    {
                        Console.Write($"Informe o {i + 1}º valor: ");
                        if(double.TryParse(Console.ReadLine(), out num[i]))
                        {
                            entradaValida = true;
                        }
                        else
                        {
                            Console.WriteLine("Valor inválido! Digite um número válido.");
                        }
                    }   
                }

                Console.WriteLine();
                Console.WriteLine("|=====================|");
                Console.WriteLine("| 1 -    Adição +     |");
                Console.WriteLine("| 2 -   Subtração -   |");
                Console.WriteLine("| 3 - Multiplicação * |");
                Console.WriteLine("| 4 -    Divisão /    |");
                Console.WriteLine("| 5 -     Sair        |");
                Console.WriteLine("|=====================|");
                Console.WriteLine();

                Console.Write("Escolha uma operação: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine($"Resultado: {num[0] + num[1]}");
                            break;

                        case 2:
                            Console.WriteLine($"Resultado: {num[0] - num[1]}");
                            break;

                        case 3:
                            Console.WriteLine($"Resultado: {num[0] * num[1]}");
                            break;

                        case 4:
                            if (num[1] != 0)
                            {
                                Console.WriteLine($"Resultado: {num[0] / num[1]}");
                            }
                            break;

                        case 5:
                            Console.WriteLine("Saindo do Sistema");
                            break;

                        default:
                            Console.WriteLine("Opção inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }

                if (opcao != 5)
                {
                    // Pergunta de confirmação para repetir
                    Console.WriteLine();
                    Console.Write("Deseja consultar outro dia? (S/N): ");
                    continuar = Console.ReadLine()?.Trim().ToUpper();
                }


            } while (continuar == "S" && opcao != 5);

            if (continuar == "N")
            {
                Console.Write("Finalizando Sistema!");
            }
           
        }
    }
}