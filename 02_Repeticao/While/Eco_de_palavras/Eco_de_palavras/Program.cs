namespace Eco_de_palavras
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fim = "parar";

            Console.Write("Digite qualquer palavra: ");
            string palavra = Console.ReadLine();

            while(palavra != fim)
            {
                Console.WriteLine(palavra);

                Console.Write("Digite outra palavra: ");
                palavra = Console.ReadLine();
                Console.WriteLine();
            }

            Console.WriteLine("Você saiu do sistema. Parabéns!!");

        }

    }
}
