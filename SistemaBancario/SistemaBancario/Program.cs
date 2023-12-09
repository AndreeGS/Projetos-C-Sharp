using Client;
using System;
using System.Globalization;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int conta;
            string nome;
            int valor;

            int escolha;
            Console.WriteLine("Seja Bem vindo ao Banco de todos!");

            do
            {
                Console.WriteLine("\nQual operação você deseja fazer? ");
                Console.WriteLine("1 - Cadastrar Cliente");
                Console.WriteLine("2 - Visualizar informações");
                Console.WriteLine("3 - Realizar saque");
                Console.WriteLine("4 - Realizar depósito");
                Console.WriteLine("5 - Sair");
                Console.WriteLine();

                escolha = Convert.ToInt32(Console.ReadLine());

                if (escolha == 1 || escolha == 2 || escolha == 3 || escolha == 4 || escolha == 5)
                {

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

                                Cliente cliente = new Cliente(conta, nome, valor);
                                cliente.SalvarDados();

                            }
                            else if (deposito == 2)
                            {
                                Console.WriteLine("\nDigite o numero da sua conta: ");
                                conta = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("\nDigite o nome do titular: ");
                                nome = Console.ReadLine();

                                Cliente cliente = new Cliente(conta, nome);
                                cliente.SalvarDados();

                            }

                            else
                            {
                                Console.WriteLine("\nOpção inválida. Digite 1 para sim ou 0 para não.");
                            }

                            break;

                        case 2:
                            Console.WriteLine("\nInsira o número da Conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());

                            Cliente dados = new Cliente(conta);
                            dados.BuscarDados(conta);

                            break;

                        case 3:
                            Console.WriteLine("\nDigite o número da sua conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());

                            Cliente saldo = new Cliente(conta);

                            Console.WriteLine("\nQual valor você deseja sacar?");
                            int valorSacar = Convert.ToInt32(Console.ReadLine());

                            saldo.saque(conta, valorSacar);

                            break;

                        case 4:
                            Console.WriteLine("\nDigite o número da sua conta: ");
                            conta = Convert.ToInt32(Console.ReadLine());

                            Cliente depo = new Cliente(conta);

                            Console.WriteLine("\nDigite o valor a depositar: ");
                            int valorDepositar = Convert.ToInt32(Console.ReadLine());

                            depo.Deposito(conta, valorDepositar);
                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida");
                }

            } while (escolha != 5);
        }
    }
}