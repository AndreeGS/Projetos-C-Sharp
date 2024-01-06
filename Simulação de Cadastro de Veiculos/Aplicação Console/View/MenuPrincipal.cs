using Aplicação_Console.Entities;
using System.Collections;
using System;

namespace Aplicação_Console.View
{
    public class MenuPrincipal
    {
        int opcao;

        public void exeMenu()
        {
            Console.WriteLine("Seja bem vindo ao cadastro de veiculos!");

            do
            {
                visMenuPrincipal();

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("\nÉ uma moto (1) ou um carro (2)? ");
                        int tipoVeiculo = Convert.ToInt32(Console.ReadLine());

                        if (tipoVeiculo == 1)
                        {
                            Console.WriteLine("\nQuantas motos você quer adicionar? ");
                            int qtdMoto = Convert.ToInt32(Console.ReadLine());


                            for (int i = 0; i < qtdMoto; i++)
                            {

                                Console.WriteLine($"\nInsira as informações da moto {i + 1}:");
                                Console.Write("Modelo: ");
                                string modeloMoto = Console.ReadLine();

                                Console.Write("\nMarca: ");
                                string marcaMoto = Console.ReadLine();

                                Console.Write("\nAno de Fabricação: ");
                                int anoFabricacaoMoto = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\nTipo de moto: ");
                                string tipoMoto = Console.ReadLine();

                         

                                Moto novaMoto = new Moto(modeloMoto, marcaMoto, anoFabricacaoMoto, tipoMoto);
                            }
                        }

                        else if (tipoVeiculo == 2)
                        {
                            Console.WriteLine("\nQuantos carros você quer adicionar? ");
                            int qtdCarro = Convert.ToInt32(Console.ReadLine());


                            for (int i = 0; i < qtdCarro; i++)
                            {


                                Console.WriteLine("\nInsira as informações do carro:");
                                Console.Write("Modelo: ");
                                string modeloCarro = Console.ReadLine();

                                Console.Write("Marca: ");
                                string marcaCarro = Console.ReadLine();

                                Console.Write("Ano de Fabricação: ");
                                int anoFabricacaoCarro = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Numero de portas: ");
                                int numeroPortas = Convert.ToInt32(Console.ReadLine());

                                

                                Carro novoCarro = new Carro(modeloCarro, marcaCarro, anoFabricacaoCarro, numeroPortas);
                            }
                        }

                        else
                        {
                            Console.WriteLine("\nOpção inválida!");
                        }
                        break;

                    case 1:

                        

                        break;

                    case 2:

                    
                        break;

                    case 3:
                       

                        break;

                    case 4:
                       

                        break;

                    case 5:
                        

                        break;

                    case 6:
                        

                        break;

                    default:
                        if (opcao != 7)
                        {
                            Console.WriteLine("Opção inválida!");
                        }
                        break;
                }

            } while (opcao != 7);
        }
        public void visMenuPrincipal()
        {
            Console.WriteLine("\nO que você deseja fazer?");
            Console.WriteLine("0 - Adicionar um veículo");
            Console.WriteLine("1 - Ligar carro");
            Console.WriteLine("2 - Abrir portas");
            Console.WriteLine("3 - Visualizar informações do carro");
            Console.WriteLine("4 - Ligar moto");
            Console.WriteLine("5 - Empinar moto");
            Console.WriteLine("6 - Visualizar informações da moto");
            Console.WriteLine("7 - Sair");
        }
    }
}
