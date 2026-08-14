namespace Validacao_de_senha_simples
{
    class Progran
    {
        static void Main(string[] args)
        {
            string senha = "12345";
            string digito = "";

            do
            {
                Console.Write("Informe a sua senha: ");
                 digito = Console.ReadLine();

                if(digito == senha)
                {
                    Console.WriteLine("Acesso liberado!");
                }
                else
                {
                    Console.WriteLine("Sua senha está incorreta! Por favor, tente novamente.");
                    Console.WriteLine();
                }

            } while (digito != senha);


        }
    }
}