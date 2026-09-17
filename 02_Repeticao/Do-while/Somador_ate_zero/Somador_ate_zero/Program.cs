using System.Globalization;

namespace Somador_ate_zero
{
    class Progran
    {
        static void Main(string[] args)
        {
            int numero = -1;
            int soma = 0;

            do
            {
                Console.Write("Informe um valor inteiro ou digite 0 para encerrar : ");
                if(int.TryParse(Console.ReadLine(), out numero ))
                {
                    if (numero < 0)
                    {
                        Console.WriteLine("Por favor, digite um número inteiro acima de 0.");
                    }
                    else
                    {
                        soma += numero;
                    }  
                }
                else
                {
                    Console.WriteLine("Por favor, digite um número inteiro válido.");
                    numero = -1; // Força a variável a NÃO ser 0 para o loop continuar!
                }

            } while (numero != 0);

            Console.WriteLine($"A soma de todos os valores é de: {soma}");
        }
    }
}