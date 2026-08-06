namespace Separando_Pares_Impares
{
    class Progran
    {
        static void Main(string[] args)
        {
            int[] posi = new int[6];

            for (int i = 0; i < posi.Length; i++)
            {
                Console.Write($"Preencha o {i}º valor: ");
                posi[i] = int.Parse(Console.ReadLine());
            }

            int pares = 0;
            int impar = 0;

            for (int i = 0; i < posi.Length; i++)
            {
                if (posi[i] % 2 == 0)
                {
                    pares++;
                }
                else
                {
                    impar++;
                }
            }

            Console.WriteLine($"Estes são os valores pares digitados: {pares}");
            Console.WriteLine($"Estes são os valores ímpares digitados: {impar}");

        }
    }
}
