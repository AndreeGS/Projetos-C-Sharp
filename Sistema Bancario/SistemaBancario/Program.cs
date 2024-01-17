using System;
using System.Globalization;
using SistemaBancario.View;

namespace Aplicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Seja Bem vindo ao Banco de todos!");


            Menu menu = new Menu();
            menu.exibirMenuDeAcesso();

        }
    }
}