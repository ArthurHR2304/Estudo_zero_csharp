using System.Net.Http.Headers;

namespace Somador_Infinito
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float media = 0;
            float soma = 0;
            float nota = 0;
            int contador = 0;

            while (nota >= 0)
            {
                Console.Write("Digite as notas do aluno(a): ");
                nota = int.Parse(Console.ReadLine());

                if(nota >= 0)
                {
                    soma += nota;
                    contador++;

                }
                Console.WriteLine();
            }
            if(contador > 0)
            {
                media = soma / contador;
                Console.WriteLine($"O valor total das notas é: {soma}");
                Console.WriteLine($"A média das notas é : {media}");
            }
            else
            {
                Console.WriteLine("Nenhuma nota foi digitada");
            }
        }
    }
}
