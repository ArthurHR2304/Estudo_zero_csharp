namespace Encontrar_Maior_Valor_Posicao
{
    class Progran
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[6];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write($"Informe o {i + 1}° valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
            }

            int maior = numeros[0];
            int posiMaior = 0;
         
            for (int i = 0; i < numeros.Length; i++) 
            {
                if (numeros[i] > maior)
                {
                    maior = numeros[i];
                    posiMaior = i;
                } 
            }

            Console.WriteLine($"O maior valor encontrado no Array é: {maior}");
            Console.WriteLine($"E a sua posição é a {posiMaior + 1}");
        }
    }
}