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
              
                string [] gpaRegistros = File.ReadAllLines(gpaPath);
                string [] piRegistros = File.ReadAllLines(piPath);
                List<string> repetidos = new List<string>();


                foreach (string gpa in gpaRegistros)
                {
                    Console.WriteLine("Documentos gpa: " + gpa);
                }

                Console.WriteLine();

                foreach (string pi in piRegistros)
                {
                    Console.WriteLine("Documentos pi: " +  pi);

                    if (gpaRegistros.Contains(pi))
                    {
                        repetidos.Add(pi);
                    }
                }

                Console.WriteLine();
                foreach (string repetido in repetidos)
                {
                    Console.WriteLine(repetido);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
