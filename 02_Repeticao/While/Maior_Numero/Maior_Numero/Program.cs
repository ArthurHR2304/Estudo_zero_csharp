namespace Maior_Numero
{
     class Progran
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int maior = int.MinValue;

            while(contador < 5)
            {
                Console.Write($"Digite o {contador + 1}° número: ");
                int num = int .Parse( Console.ReadLine() );

                if (num > maior)
                {
                    maior = num;
                }

                contador++;
            }

            Console.WriteLine($"O maior valor digitado foi: {maior}");
        }
    }
}