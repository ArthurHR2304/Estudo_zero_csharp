namespace Sequncia_Fibonacci
{
    class Progran
    {
        static void Main(string[] args)
        {
            int a = 1;
            int b = 0;

            Console.Write("Informe com um número inteiro quantos termos da sequências de Fibonacci você deseja executar: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                int proximo = a + b;
                a = b;
                b = proximo;

                Console.WriteLine($"Valores da Sequência {a}");
            }

        }

    }
}
