namespace Conversor_de_Moedas
{
    class Progran
    {
        static void Main(string[] args)
        {
            string continua = "S";
            int opcao = 0;
            do
            {
                Console.Clear();

                Console.WriteLine("|====================|");
                Console.WriteLine("| Contação de Moedas |");
                Console.WriteLine("|====================|");
                Console.WriteLine();

                Console.WriteLine("|=====================================|");
                Console.WriteLine("|1 - Dólar Americano (USD): R$ 5,15   |");
                Console.WriteLine("|2 - Euro (EUR): R$ 6,01              |");
                Console.WriteLine("|3 - Libra Esterlina (GBP): R$ 7,03   |");
                Console.WriteLine("|4 - Franco Suiço (CHF): R$ 6,42      |");
                Console.WriteLine("|5 - Dólar Canadense (CAD): R$ 3,72   |");
                Console.WriteLine("|6 - Peso Argentino (ARS): R$ 0,0034  |");
                Console.WriteLine("|7 - Iuan Chinês (CNY): R$ 0,76       |");
                Console.WriteLine("|8 - Iene Japonês (JPY): R$ 0,032     |");
                Console.WriteLine("|9 - Dólar Australiano (AUD): R$ 3,68 |");
                Console.WriteLine("|10 - Bitcoin (BTC): R$ 406.310,00    |");
                Console.WriteLine("|11 -       Sair do Sistema           |");
                Console.WriteLine("|=====================================|");
                Console.WriteLine();

                Console.Write("Informe um número para realizar a conversão :");
                if (int.TryParse(Console.ReadLine(), out opcao))
                {
                    Console.Clear(); 

                    switch (opcao)
                    {
                        case 1:
                            Console.Write("Informe o valor em real disponivel: R$");
                            if (decimal.TryParse(Console.ReadLine(), out decimal real))
                            {
                                decimal usd = 5.15m;
                                decimal contacao = real / usd;

                                Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $USD:{usd:F2} é de R${contacao:F2} ");
                                Console.WriteLine();
                            }
                            else
                            {
                                Console.Write("Esse valor fornecido não pode ser encontrado!");
                            }
                            break;
                        case 2:
                            break;
                        case 3:
                            break;
                        case 4:
                            break;
                        case 5:
                            break;
                        case 6:
                            break;
                        case 7:
                            break;
                        case 8:
                            break;
                        case 9:
                            break;
                        case 10:
                            break;
                        case 11:
                            Console.WriteLine("Saindo do Sistema!");
                            break;

                        default:
                            Console.WriteLine("Moeda inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }

                
                if (opcao != 11)
                {
                    Console.WriteLine("Deseja calcular uma nova cotação (S/N): ");
                    continua = Console.ReadLine()?.Trim().ToUpper();

                }
            } while (continua == "S" && opcao != 8 );
            
            if (continua == "N")
            {
                Console.WriteLine("Finalizando Sistema após execução do usuário!!");
            }
        }
    }
}