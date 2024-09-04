using System;
using System.Collections.Generic;
using System.Linq;


public class Progam {
    public static void Main (string [] args){
        
        int selecao = 0;

        List<Produto> dados = new List<Produto>();

        Console.WriteLine("Bem vindo ao Sistema de Supermercado");

        do {
            Console.WriteLine("\nOpções: ");
            Console.WriteLine("- 1 Inserir Produto");
            Console.WriteLine("- 2 Atualizar Produto");
            Console.WriteLine("- 3 Remover Produto");
            Console.WriteLine("- 4 Calcular total");
            Console.WriteLine("- 5 Sair");

            selecao = int.Parse(Console.ReadLine());

            switch(selecao){
                case 1:
                    Console.Write("Insira o nome do Produto: ");
                    string nomeAux = Console.ReadLine();

                    Console.Write("Insira o valor do Produto: ");
                    double valorAux = double.Parse(Console.ReadLine());

                    dados.Add(new Produto(nomeAux, valorAux));

                    Console.WriteLine("Produto adicionado com sucesso!");
                break;
                case 2:
                    string nomePesq = Console.ReadLine();
                    
                break;
                case 3:

                break;
                case 4:

                break;
                case 5:

                break;

                default:
                    Console.WriteLine("Opção inválida!");
                break;
            }
        } while(selecao != 5);
    }
}