using System;

namespace Classificação_de_Triangulos 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=================================");
            Console.WriteLine("===Classificação de Triângulos===");
            Console.WriteLine("=================================");
            Console.WriteLine();

            Console.Write("Informe um valor para o lado A do triângulo:");
            if (!float.TryParse(Console.ReadLine(), out float ladoA) || ladoA <= 0f) { Console.WriteLine("Valor inválido. Digite um número maior que zero."); return; }
            Console.Write("Informe um valor para o lado B do triângulo:");
            if (!float.TryParse(Console.ReadLine(), out float ladoB) || ladoB <= 0f) { Console.WriteLine("Valor inválido. Digite um número maior que zero."); return; }
            Console.Write("Informe um valor para o lado C do triângulo:");
            if(!float.TryParse(Console.ReadLine(), out float ladoC) || ladoC <= 0f) { Console.WriteLine("Valor inválido. Digite um número maior que zero."); return; }

            Console.WriteLine();

            if (ladoA + ladoB > ladoC && ladoA + ladoC > ladoB && ladoB + ladoC > ladoA)
            {
                if (ladoA == ladoB && ladoA == ladoC )
                {
                    Console.WriteLine("Esse triângulo é Equilátero");
                }
                else if(ladoA == ladoB || ladoA == ladoC || ladoB == ladoC)
                {
                    Console.WriteLine("Esse triângulo é Isósceles");
                }
                else if (ladoA != ladoB && ladoA != ladoC && ladoB != ladoC)
                {
                    Console.WriteLine("Esse triângulo é Escaleno");
                }
            }
            else
            {
                Console.WriteLine("Esses valores não podem formar um Triângulo");
            }
        }
    }
}

