namespace Soma_Dois_Valores
{
    class Progran
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[5];
            int[] vetor2 = new int[5];
            

            for(int i = 0;i < vetor1.Length; ++i)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                vetor1[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }
           
            Console.WriteLine("Informe mais 5 valores!");
            Console.WriteLine();

            for (int i = 0; i < vetor2.Length; ++i)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                vetor2[i] = int.Parse(Console.ReadLine());
                Console.WriteLine();
            }

            int[] somaVetores = new int[5];
            int somaTotal = 0;

            for (int i = 0; i < somaVetores.Length; ++i) 
            {
                somaVetores[i] = vetor1[i] + vetor2[i];
                somaTotal += somaVetores[i];
                Console.WriteLine($"Vetor 1: {vetor1[i]}  |  Vetor 2: {vetor2[i]} | Resultado: {somaVetores[i]} | Soma de todos valores digitados: {somaTotal}");
            }

            



        }
    }
}