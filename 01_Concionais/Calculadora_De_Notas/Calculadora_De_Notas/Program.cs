using System;

namespace Calculadora_De_Notas 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {

            // Lembre de utilizar virgula para separar os decimais, exemplo: 7,5
            Console.WriteLine("=========================");
            Console.WriteLine("===Calculadora de Nota===");
            Console.WriteLine("=========================");

            Console.Write("Informe a 1° nota do aluno(a): ");
            decimal nota1 = decimal.Parse(Console.ReadLine() ?? "0"); // O ?? operador de coalescência nula (??) é usado para fornecer um valor padrão caso Console.ReadLine() retorne null. Nesse caso, se o usuário não digitar nada e pressionar Enter, a nota será considerada como 0.

            Console.Write("Informe a 2° nota do aluno(a): ");
            decimal nota2 = decimal.Parse(Console.ReadLine() ?? "0");

            decimal media = (nota1 + nota2) / 2;
            decimal mediaArredondada = Math.Round(media, 2); // O método Math.Round() é usado para arredondar a média para duas casas decimais, garantindo que o resultado seja apresentado de forma mais legível.

            Console.WriteLine($"A media do aluno(a) é {mediaArredondada}");

        }
    }
}