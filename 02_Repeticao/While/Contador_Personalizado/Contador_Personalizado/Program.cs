namespace Contador_Personalizado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe um valor inteiro: ");
            int valor = int.Parse(Console.ReadLine());

            int contador = 1;
            
            while (contador <= valor)
            {
                Console.WriteLine($"A contagem dos números é: {contador}");
                contador++;
            }
        }
    }
}
