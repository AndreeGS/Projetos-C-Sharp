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
        CheckingAccount = 1,
        [Description("Conta Poupança")]
        SavingsAccount = 2,
        [Description("Conta Salário")]
        SalaryAccount = 3,
        [Description("Conta de Investimento")]
        InvestmentAccount = 4
    }
}
