namespace Validador_de_nota_esoclar
{
    class Progran
    {
        static void Main(string[] arga)
        {
            float nota = -1;

            do
            {
                Console.Write("Informe a sua nota: ");
                if(float.TryParse(Console.ReadLine(), out nota))
                {
                    if(nota < 0 || nota > 10)
                    {
                        Console.WriteLine("Nota inválida! A nota deve ser entre 0 e 10");
                    }


                }
            } while (nota < 0 || nota > 10);

            Console.WriteLine($"Nota {nota} cadastrada com sucesso!");
        }
    }
}