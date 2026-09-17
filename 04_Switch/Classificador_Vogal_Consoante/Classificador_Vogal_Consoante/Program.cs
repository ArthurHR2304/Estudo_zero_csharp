namespace Classificador_Vogal_Consoante
{
    class Progran
    {
        static void Main(string[] args)
        {
            char letra = 'a';
            string continua = "S";

            do
            {
                Console.Clear();

                Console.Write("Digite uma  letra e verifique se ela é uma vogal ou consoante:");
                letra = Console.ReadKey().KeyChar;
                Console.ReadLine();
                Console.WriteLine();

                char minuscula = char.ToLower(letra);

                if (char.IsLetter(minuscula))
                {
                    switch (minuscula)
                    {
                        case 'a':
                        case 'e':
                        case 'i':
                        case 'o':
                        case 'u':
                            Console.WriteLine("A letra digitada é uma vogal!");
                            break;

                        default:
                            Console.WriteLine("A letra digitada é uma consoante!");
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("O caractere digitado não é uma letra!");
                }

           
                Console.WriteLine();
                Console.Write("Deseja tentar outra letra (S/N) ?");
                continua = Console.ReadLine()?.Trim().ToUpper();

            } while (continua == "S");

            if (continua == "N")
            {
                Console.WriteLine("Finalizando Sistema!");
            }
        }
    }        
}
