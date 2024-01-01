using System;
using System.Collections;

class Lista
{
    private ArrayList lista = new ArrayList();

    public void Adicionar()
    {
        Console.WriteLine("Insira um nome: ");
        string nome = Console.ReadLine();
        lista.Add(nome);
    }

    public void Remover()
    {
        Console.WriteLine("Insira o índice do nome a ser removido: ");
        if (int.TryParse(Console.ReadLine(), out int indice) && indice >= 0 && indice < lista.Count)
        {
            lista.RemoveAt(indice);
        }
        else
        {
            Console.WriteLine("Índice inválido!");
        }
    }

    public void Listar()
    {
        Console.WriteLine("Nomes na lista:");
        foreach (var item in lista)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Lista lista = new Lista();

        while (true)
        {
            Console.WriteLine("Escolha uma ação:");
            Console.WriteLine("1. Adicionar");
            Console.WriteLine("2. Remover");
            Console.WriteLine("3. Listar");
            Console.WriteLine("4. Sair");

            string escolha = Console.ReadLine();

            switch (escolha)
            {
                case "1":
                    lista.Adicionar();
                    break;
                case "2":
                    lista.Remover();
                    break;
                case "3":
                    lista.Listar();
                    break;
                case "4":
                    return; // Sair do programa
                default:
                    Console.WriteLine("Escolha inválida!");
                    break;
            }
        }
    }
}
