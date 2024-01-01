using System;
using System.Collections;

class Aluno
{
    public static void Main(string[] args)
    {
        ArrayList Lista = new ArrayList();
        int opcao;

        Console.WriteLine("Para iniciar, vamos adicionar alguns alunos...");
        Console.WriteLine("\nQuantos alunos você quer adicionar?");
        int qtd = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < qtd; i++)
        {
            Console.WriteLine($"\nInsira o {i + 1}º nome: ");
            Lista.Add(Console.ReadLine());
        };

        do
        {
            Console.WriteLine("\nO que você deseja fazer?\n ");
            Console.WriteLine("1 - Remover aluno?");
            Console.WriteLine("2 - Listar alunos?");
            Console.WriteLine("3 - Pesquisar na Lista de alunos?");
            Console.WriteLine("4 - Ordenar a lista de alunos?");
            Console.WriteLine("5 - Sair do programa?");
            Console.WriteLine("6 - Adicionar alunos");
            Console.WriteLine("");

            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("\nQual nome do aluno você deseja remover?");
                    string nomeRemover = Console.ReadLine();
                    Lista.Remove(nomeRemover);

                    Console.WriteLine("\nRemovendo Aluno...");
                    break;
                case 2:
                    Console.WriteLine("\nVisualizando Alunos:");
                    foreach (var item in Lista)
                    {
                        Console.WriteLine(item);
                    };
                    break;
                case 3:
                    Console.WriteLine("\nQual o nome do aluno?");
                    string nomePesquisar = Console.ReadLine();
                    foreach (object aluno in Lista)
                    {
                        if (string.Equals(aluno.ToString(), nomePesquisar, StringComparison.OrdinalIgnoreCase))
                        {
                            Console.WriteLine($"Achamos o aluno: {aluno}");
                            break; 
                        }
                    }
                    break;
                case 4:
                    Lista.Sort();
                    Console.WriteLine("\nA lista foi ordenada!");
                    break;
                case 5:
                    Console.WriteLine("Fim!");
                    break;
                case 6:
                    Console.WriteLine("\nQuantos alunos você quer adicionar?");
                    int valor = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < valor; i++)
                    {
                        Console.WriteLine($"\nInsira o {i + 1}º nome: ");
                        Lista.Add(Console.ReadLine());
                    }
                    break;
                default:
                    Console.WriteLine("\nOpção inválida!");
                    break;
            }
        } while (opcao != 5);
    }
}
