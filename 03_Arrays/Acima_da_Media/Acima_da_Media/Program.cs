namespace Acima_da_Media
{
    class Progran
    {
        static void Main(string[] args)
        {
            float[] notas = new float[6];
            float acumulador = 0;
            float recebe = 0;

            for (int i = 0; i < notas.Length; ++i)

            {   // Use virgula ao invés de ponto
                Console.Write($"Informe o valor da {i + 1}º nota:");
                if(float.TryParse(Console.ReadLine(), out recebe))
                {
                    notas[i] = recebe;
                    acumulador += recebe;
                    Console.WriteLine($"Nota cadastrada com sucesso: {recebe}");
                    Console.WriteLine();
                }
                else
                {
                    // Deu errado! O usuário digitou texto ou algo inválido.
                    Console.WriteLine("Valor inválido! Digite apenas números.");
                }

                
            }

            float med = acumulador / notas.Length;
            int alunosAcimaMedia = 0;

            for(int i = 0; i <notas.Length; ++i)
            {
                if (notas[i] >= med)
                {
                    alunosAcimaMedia++;
                }
            }

            Console.WriteLine();
            Console.Write($"A média da turma foi {med} | e a quantidade de alunos acima da média é de: {alunosAcimaMedia}");

        }
    }
}