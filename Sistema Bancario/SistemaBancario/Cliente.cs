using System;
using System.Collections;

namespace Client
{
    public class Cliente
    {
        private static Hashtable dados = new Hashtable();

        private int _conta { get; set; }
        private string _nome { get; set; }
        private int _valor { get; set; }


        public Cliente (int conta)
        {
            _conta = conta;
        }

        public Cliente(int conta, string nome )
        {
            _conta = conta;
            _nome = nome;
        }

        public Cliente(int conta, string nome, int valorInicial)
        {
            _conta = conta;
            _nome = nome;
            _valor = valorInicial;
        }



        public void Deposito(int conta, int valor)
        {
            if (dados.ContainsKey(conta))
            {
                ClienteInfo clienteInfo = dados[conta] as ClienteInfo;

                if (clienteInfo != null)
                {
                    clienteInfo._valor += valor;

                    Console.WriteLine($"\nSaldo atual: {clienteInfo._valor}");
                }
            }

            else
            {
                Console.WriteLine("\nConta não existente!");
            }
        }

        public void saque(int conta, int saque)
        {
            if (dados.ContainsKey(conta))
            {
                ClienteInfo clienteInfo = dados[conta] as ClienteInfo;

                if (clienteInfo != null)
                {
                    clienteInfo._valor -= (saque + 5);

                    Console.WriteLine($"\nSaldo atual: {clienteInfo._valor}");
                    Console.WriteLine ($"Valor sacado na última transação: {saque}");

                }

            }
            else
            {
                Console.WriteLine("\nConta não existente!");
            }
        }

        public void SalvarDados()
        {
            ClienteInfo client = new ClienteInfo(_conta, _nome, _valor);
            dados.Add(_conta, client);
            Console.WriteLine("\n A conta foi cadastrada!");

        }
        public void BuscarDados(int conta)
        {
            if (dados.ContainsKey(conta))
            {
                ClienteInfo clienteInfo = dados[conta] as ClienteInfo;

                if (clienteInfo != null)
                {
                    Console.WriteLine("\nSeus dados: ");

                    Console.WriteLine($"\nNome: {clienteInfo._nome}, Conta: {clienteInfo._conta}, Saldo: {clienteInfo._valor}");
                }
                else
                {
                    Console.WriteLine("\nDado não encontrado.");
                }
            }
            else
            {
                Console.WriteLine("\nConta não encontrada.");
            }
        }
    }

    internal class ClienteInfo
    {
        public int _conta {  get; set; }
        public string _nome { get; set;}
        public int _valor { get; set; }

        public ClienteInfo(int conta, string nome, int valor)
        {
            _conta = conta;
            _nome = nome;
            _valor = valor;
        }
    }

}