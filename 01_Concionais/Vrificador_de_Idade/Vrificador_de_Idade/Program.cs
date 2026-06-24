using System.Numerics;

namespace Vrificador_de_Idade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados
            Console.Write("Digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine()); //entrada de dados


            if(idade < 18)
            {
                Console.WriteLine("Acesso negado");
            }
            else if(idade >= 18)
            {
                Console.WriteLine("Acesso Permitido");
            }

            //saída de dados
        }
    }
}
