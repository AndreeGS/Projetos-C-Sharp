using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionarios;

namespace Sistema
{
    internal class Menu
    {
        public void exeMenu()
        {
            int escolha;
            Console.WriteLine("Seja bem vindo ao controle de RH");

            do
            {
                Funcionario func = new Funcionario();

                visMenu();
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        func.Cadastrar();
                    break;
                    case 2:
                        func.GetSalario();
                    break;
                    case 3:
                        func.aumentarSalario(); 
                    break;
                    case 4:
                        func.reduzirSalario();
                    break;
                    case 5:
                        func.visualizarFuncionarios();
                    break;
                    case 6:
                        func.pesquisarFuncionario();
                    break;
                    case 7:
                        func.Ordenar();
                    break;
                      
                }

            } while (escolha != 8);
        }

        private void visMenu()
        {
            Console.WriteLine("\n O que você deseja fazer?");
            Console.WriteLine("1-Cadastrar funcionário.");
            Console.WriteLine("2-Consultar valor do salário.");
            Console.WriteLine("3-Realizar aumento do salário.");
            Console.WriteLine("4-Realizar redução de salário.");
            Console.WriteLine("5-Visualizar todos as informações de todos os funcionários.");
            Console.WriteLine("6-Pesquisar funcionário.");
            Console.WriteLine("7-Ordenar Lista de funcionários.");
            Console.WriteLine("8-Sair.");
        }
    }
}
