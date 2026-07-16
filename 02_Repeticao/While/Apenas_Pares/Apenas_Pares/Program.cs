namespace Apenas_Pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pares = 2;

            while(pares <= 20)
            {
                Console.WriteLine($"Números pares: {pares}");

                pares += 2;
            }
        }
    }
}
