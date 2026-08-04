namespace Soma_Media_com_Vetores
{
    class Progran
    {
        static void Main(string[] args)
        {
            float[] notas = new float[5];
            float soma = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                Console.Write($"Informe o valor da {i + 1}º nota: ");
                notas[i] = float.Parse(Console.ReadLine());
            }
            for (int i = 0; i < notas.Length; i++) 
            {
                 soma += notas[i];
            }

            float med = soma / notas.Length ;

            Console.WriteLine($"A média total do aluno é: {med}");
        }
    }
}