namespace Contando_impar_par
{
    class Progran 
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int quantidadeImpares = 0;
            int somaImpares = 0;

            for (int i = 1; i <= num; ++i)
            {
                if (i % 2 != 0)
                {
                    quantidadeImpares ++;
                    somaImpares += i;
                }
            }

            Console.WriteLine($"Quantidade de números ímpares de 1 até {num}: {quantidadeImpares}");
            Console.WriteLine($"Soma de todos os ímpares encontrados: {somaImpares}");

        }
    }

}
