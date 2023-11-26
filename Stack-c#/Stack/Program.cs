using System;
using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        Stack Pilha = new Stack();
        int selecao;

        Console.WriteLine("O que você deseja fazer?");

        do
        {
            Console.WriteLine("\n1-Inserir novos elementos?");
            Console.WriteLine("2-Remover último elemento?");
            Console.WriteLine("3-Visualizar elementos?");
            Console.WriteLine("4-Sair?");

            selecao = Convert.ToInt32(Console.ReadLine());

            switch (selecao)
            {
                case 1:
                    Console.WriteLine("\nQuantos elementos você quer inserir?");
                    int qtd = Convert.ToInt32(Console.ReadLine());

                    for (int i = 1; i < qtd; i++)
                    {
                        Console.WriteLine("\nInsira o {0} elemento: ", i);
                        Pilha.Push(Console.ReadLine());
                    }
                    break;

                case 2:
                    Console.WriteLine("\nRemovendo último elemento...");
                    Pilha.Pop();
                    break;

                case 3:
                    Console.WriteLine("\nVisualizando elementos: ");

                    foreach (var item in Pilha)
                    {
                        Console.WriteLine(item);
                    }
                    break;

                default:
                    Console.WriteLine("\nOpção inválida.");
                    break;
            }

        } while (selecao != 4);
    }
}
