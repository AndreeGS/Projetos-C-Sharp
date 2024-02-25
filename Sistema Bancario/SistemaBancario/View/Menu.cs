using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.View
{
    public struct Menu
    {
        public void exibirMenu()
        {
            Console.Write("Cadastro de Cliente");
            Console.WriteLine("Qual tipo de conta você deseja cadastrar? ");
            Console.WriteLine("1 - Conta corrente");
            Console.WriteLine("2 - Conta poupança");
            Console.WriteLine("3 - Visualizar clientes");
            Console.WriteLine("4 - Procurar cliente pelo Id");
        }
    }
}
