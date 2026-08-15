namespace Leitor_Confirmacao
{
    class Progrna
    {
        static void Main(string[] args)
        {
            string resposta = "";

            do 
            {
                Console.Write("Deseja continuar (S/N): ");
                resposta = Console.ReadLine()?.Trim().ToUpper();

                if(resposta != "S" &&  resposta != "N")
                {
                    Console.WriteLine("Opção inválida! Digite apenas S ou N.");
                }
               
            } while (resposta != "N");

            Console.WriteLine("Programa finalizado com sucesso!");

        }
    }
}