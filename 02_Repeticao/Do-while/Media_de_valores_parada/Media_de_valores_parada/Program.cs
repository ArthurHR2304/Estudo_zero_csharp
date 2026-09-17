using System.Xml;

namespace Media_de_valores_parada
{
    class Progran
    {
        static void Main(string[] args)
        {
            float nota = 0;
            int contador = 0;
            float soma = 0;
            
            do
            {
                Console.Write($"Informe o valor da {contador + 1}º nota ou digite um valor negativo para finalizar a soma: ");
                if(float.TryParse(Console.ReadLine(), out nota))
                {
                    if(nota >= 0)
                    {
                        soma += nota;
                        contador++;
                    }
                    else
                    {
                        Console.WriteLine("Encerrando sistema");
                    }
                }
            } while (nota >= 0);

            float media = 0;

            if (contador > 0)
            {
                media = soma / contador;
            }

            Console.WriteLine();
            Console.WriteLine($"A méida das notas iunformadas é: {media}");
            Console.WriteLine($"A quantidade de notas digitadas foi: {contador}");
        }
    }
}