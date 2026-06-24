namespace Par_ou_Ímpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=============================");
            Console.WriteLine("===Números Pares e Ímpares===");
            Console.WriteLine("=============================");
            Console.WriteLine();

            Console.Write("Informe um número inteiro:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if(numero % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            }
            else
            {
                Console.WriteLine("Esse número é ímpar");
            }
        }
    }
}
