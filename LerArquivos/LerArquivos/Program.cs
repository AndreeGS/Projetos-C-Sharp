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
            string gpaPath = @"C:\te\arquivoGPA.txt";
            string piPath = @"C:\te\arquivoPI.txt";
            string novoPath = @"C:\te\arquivoNOVO.txt";

            try
            {

                List<string> gpaRegistros = File.ReadAllLines(gpaPath).ToList();

                List<string> piRegistros = File.ReadAllLines(piPath).ToList();

                List<string> repetidos = new List<string>();

                List<string> exclusivosGPA = new List<string>();

                List<string> exclusivosPI = new List<string>();


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
                foreach (string repetido in repetidos)
                {
                    Console.WriteLine(repetido);
                }

                using (StreamWriter sw = new StreamWriter(novoPath))
                {
                    sw.WriteLine("Documentos da GPA");
                    foreach(string gpa in gpaRegistros)
                    {
                        sw.WriteLine(gpa);
                    }
                    sw.WriteLine("\nValores de PI:");
                    foreach (string pi in piRegistros)
                    {
                        sw.WriteLine(pi);
                    }

                    sw.WriteLine("\nValores Repetidos:");
                    foreach (string repetido in repetidos)
                    {
                        sw.WriteLine(repetido);
                    }

                    sw.WriteLine("\nValores Exclusivos de GPA:");
                    foreach (string exclusivoGPA in exclusivosGPA)
                    {
                        sw.WriteLine(exclusivoGPA);
                    }

                    sw.WriteLine("\nValores Exclusivos de PI:");
                    foreach (string exclusivoPI in exclusivosPI)
                    {
                        sw.WriteLine(exclusivoPI);
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
