using System;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.X86;

namespace Simulador_de_Impostos 
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("===Calculando Impostos===");
            Console.WriteLine("=========================");
            Console.WriteLine();

            Console.Write("Informe o seu salário bruto : ");
            double salarioBruto = double.Parse(Console.ReadLine());

            double imposto = 0;
            double salarioLiq;

            if (salarioBruto <= 2000) 
            {
                imposto = 0;
            }
            else if (salarioBruto <= 4000)
            {
                imposto = (salarioBruto * 0.10);
            }
            else
            {
                imposto = (salarioBruto * 0.20);
            }

            salarioLiq = salarioBruto - imposto;


            Console.WriteLine($"O valor a ser recebido é de {salarioLiq.ToString("0.00")} ");
        }
    }
}


