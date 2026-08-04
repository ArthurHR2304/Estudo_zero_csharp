namespace Primeiro_desafio_Array
{
    class Progran
    {
        static void Main(string[] args)
        {
            int[] posicoes = new int[4];

            for (int i = 0; i < posicoes.Length; i++) 
            {
                Console.Write($"Informe o {i + 1}º valor para o Array: ");
                posicoes[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0;i < posicoes.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Os valor referente ao array {i + 1} é o {posicoes[i]}");
            }

        }
    }
}