namespace Tabuadas
{
    class Progran
    {
        static void Main(string[] args)
        {
            
            Console.Write("Informe um valor para calcular a sua tabuada: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine();

            for (int i = 1; i < 11; ++i)
            {
                int resul = num * i;

                Console.WriteLine($"{num} x {i} = {resul}");
            }
        }
    }
}