using System;

namespace Validacao_Desconto
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("============================");
            Console.WriteLine("===Validação de Descontos===");
            Console.WriteLine("============================");
            Console.WriteLine();

            Console.Write("Informe a o valor da compra: ");
            float Vcompra = float.Parse(Console.ReadLine());

            Console.Write("Peça o cliente para informar a sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if(Vcompra > 100 || idade >= 60)
            {
                float Vfinal = (Vcompra * 10) / 100;
                Console.WriteLine($"Parabéns,você recebeu um desconto de 10% na sua compra. O valor a ser pago é: {Vfinal} ");
            }
            else
            {
                Console.WriteLine($"O valor total da sua compra é de: {Vcompra}");
            }
        }
    }
}
