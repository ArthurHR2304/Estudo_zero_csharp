namespace Repetidor_obrigadorio
{
    class Progran
    {
        static void Main(string[] args)
        {
            float numero = 0;
            do
            {
                Console.Write("Informe qualquer valor positivo: ");
                if (float.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero <= 0)
                    {
                        Console.WriteLine("Atenção: o número precisa ser maior que zero!");
                    }
                }
                else
                {
                   
                    Console.WriteLine("Valor inválido, por favor difite novamente");
                }
            } while (numero <= 0);

            Console.WriteLine("Valor posistivo detectado!");
        }
    }
}