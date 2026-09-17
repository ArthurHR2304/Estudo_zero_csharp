namespace Dobrando_ate_passar_100 
{
    class Progran
    {
        static void Main(string[] args)
        {
            int numero = 0;

            Console.Write("Informe um valor inteiro: ");
            if (int.TryParse(Console.ReadLine(), out numero))
            {
                do
                {
                    numero *= 2;
                    Console.WriteLine($"Valor Atual:{numero} ");

                } while (numero <= 100);
            }
            else
            {
                Console.WriteLine("Por favor, digite um número válido!");
            }

        }
    }
}
