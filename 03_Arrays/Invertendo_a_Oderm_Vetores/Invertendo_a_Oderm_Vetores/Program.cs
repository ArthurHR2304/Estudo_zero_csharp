namespace Invertendo_a_Ordem_Vetores
{
    class Progran
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Informe um valor para a posição {i}°: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            Console.WriteLine("Posição inversa dos valores digitados:");

            for (int i = numeros.Length - 1; i >= 0;i--)
            {
                Console.WriteLine(numeros[i]);
            }
        }
    }
}