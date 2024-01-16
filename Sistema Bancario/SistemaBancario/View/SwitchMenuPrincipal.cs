using System;
using SistemaBancario.View;
using SistemaBancario.Entities.Client;

namespace SistemaBancario.View
{
    internal class SwitchMenuPrincipal
    {
        public void switchMenuPrincipal()
        {
            int conta;
            string nome;
            int valor;

            int escolha = Convert.ToInt32(Console.ReadLine());


            switch (escolha)
            {
                case 1:
                    Console.WriteLine("\nVamos coletar algumas infromações:");
                    Console.WriteLine("Você deseja realizar um depósito inicial no ato do cadastro?  Sim(1) ou Não(2)");
                    int deposito = Convert.ToInt32(Console.ReadLine());



                    if (deposito == 1)
                    {

                        Console.WriteLine("\nDigite o numero da sua conta: ");
                        conta = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nDigite o nome do titular: ");
                        nome = Console.ReadLine();

                        Console.WriteLine("\nDigite o valor inicial a ser depositado: ");
                        valor = Convert.ToInt32(Console.ReadLine());

                        Client cliente = new Client(conta, nome, valor);

                    }
                    else if (deposito == 2)
                    {
                        Console.WriteLine("\nDigite o numero da sua conta: ");
                        conta = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("\nDigite o nome do titular: ");
                        nome = Console.ReadLine();

                        Client cliente = new Client();

                    }

                    else
                    {
                        Console.WriteLine("\nOpção inválida. Digite 1 para sim ou 0 para não.");
                    }

                    break;

                case 2:
                    Console.WriteLine("\nInsira o número da Conta: ");
                    conta = Convert.ToInt32(Console.ReadLine());

                    Client dados = new Client();
                    

                    break;

                case 3:
                    Console.WriteLine("\nDigite o número da sua conta: ");
                    conta = Convert.ToInt32(Console.ReadLine());

                    Client saldo = new Client();

                    Console.WriteLine("\nQual valor você deseja sacar?");
                    int valorSacar = Convert.ToInt32(Console.ReadLine());


                    break;

                case 4:
                    Console.WriteLine("\nDigite o número da sua conta: ");
                    conta = Convert.ToInt32(Console.ReadLine());

                    Client depo = new Client();

                    Console.WriteLine("\nDigite o valor a depositar: ");
                    int valorDepositar = Convert.ToInt32(Console.ReadLine());

                    break;

                default:
                    Console.WriteLine("Seleção inválida");
                    break;
            }

        }
    }
}
