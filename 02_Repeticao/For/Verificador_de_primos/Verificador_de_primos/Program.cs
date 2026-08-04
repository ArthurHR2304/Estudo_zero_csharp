namespace Verificador_de_primos
{
    class Progran
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor inteiro: ");
            int num = int.Parse(Console.ReadLine());

            int contdiv = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0) 
                {
                    contdiv++;
                }
            }

            if (contdiv == 2)
            {
                Console.WriteLine($"O número {num} é primo!");
            }
            else
            {
                Console.WriteLine($"O número {num} não é primo! (Ele tem {contdiv} divisores)");
            }
        }
    }
}
