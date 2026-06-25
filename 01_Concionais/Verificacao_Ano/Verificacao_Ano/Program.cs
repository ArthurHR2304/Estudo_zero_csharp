using System;

namespace Verificacao_Ano_Idade 
{
     class Program
    {
        static void Main (string[] args)
        {
            Console.SetCursorPosition(0, 0);
            string DiaInicial = DateTime.Now.ToString("dd/MM/yyyy");
            string HorarioInicial = DateTime.Now.ToString("HH:mm:ss");
            Console.WriteLine("=========================================");
            Console.WriteLine($"Data e hora atuais: {DiaInicial} | {HorarioInicial}");
            Console.WriteLine("=========================================");
            Console.WriteLine();


            //Ecercício começa aqui
            Console.Write("Informe a sua data de nascimento, use formato dd/mm/aaaa:");
            string datanascimento = Console.ReadLine();


           if (DateTime.TryParse(datanascimento, out DateTime dataconvertida))
            {
                DateTime AnoAtual = DateTime.Now; // pega a data atual
                int idade = AnoAtual.Year - dataconvertida.Year; //subtrai o ano e a data de nascimento

                if((AnoAtual.Month < dataconvertida.Month) || (AnoAtual.Month == dataconvertida.Month && AnoAtual.Day < dataconvertida.Day)) // verifica se a pessoa já fez aniversârio ou não
                {
                    idade--; 
                    Console.WriteLine($"Você tem {idade}");
                }
                else 
                {
                    Console.WriteLine($"Você tem {idade}");
                }
            }
        }
    }
}

