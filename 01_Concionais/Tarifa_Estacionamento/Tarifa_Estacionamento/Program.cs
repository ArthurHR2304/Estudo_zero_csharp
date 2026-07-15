using System.Security;

namespace Tarifa_Estacionamento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==========================");
            Console.WriteLine("===Valor Estacionamento===");
            Console.WriteLine("==========================");
            Console.WriteLine();

            Console.Write("Informe o tempo que seu veiculo ficou no estacionamento: ");
            int Tveiculo = int.Parse(Console.ReadLine());

            if(Tveiculo <= 0)
            {
                Console.Write("Esse valor não é válido");
                return;
            }
            else
            {
                if (Tveiculo == 1)
                {
                    decimal fixo = 5.00m;
                    Console.WriteLine($"O valor a ser pago é de {fixo:C} ");

                }
                else if (Tveiculo <= 4)
                {
                    decimal valorTotal = 5.00m + (Tveiculo - 1) * 3.00m;
                    Console.WriteLine($"O valor total a ser pago pelo estacionamento é de: {valorTotal:C}");
                }
                else if (Tveiculo > 4)
                {
                    decimal taxaFixa = 15.0m;
                    Console.WriteLine($"O valor total a ser pago pelo estacionamento é de: {taxaFixa:C}");

                }
            }
        }
    }
}
