using SistemaBancario.Entities;
using SistemaBancario.Entities.Clients;
using SistemaBancario.Entities.Enums;
using System;
using System.Globalization;
using System.Security.Principal;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {

            List<AbstractClient> clients = new List<AbstractClient>();
            int escolha;

            do
            {
                Console.Write("Cadastro de Cliente");
                Console.WriteLine("Qual tipo de conta você deseja cadastrar? ");
                Console.WriteLine("1 - Conta corrente");
                Console.WriteLine("2 - Conta poupança");
                Console.WriteLine("3 - Visualizar clientes");

                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        AccountType accountChecking = AccountType.CheckingAccount;
                        int idAccountChecking = Program.gerarNumeroConta();
                        DateTime dateCheckingDep = DateTime.Now;



                        Console.WriteLine("Informe os dados do cliente:");
                        Console.Write("Nome: ");
                        string nameChecking = Console.ReadLine();

                        Console.WriteLine("Informe o tipo de cliente:");
                        Console.WriteLine("1-Conta individual \n2-Conta empresarial");

                        ClientType typeChecking = (ClientType)Enum.Parse(typeof(ClientType), Console.ReadLine());

                        Console.WriteLine("Você deseja fazer um depósito inicial? 1-Sim, 2-Não");
                        int depChecking = int.Parse(Console.ReadLine());

                        if (depChecking == 1)
                        {
                            Console.WriteLine("Informe o valor a ser depositado: ");
                            double valorDepositado = double.Parse(Console.ReadLine());


                            clients.Add(new ClientCurrent(idAccountChecking, nameChecking, accountChecking, typeChecking, valorDepositado, dateCheckingDep));
                        }
                        else
                        {

                            clients.Add(new ClientCurrent(idAccountChecking, nameChecking, accountChecking, typeChecking));
                        }
                        break;

                    case 2:
                        AccountType accountSavings = AccountType.SavingsAccount;
                        int idAccountSaving = Program.gerarNumeroConta();
                        DateTime dateSavingDep = DateTime.Now;



                        Console.WriteLine("Informe os dados do cliente:");
                        Console.Write("Nome: ");
                        string nameSaving = Console.ReadLine();

                        Console.WriteLine("Informe o tipo de cliente:");
                        Console.WriteLine("1-Conta individual \n2-Conta empresarial");

                        ClientType typeSaving = (ClientType)Enum.Parse(typeof(ClientType), Console.ReadLine());

                        Console.WriteLine("Você deseja fazer um depósito inicial? 1-Sim, 2-Não");
                        int dep = int.Parse(Console.ReadLine());

                        if (dep == 1)
                        {
                            Console.WriteLine("Informe o valor a ser depositado: ");
                            double valorDepositado = double.Parse(Console.ReadLine());


                            clients.Add(new ClientSavings(valorDepositado, dateSavingDep, idAccountSaving, nameSaving, accountSavings, typeSaving));
                        }
                        else
                        {

                            clients.Add(new ClientSavings(dateSavingDep, idAccountSaving, nameSaving, accountSavings, typeSaving));
                        }
                        break;
                    case 3:
                        Console.WriteLine("Clientes cadastrados: ");
                        foreach (AbstractClient clien in clients)
                        {
                            Console.WriteLine(clien);
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }              
            } while (escolha != 4);
        }

        public static int gerarNumeroConta()
        {
            Random rand = new Random();

            return rand.Next(10, 100);

        }
    }
}