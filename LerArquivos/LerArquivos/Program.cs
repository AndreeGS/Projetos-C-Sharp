using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LerArquivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string gpaPath = @"C:\te\GPA.csv";
            string piPath = @"C:\te\PI.csv";
            string novoPath = @"C:\te\add.csv";

            try
            {

                List<string> gpaRegistros = File.ReadAllLines(gpaPath).ToList();

                List<string> piRegistros = File.ReadAllLines(piPath).ToList();

                List<string> repetidos = new List<string>();

                List<string> exclusivosGPA = new List<string>();

                List<string> exclusivosPI = new List<string>();

                List<string> Definitiva = new List<string>();


                foreach (string pi in piRegistros)
                {
                    Console.WriteLine("Documentos pi: " + pi);

                    if (gpaRegistros.Contains(pi))
                    {
                        repetidos.Add(pi);
                    }
                    else
                    {
                        exclusivosPI.Add(pi);
                    }
                }

                Console.WriteLine();

                foreach (string gpa in gpaRegistros)
                {
                    Console.WriteLine("Documentos gpa: " + gpa);

                    if (!piRegistros.Contains(gpa))
                    {
                        exclusivosGPA.Add(gpa);
                    }
                }

                Console.WriteLine();

                

                Definitiva.Add("\nValores Repetidos:");
                Definitiva.AddRange(repetidos);

                Definitiva.Add("\nValores Exclusivos de GPA:");
                Definitiva.AddRange(exclusivosGPA);

                Definitiva.Add("\nValores Exclusivos de PI:");
                Definitiva.AddRange(exclusivosPI);


                foreach (string dado in Definitiva)
                {
                    Console.WriteLine(dado);
                }

                using (StreamWriter sw = new StreamWriter(novoPath))
                {
                    foreach (string linha in Definitiva)
                    {
                        sw.WriteLine(linha);
                    }
                }


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
