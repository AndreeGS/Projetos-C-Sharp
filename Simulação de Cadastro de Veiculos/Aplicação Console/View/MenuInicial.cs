using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicação_Console.View
{
    internal class MenuInicial
    {
        int opcao;
        string email;
        string senha;
        DateTime dataNascimento;
        public void menuIncial()
        {
            Console.WriteLine("Seja bem vindo!");
            Console.WriteLine("1-Faça Login.");
            Console.WriteLine("2-Faça Cadastro.");

            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite seu email: ");
                    email = Console.ReadLine();

                    Console.Write("Digite sua senha: ");
                    senha = Console.ReadLine();
                break;

                case 2:
                    Console.Write("Digite seu email: ");
                    Console.Write("Digite seu nome: ");
                    Console.Write("Digite sua data de nacimento: DD/MM/YYYY");
                    Console.Write("Crie uma senha: ");                
                break;
            }
        }
    }
}
