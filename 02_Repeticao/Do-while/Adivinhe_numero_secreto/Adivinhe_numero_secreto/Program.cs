namespace Adivinhe_nummero_secreto
{
    class Progran
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 100000); 
            int chute = 0;

            do
            {
                Console.Write("Informe um valor entre (1 e 100000) para achar o número secreto: ");
                if (int.TryParse(Console.ReadLine(), out chute)) 
                {
                    if(chute != num1)
                    {
                        Console.WriteLine("Errou, tente novamente!");
                    }
                }
                else
                {
                    Console.WriteLine("Esse valor é inválido, tente novamente!");
                }

                    if (chute < num1)
                    {
                        Console.WriteLine("O valor digitado é inferior ao número secreto");
                    Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("O valor digitado é superior ao número secreto");
                        Console.WriteLine();
                    }

            } while (chute != num1);

            Console.WriteLine("Parabéns!! Você acertou o núemro secreto!");

        }
    }
}