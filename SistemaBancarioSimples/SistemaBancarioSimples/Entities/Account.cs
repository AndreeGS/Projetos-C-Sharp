using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancarioSimples.Entities
{
    internal class Account
    {
        public int numberAccount {  get; set; }
        public string holderPrime { get; set; }
        public double balanceHolder { get; set; }
        public double withDrawLimit { get; set; }

        public Account() { }
        public Account (int number, string holder, double balance, double withDrawLimit)
        {
            this.numberAccount = number;
            this.holderPrime = holder;
            this.balanceHolder = balance;
            this.withDrawLimit = withDrawLimit;
            
        }

        public void withdraw(double amount)
        {
            if (withDrawLimit < amount)
            {
                throw new SystemException("Limite de saque atingido!");
            }

            if (amount > balanceHolder)
            {
                throw new SystemException("Not enough balance");
            }

            balanceHolder -= amount;

        }

        public void deposit(double amount)
        {
            balanceHolder += amount;
        }
    }
}
