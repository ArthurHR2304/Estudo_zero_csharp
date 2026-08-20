namespace Dias_da_Semana
{
    class Progran
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string continuar = "S";

            do
            {
                Console.Clear();

                Console.WriteLine("|===================|");
                Console.WriteLine("| 1 -    Dia um     |");
                Console.WriteLine("| 2 -    Dia dois   |");
                Console.WriteLine("| 3 -    Dia trës   |");
                Console.WriteLine("| 4 -   Dia quatro  |");
                Console.WriteLine("| 5 -    Dia cinco  |");
                Console.WriteLine("| 6 -    Dia seis   |");
                Console.WriteLine("| 7 -    Dia sete   |");
                Console.WriteLine("| 8 -     Sair      |");
                Console.WriteLine("|===================|");
                Console.WriteLine();

                Console.Write("Informe um valor inteiro para descobrir o dia da semana: ");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Domingo");
                            break;

                        case 2:
                            Console.WriteLine("Seunda-feira");
                            break;

                        case 3:
                            Console.WriteLine("Terça-feira");
                            break;

                        case 4:
                            Console.WriteLine("Quarta-feira");
                            break;

                        case 5:
                            Console.WriteLine("Quinta-feira");
                            break;

                        case 6:
                            Console.WriteLine("Sexta-feira");
                            break;

                        case 7:
                            Console.WriteLine("Sábado");
                            break;

                        case 8:
                            Console.WriteLine("Saindo do sistema...");
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

                if(opcao != 8)
                {
                    // Pergunta de confirmação para repetir
                    Console.WriteLine();
                    Console.Write("Deseja consultar outro dia? (S/N): ");
                    continuar = Console.ReadLine()?.Trim().ToUpper();
                }
              

            } while (continuar == "S" && opcao != 8);

            if(continuar == "N")
            {
                Console.WriteLine("Finalizando Sistema!");
            }
         




        }
    }
}