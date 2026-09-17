namespace Contagem_regressiva
{
    class Progran
    {
        static void Main(string[] args)
        {
            int numero = 0;
            bool entrada = false;
            

            do
            {
                Console.Write("Informe um valor inteiro: ");

                if (int.TryParse(Console.ReadLine(), out numero) && numero >= 0) //Tenta converter e já checa se é maior ou igual a zero
                {
                    entrada = true;  
                }
                else
                {
                    Console.WriteLine("Esse valor está inválido! Digite novamente.\n");
                }
            } while (!entrada);

            Console.WriteLine();

            do
            {
               
                Console.WriteLine($"A redução de valores é: {numero}");
                numero--;

            } while (numero >= 0);

            Console.WriteLine("Fogo!");
        }
    }
}