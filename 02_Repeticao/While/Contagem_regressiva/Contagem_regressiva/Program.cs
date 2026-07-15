using System;

namespace Contagem_regressiva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int temporizador = 10;

            while (temporizador != 0 )
            {
               
                Console.WriteLine($"Cronômetro: {temporizador}");
                temporizador--;
            }

            Console.WriteLine("Bommmm!!");
        }
    }
}
