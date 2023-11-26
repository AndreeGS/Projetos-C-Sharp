using System;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        // Criar uma fila (Queue) de exemplo
        Queue Fila = new Queue();

        Console.WriteLine("O que você deseja fazer?");
        int selecao;

        do
        {
            Console.WriteLine("\n1-Inserir mais elementos?");
            Console.WriteLine("2-Remover o primeiro Elemento?");
            Console.WriteLine("3-Visualizar elementos?");
            Console.WriteLine("4-Sair?");
            Console.WriteLine("");

            selecao = Convert.ToInt32(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.WriteLine("\nQuantos elementos você quer adicionar? ");
                    int qtd = Convert.ToInt32(Console.ReadLine());

                    for (int i = 0; i < qtd; i++)
                    {
                        Console.WriteLine("\nInsira o {0}", i + 1);
                        Fila.Enqueue(Console.ReadLine());
                    }
                    break;

                case 2:
                    Console.WriteLine("\nRemovendo primeiro elemento...");
                    Fila.Dequeue();
                    break;

                case 3:
                    Console.WriteLine("\nVisualizando elementos: ");
                    foreach (var item in Fila)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                case 4:
                    Console.WriteLine("\nSaindo do programa.");
                    break;

                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }

        } while (selecao != 4);
    }
}
