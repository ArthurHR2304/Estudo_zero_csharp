namespace Soma_um_a_cinco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 5;
            int contador = 1;
            int soma = 0;

            while (contador <= valor)
            {
                soma = contador + soma;
                Console.WriteLine($"Somando o número {contador}. Total acumulado até agora: {soma}");
                contador++;
                Console.WriteLine();
            }
            
            Console.WriteLine($"A soma de todos os valores é: {soma}");
        }
    }
}
