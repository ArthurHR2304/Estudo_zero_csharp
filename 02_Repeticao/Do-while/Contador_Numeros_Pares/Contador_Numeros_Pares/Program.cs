using System.ComponentModel;

namespace Contador_Numeros_Pares
{
    class Progran
    {
        static void Main(string[] argsa)
        {
            int numero = -1;
            int pares = 0;
            int impares = 0;

            do
            {
                Console.WriteLine("Digite um número inteiro (ou 0 para sair): ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if(numero != 0)
                    {
                        if (numero % 2 == 0)
                        {
                            pares++;
                        }
                        else
                        {
                            impares++;
                        }
                    }
                }
                else
                {
                    numero = -1;
                    Console.WriteLine("Valor inválido!");
                }

            } while (numero != 0);

            Console.WriteLine($"Você digitou {pares} números pares.");
            Console.WriteLine($"Você digitou {impares} números ímpares.");
        }
    }
}