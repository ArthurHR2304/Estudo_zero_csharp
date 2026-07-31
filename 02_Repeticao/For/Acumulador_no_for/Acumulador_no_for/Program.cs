namespace Acumulador_no_for
{
    class Progran
    {
        static void Main(string[] args)
        {
            int i = 0;
            float soma = 0;
            float med = 0;

            for ( i = 0; i < 5; i++)
            {
                Console.Write($"Informe a {i + 1}° nota: ");
                float nota = float.Parse( Console.ReadLine() );
                Console.WriteLine();

                soma += nota;

            }

            med = soma / 5;
            Console.WriteLine($"A média das notas informadas é: {med}");
        }
    }
}
