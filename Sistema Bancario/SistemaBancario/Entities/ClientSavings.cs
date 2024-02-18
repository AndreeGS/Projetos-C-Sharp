using SistemaBancario.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Entities
{
    internal class ClientSavings : AbstractClient
    {
        public double saldoDaConta { get; set; }
        public DateTime dateOfFirstDeposit { get; set; }

        public ClientSavings(double saldoDaConta, DateTime dateOfFirstDeposit, int idAcount, string holderName, AccountType accountTypeA, ClientType clientType)
            : base ( idAcount,  holderName,  accountTypeA,  clientType)
        {
            this.saldoDaConta = saldoDaConta;
            this.dateOfFirstDeposit = dateOfFirstDeposit;
        }

        public ClientSavings(DateTime dateOfFirstDeposit, int idAcount, string holderName, AccountType accountTypeA, ClientType clientType)
            : base(idAcount, holderName, accountTypeA, clientType)
        {
            this.dateOfFirstDeposit = dateOfFirstDeposit;
        }

        public override string deposito(double valorDeposito)
        {
            saldoDaConta += valorDeposito;
            return gerarRecibo(valorDeposito);
        }

        public override string saque(double valorSaque)
        {
            TimeSpan interval = DateTime.Now - dateOfFirstDeposit;
            double taxa;

            if (interval.TotalDays < 30)
            {
                taxa = 0.25;
            }
            else if (interval.TotalDays < 120)
            {
                taxa = 0.15;
            }
            else
            {
                taxa = 0.6;
            }

            double valorTotal = valorSaque + (valorSaque * taxa);
            saldoDaConta -= valorTotal;
            return gerarRecibo(valorSaque);
        }

        public override string gerarRecibo(double valor)
        {
            DateTime dataOperacao = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Recibo banco de todos");
            sb.AppendLine("Valor da operação: " + valor);
            sb.AppendLine("Data da operação: " + dataOperacao);
            sb.AppendLine("Novo valor disponível: " + saldoDaConta);

            return sb.ToString();
        }


        public override string ToString()
        {
             StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dados da conta: ");
            sb.AppendLine("Nome do Titular: " + holderName);
            sb.AppendLine("Número da conta: " + idAccount);
            sb.AppendLine("Saldo da conta: " + saldoDaConta);

            return sb.ToString() ;
        }
    }
}
