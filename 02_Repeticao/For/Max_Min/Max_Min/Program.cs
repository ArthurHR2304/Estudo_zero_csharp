namespace Max_Min
{
    class Progran 
    {
        static void Main(string[] args)
        {
            int maior = 0;
            int menor = 0;
            int num = 0;

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Informe 5 valores inteiros: ");
                 num = int.Parse(Console.ReadLine());

                if (i == 1 )
                {
                    maior = num;
                    menor = num;
                }
                else
                {
                    if (num > maior)
                    {
                        maior = num;
                    }
                    if(num < menor)
                    {
                        menor = num;
                    }
                }
            }

            Console.WriteLine($"\nO maior valor digitado foi: {maior}");
            Console.WriteLine($"O menor valor digitado foi: {menor}");
        }
    }
}
