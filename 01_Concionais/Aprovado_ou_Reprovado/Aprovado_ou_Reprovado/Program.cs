using System;
using System.Xml;

namespace Aprovado_ou_Reprovado 
{
    internal class Program 
    {
        static void Main(string[] args) 
        {

            Console.WriteLine("===================");
            Console.WriteLine("==Validando notas==");
            Console.WriteLine("===================");
            Console.WriteLine("");

            Console.Write("Informe uma nota de 0 a 10:");
            decimal nota = Convert.ToDecimal(Console.ReadLine());

            if(nota > 10)
            {
                Console.WriteLine("Nota inválida. Por favor, informe uma nota de 0 a 10.");
            }
            else if(nota >= 6)
            {
                Console.Write("Aprovado");
            }
            else
            {
                Console.Write("Reprovado");
            }
        }
    }
}
