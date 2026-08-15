using System.Globalization;

namespace Validador_texto_vazio
{
    class Progran
    {
        static void Main(string[] args)
        {
            string nomeUser = "";

            do
            {
                Console.Write("Informe o seu nome de usuário: ");
                nomeUser = Console.ReadLine()?.Trim(); //O trim retira os espaços em branco digitados pelo usuário

                if (string.IsNullOrWhiteSpace(nomeUser))
                {
                    Console.WriteLine("O nome de usuário não pode ficar em branco!");
                }
            } while (string.IsNullOrWhiteSpace(nomeUser));

            Console.WriteLine($"Seja bem-vindo {nomeUser}");
        }
    }
}
