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
                    Console.WriteLine("Qual o Produto você quer atualizar?");
                    string produtoPesq = Console.ReadLine();
                    
                    Produto produtoEncontrado = dados.FirstOrDefault(x => x.nome == produtoPesq);

                    if(produtoEncontrado != null){

                        Console.WriteLine("Produto Selecionado: ");
                        Console.WriteLine($"Nome: {produtoEncontrado.nome}, Valor: R$ {produtoEncontrado.valor}");
                        
                        Console.Write("\nDigite o novo nome do Produto: ");
                        string novoNome = Console.ReadLine();

                        Console.Write("\nDigite o novo valor do Produto: ");
                        double novoValor = double.Parse(Console.ReadLine());

                        try{
                            produtoEncontrado.nome = novoNome;
                            produtoEncontrado.valor = novoValor;

                            Console.WriteLine("Produto atualizado com Sucesso!");

                        } catch(Exception ex){                           
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                    } else {
                        Console.WriteLine("Produto não encontrado!");
                    }

                break;
                case 3:
                    Console.WriteLine("Qual o Produto você quer Remover?");
                    string produtoDelete = Console.ReadLine();
                    
                    Produto produtoToDelete = dados.FirstOrDefault(x => x.nome == produtoDelete);

                    if (produtoDelete != null){
                        try{
                            dados.Remove(produtoToDelete);
                            Console.WriteLine("Produto removido com sucesso!");

                        } catch(Exception ex){
                            Console.WriteLine(ex.Message);
                            throw;
                        }
                    } else{
                        Console.WriteLine("Produto não encontrado!");
                    }

                break;
                case 4:
                    Console.WriteLine("\nValor total: ");

                    double valorTotal = 0;               

                    for(int i = 0; i < dados.Count; i++){
                        valorTotal += dados[i].valor;
                    }

                    Console.WriteLine(valorTotal.ToString("F2"));

                break;
                case 5:
                    Console.WriteLine("\nSaindo do Programa...");
                break;

                default:
                    Console.WriteLine("Opção inválida!");
                break;
            }
        } while(selecao != 5);
    }
}