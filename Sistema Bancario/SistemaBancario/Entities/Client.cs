using SistemaBancario.Entities.Enums;
using System;
using System.Collections;

namespace SistemaBancario.Entities.Clients
{
    public class Client
    {
        public int _numeroDaConta { get; set; }
        public string _nomeDoTitular { get; set; }
        public int _saldoDaConta { get; set; }

        public AccountType _accountType { get; set; }
        public ClientType _clientType { get; set; }

        public Client() { }
        public Client(int numeroDaConta, string nomeDoTitular, int saldoDaConta)
        {
            _numeroDaConta = numeroDaConta;
            _nomeDoTitular = nomeDoTitular;
            _saldoDaConta = saldoDaConta;
        }
    }
}