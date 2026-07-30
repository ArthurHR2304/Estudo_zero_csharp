namespace Adivinhe_Numero_Fixo 
{
    class Progran 
    {
        static void Main(string[] args)
        {
            int dado = 0;
            Random aleatorio = new Random();
            int sorte = aleatorio.Next(1,10001);

            while (sorte != dado)
            {
                Console.Write("Digite um número de 1 a 10.000 para adivinhar o certo: ");
                dado = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (dado != sorte)
                {
                    Console.WriteLine("Ops, número errado! Por favor, tente novamente!");

                    if (dado > sorte)
                    {
                        Console.WriteLine("O valor digitado é maior do que o número secreto");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("O valor digitado é menor do que o número secreto");
                        Console.WriteLine();
                    }
                }
            }

            Console.WriteLine($"Parabéns!! O número da sorte é {sorte}");
        }
    }
}

