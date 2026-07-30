using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Fatorial_Simples
{
    class Progran 
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int resultado = 1;

            Console.Write("Informe um valor para calcular o fatorial: ");
            int num = int.Parse(Console.ReadLine());

            while(contador <= num)
            {
                resultado *= contador;
                contador++;
            }

            Console.WriteLine($"O fatorial de {num} é {resultado}");
        }
    }

}

