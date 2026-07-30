namespace Contador_cliques 
{
class Progran
    {
        static void Main(string[] args)
        {
            string entrada = "";
            int clique = 0;

            while(entrada != "sair")
            {
                Console.Write("Pressione Enter várias vezes. Ou escreva (sair) para finalizar: ");
                entrada = Console.ReadLine();

                if (entrada != "sair")
                {
                    clique++;
                }
            }

            Console.WriteLine($"Número de cliques realizados: {clique}");
        }
    }
}

