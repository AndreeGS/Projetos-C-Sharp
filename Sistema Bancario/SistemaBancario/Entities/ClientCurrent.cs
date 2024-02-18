using SistemaBancario.Entities.Enums;
using System;
using System.Collections;
using System.Text;

namespace SistemaBancario.Entities.Clients
{
    public class ClientCurrent : AbstractClient
    {
        public double? saldoDaConta { get; set; }

        public DateTime dateOfFirstDeposit { get; set; }

        public ClientCurrent(int idAcount, string holderName, AccountType accountTypeA, ClientType clientType, double saldoDaConta, DateTime dateOfFirsDeposit)
            : base(idAcount, holderName, accountTypeA, clientType)
        {
            this.saldoDaConta = saldoDaConta;
            this.dateOfFirstDeposit = dateOfFirsDeposit;
        }

        public ClientCurrent(int idAcount, string holderName, AccountType accountTypeA, ClientType clientType)
            : base(idAcount, holderName, accountTypeA, clientType)
        {
            this.saldoDaConta = saldoDaConta;
        }



        public override string deposito(double valorDeposito)
        {
            saldoDaConta -= valorDeposito;

            return gerarRecibo(valorDeposito);
        }

        public override string saque(double valorSaque)
        {
            saldoDaConta -= (valorSaque + 5);

            return gerarRecibo(valorSaque);
        }
        public override string gerarRecibo(double valor)
        {
            DateTime dataOperacao = DateTime.Now;
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Recibo banco de todos");
            sb.AppendLine("Valor da operação: " + valor);
            sb.AppendLine("Data da operação: " + dataOperacao);
            sb.AppendLine("Novo valor disponivel: " + saldoDaConta);

            return sb.ToString();

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Dados da conta: ");
            sb.AppendLine("Nome do Titular: " + holderName);
            sb.AppendLine("Número da conta: " + idAccount);
            sb.AppendLine("Saldo da conta: " + saldoDaConta);

            return sb.ToString();
        }
    }
}


