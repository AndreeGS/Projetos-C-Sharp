using SistemaBancario.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entities
{
    public abstract class AbstractClient
    {
        public int idAccount { get; set; }
        public string holderName { get; set; }

        public AccountType accountType { get; set; }

        public ClientType clientType { get; set; }

       public AbstractClient(int idAcount, string holderName, AccountType accountTypeA, ClientType clientType)
        {
            this.idAccount = idAcount;
            this.holderName = holderName;
            this.accountType = accountTypeA;
            this.clientType = clientType;
        }

        public abstract string saque(double valorSaque);
        public abstract string deposito(double valorDeposito);

        public abstract string gerarRecibo(double valor);

        


    }
}
