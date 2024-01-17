using SistemaBancario.Entities.Clients;

namespace SistemaBancario.Entities
{
    public class CompannyClient : Client
    {
        public double cnpj {  get; set; } 
        public CompannyClient() { }

        public CompannyClient(int numeroDaConta, string nomeDoTitular, int saldoDaConta, double cnpj) : base(numeroDaConta, nomeDoTitular, saldoDaConta)      
        {
            this.cnpj = cnpj;
        }
    }
}
