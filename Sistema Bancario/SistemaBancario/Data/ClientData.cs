using SistemaBancario.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.Data
{
    public class ClientData
    {
        List<AbstractClient> clients= new List<AbstractClient>();

        public void CadClient(AbstractClient client)
        {
            clients.Add(client);
        }

        public void VisuClient()
        {
            Console.WriteLine("Clientes cadastrados: ");

            foreach (AbstractClient client in clients)
            {
                Console.WriteLine(client);
            }
        }

        public void ProcurarClient()
        {
            Console.Write("Informe o número da Conta: ");
            int numeroDaConta = int.Parse(Console.ReadLine());

            foreach (AbstractClient client in clients)
            {
                if (client.idAccount == numeroDaConta)
                {
                    Console.WriteLine(client);
                }
            }
        }
    }
}
