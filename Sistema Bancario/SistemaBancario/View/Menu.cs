using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBancario.View
{
    internal class Menu
    {
        public void exibirMenuPrincipal()
        {
            Console.WriteLine("\nQual operação você deseja fazer? ");
            Console.WriteLine("1 - Cadastrar Cliente");
            Console.WriteLine("2 - Visualizar informações");
            Console.WriteLine("3 - Realizar saque");
            Console.WriteLine("4 - Realizar depósito");
            Console.WriteLine("5 - Sair");
            Console.WriteLine();

            SwitchMenuPrincipal switchMenuPrincipal = new SwitchMenuPrincipal();
            switchMenuPrincipal.switchMenuPrincipal();
        }

        public void exibirMenuDeAcesso()
        {
            Console.WriteLine("1 - Criar Conta");
            Console.WriteLine("2 - Acessar Conta");

            SwitchMenuDeAcesso switchMenuDeAcesso = new SwitchMenuDeAcesso();
            switchMenuDeAcesso.switchMenuDeAcesso();
        }
    }
}
