namespace Media_Simples
{
    class Progran 
    {
        static void Main(string[] args)
        {
            int contador = 0;
            float med = 0;
            int div = 5;
            float soma = 0;

            while (contador < 5)
            {
                Console.Write($"Informe a {contador + 1}° nota: ");
                float nota = float.Parse(Console.ReadLine());
                Console.WriteLine();

                soma += nota;
                contador++; 
            }

            med = soma / 5;
            Console.WriteLine($"A soma total dos valores é: {soma}");
            Console.WriteLine($"A média das notas é: {med}");

            
        }
    }
}
