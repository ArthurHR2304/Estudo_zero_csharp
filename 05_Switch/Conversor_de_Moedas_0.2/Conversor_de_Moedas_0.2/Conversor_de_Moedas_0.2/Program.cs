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
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real)) // Tenta converter a entrada do usuário para decimal
                                {

                                    if(real > 0)
                                    {
                                        decimal usd = 5.15m;
                                        decimal contacao = real / usd;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $USD:{usd:F2} é de R${contacao:F2} "); // Exibe o resultado da conversão
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }
                                   
                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!"); // Informa ao usuário que a entrada não é válida
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): "); // Solicita ao usuário se deseja calcular uma nova cotação
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S"); 
                            break;

                        case 2:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal eur = 6.01m;
                                        decimal contacao = real / eur;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $EUR:{eur:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }
                                   
                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 3:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal gbp = 7.03m;
                                        decimal contacao = real / gbp;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $GBP:{gbp:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 4:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal cgf = 6.42m;
                                        decimal contacao = real / cgf;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $CGF:{cgf:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 5:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal cad = 3.72m;
                                        decimal contacao = real / cad;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $CAD:{cad:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 6:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal ars = 0.0034m;
                                        decimal contacao = real / ars;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $ARS:{ars:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 7:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal cny = 0.76m;
                                        decimal contacao = real / cny;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $CNY:{cny:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 8:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal jpy = 0.032m;
                                        decimal contacao = real / jpy;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $JPY:{jpy:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 9:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal aud = 3.68m;
                                        decimal contacao = real / aud;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $AUD:{aud:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
                            break;

                        case 10:
                            do
                            {
                                continua = "S";
                                Console.Clear();

                                Console.Write("Informe o valor em real disponivel: R$");
                                if (decimal.TryParse(Console.ReadLine(), out decimal real))
                                {
                                    if (real > 0)
                                    {
                                        decimal btc = 406.310m;
                                        decimal contacao = real / btc;

                                        Console.WriteLine($"O valor de R${real:F2} convertido na cotação de $BTC:{btc:F2} é de R${contacao:F2} ");
                                        Console.WriteLine();
                                    }
                                    else
                                    {
                                        Console.WriteLine("O valor precisa ser maior que zero para ser convertido!");
                                    }

                                }
                                else
                                {
                                    Console.Write("Esse valor fornecido não pode ser encontrado!");
                                }

                                Console.Write("Deseja calcular uma nova cotação (S/N): ");
                                continua = Console.ReadLine()?.Trim().ToUpper();
                                Console.WriteLine();

                            } while (continua == "S");
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
                    Console.Write("Deseja voltar ao menu principal (S/N): ");
                    continua = Console.ReadLine()?.Trim().ToUpper();

                }
            } while (continua == "S" && opcao != 11);

            if (continua == "N")
            {
                Console.WriteLine("Finalizando Sistema após execução do usuário!!");
            }
        }
    }
}