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
            Funcionario funcionario = new Funcionario();

            Console.WriteLine("Seja bem vindo ao controle de RH");

            do
            {
                Funcionario func = new Funcionario();

                visMenu();
                escolha = int.Parse(Console.ReadLine());

                switch (escolha)
                {
                    case 1:
                        Console.WriteLine("\nQual a quantidade de funcionários você deseja cadastrar?");
                        int quantidade = int.Parse(Console.ReadLine());

                        for (int i = 0; i < quantidade; i++)
                        {
                            Console.WriteLine("\nQual o nome do funcionário?");
                            string nome = Console.ReadLine();

                            Console.WriteLine("\nQual o valor do salário?");
                            double salario = double.Parse(Console.ReadLine());

                            Console.WriteLine("\nQual o Id você deseja atribuir?");
                            int newId = int.Parse(Console.ReadLine());

                            funcionario.Cadastrar(nome, salario, newId);

                            Console.WriteLine("Usuário Cadastrado com sucesso!");
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("\nPara qual Id você deseja consultar o salário?");
                        int consultaId = int.Parse(Console.ReadLine());

                        func.GetSalario(consultaId);

                        break;

                    case 3:

                        Console.WriteLine("\nPara qual Id, você deseja realizar o aumento?");
                        int aumentoId = int.Parse(Console.ReadLine());

                        func.aumentarSalario(aumentoId);

                        break;

                    case 4:
                        Console.WriteLine("\nPara qual Id, você deseja realizar a redução?");
                        int reduzirid = int.Parse(Console.ReadLine());
                        
                        func.reduzirSalario(reduzirid);
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