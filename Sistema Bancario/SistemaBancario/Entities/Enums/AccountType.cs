using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entities.Enums
{
    public enum AccountType
    {
        [Description("Conta Corrente")]
        CheckingAccount,
        [Description("Conta Poupança")]
        SavingsAccount,
        [Description("Conta Salário")]
        SalaryAccount,
        [Description("Conta de Investimento")]
        InvestmentAccount
    }
}
