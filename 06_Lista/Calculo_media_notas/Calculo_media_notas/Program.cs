using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;

namespace Claculo_media_notas
{
    class Progran
    {
        static void Main(string[] args)
        {

            string repitaAluno = "S";

            do
            {
                List<double> notas = new List<double>();
                string CadastrarNovaNota = "S";

                do
                {
                    Console.Clear();
                    Console.Write("Digite a nota do aluno (0 a 10): ");
                    double nota;

                    while (!double.TryParse(Console.ReadLine(), out nota) || nota < 0.0 || nota > 10.0)
                    {
                        Console.WriteLine("Tente novamente.");
                        Console.Write("Entrada inválida. Digite um número válido para a nota:");
                        
                    }
                        notas.Add(nota);
                        Console.WriteLine($"-> Nota {nota:F1} cadastrada com sucesso!");
                    
                    CadastrarNovaNota = ""; 
                    while (CadastrarNovaNota != "S" && CadastrarNovaNota != "N") 
                    {
                        Console.Write("Deseja cadastrar uma nova nota? (S/N): ");
                        CadastrarNovaNota = Console.ReadLine()?.Trim().ToUpper();

                        if (CadastrarNovaNota != "S" && CadastrarNovaNota != "N")
                        {
                            Console.WriteLine("Opção inválida! Digite apenas 'S' para Sim ou 'N' para Não.\n");
                        }
                    }
                    Console.WriteLine();


                } while (CadastrarNovaNota == "S");

                // 2. EXIBIÇÃO E CÁLCULO DOS RESULTADOS
                Console.Clear();
                Console.WriteLine("=== RESUMO DO ALUNO ===");

                foreach (double n in notas)
                {
                    Console.WriteLine($"Nota: {n:F1}");
                }

                double media = notas.Average();
                double maior = notas.Max();
                double menor = notas.Min();

                Console.WriteLine("-----------------------");
                Console.WriteLine($"Total de notas: {notas.Count}");
                Console.WriteLine($"Maior nota: {maior:F1}");
                Console.WriteLine($"Menor nota: {menor:F1}");
                Console.WriteLine($"Média Final: {media:F2}");

                if(media >= 7.0)
                {
                    Console.WriteLine("Aprovado!");
                }
                else if(media >= 5.0)
                {
                    Console.WriteLine("Recuoeração!");
                }
                else
                {
                    Console.WriteLine("Reprovado!");
                }

                repitaAluno = "";

                while (repitaAluno != "S" && repitaAluno != "N")
                {
                    Console.Write("\nDeseja calcular a média de outro aluno? (S/N): ");
                    repitaAluno = Console.ReadLine()?.Trim().ToUpper();

                    if (repitaAluno != "S" && repitaAluno != "N")
                    {
                        Console.WriteLine("Opção inválida! Digite 'S' para Sim ou 'N' para Não.");
                    }
                }


            } while (repitaAluno == "S");
        }
    }
}