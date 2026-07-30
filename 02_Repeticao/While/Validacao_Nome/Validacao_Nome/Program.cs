namespace Validacao_Nome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome = "";

            while (nome.Length < 3)
            {
                
                Console.Write("Infome um nome: ");
                nome = Console.ReadLine();
                

                if(nome.Length >= 3)
                {
                    Console.WriteLine($"Isso mesmo, o nome {nome} contém mais de três letras");
                }
                else
                {
                    Console.WriteLine("Nome inválido, por favor escreva novamente!");
                    Console.WriteLine();
                }
                
            }
        }
    }
}
