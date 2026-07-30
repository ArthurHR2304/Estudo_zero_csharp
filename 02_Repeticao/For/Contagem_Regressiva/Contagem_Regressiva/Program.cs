
namespace Contagem_Regressiva
{
    class Program 
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Lançamento em {i}");
                System.Threading.Thread.Sleep(1000);
            }

            Console.WriteLine();
            Console.WriteLine("Fogo! 🚀 Foguete lançado!");
        } 
    }
}