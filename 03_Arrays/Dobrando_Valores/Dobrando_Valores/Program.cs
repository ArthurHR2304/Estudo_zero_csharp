namespace Dobrando_Valores 
{
    class Progran
    {
        static void Main(string[] args)
        {
            int[] ArrayA = new int[5];
            int[] ArrayB = new int[5];

            for (int i = 0; i < ArrayA.Length; i++)
            {
                Console.Write($"Preencha o vetor com o {i + 1}º valor: ");
                ArrayA[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();


            for (int i = 0; i < ArrayB.Length; i++)
            { 
               ArrayB[i] = ArrayA[i] * 2;

                Console.WriteLine($"Vetor A: {ArrayA[i]}  |  Vetor B (Dobro): {ArrayB[i]}");
            }
        }
    }
}