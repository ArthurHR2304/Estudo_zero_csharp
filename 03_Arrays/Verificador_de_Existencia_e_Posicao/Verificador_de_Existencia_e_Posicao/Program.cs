using System.Reflection.Metadata;

namespace Verificaror_de_Existencia_e_Posicao 
{
    class Progran 
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[8];

            for (int i = 0; i < numeros.Length; ++i)
            {
                Console.Write($"Informe o {i + 1}º valor: ");
                numeros[i] = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine();

            Console.Write("Informe o valor que deseja achar: ");
            int indice = int.Parse(Console.ReadLine());

            int achado = 0;
            bool result = false;

            for (int j = 0; j < numeros.Length; ++j)
            {
                if (numeros[j] == indice)
                {
                    achado = j;
                    result = true;
                    break;
                }
            }

            if (result == true)
            {
                Console.WriteLine($"O número desejado foi encontrado na posição: {achado + 1}");
            }
            else
            {
               Console.WriteLine ("O valor não foi encontrado!"); 
            }
            
        }
           
    }
}
    