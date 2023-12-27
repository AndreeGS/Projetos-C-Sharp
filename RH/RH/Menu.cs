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
        public List<Funcionario> _lista = new List<Funcionario>();

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

                            Funcionario verifica = _lista.Find(x => x._id == newId);

                            if (verifica == null)
                            {
                                _lista.Add(new Funcionario(nome, salario, newId));
                                Console.WriteLine("\nUsuário Cadastrado com sucesso!");

                            }

                            else
                            {
                                Console.WriteLine("\nId já cadastrado!");
                            }
                        }
                        
                        break;

                    case 2:
                        Console.WriteLine("\nPara qual Id você deseja consultar o salário?");
                        int consultaId = int.Parse(Console.ReadLine());

                        Funcionario consultaSalario = _lista.Find(x => x._id == consultaId);

                        if (consultaSalario != null)
                        {                          
                                Console.WriteLine($"\nNome: {consultaSalario._nome}, Salário: {consultaSalario._salario}");                           
                        }

                        else
                        {
                            Console.WriteLine("\nFuncionário não encontrado!");
                        }
                        break;

                    case 3:

                        Console.WriteLine("\nPara qual Id, você deseja realizar o aumento?");
                        int aumentoId = int.Parse(Console.ReadLine());

                        Funcionario aumentoSalario = _lista.Find(x => x._id == aumentoId);

                        if(aumentoSalario != null)
                        {
                            Console.WriteLine("\nQual o valor do aumento?");
                            double valorAumento = double.Parse(Console.ReadLine());

                            aumentoSalario.aumentarSalario(valorAumento);
                            Console.WriteLine("\nSalário aumentado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nUsuário não encontrado!");
                        }
                        break;

                    case 4:
                        Console.WriteLine("\nPara qual Id, você deseja realizar a redução?");
                        int reduzirid = int.Parse(Console.ReadLine());

                        Funcionario reduzirSalario = _lista.Find(x => x._id == reduzirid);

                        if(reduzirSalario != null)
                        {
                            Console.WriteLine("\nQual o valor da redução?");
                            double valorReducao = double.Parse(Console.ReadLine());

                            reduzirSalario.reduzirSalario(valorReducao);
                            Console.WriteLine("\nSalário reduzido com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("\nUsuário não encontrado!");
                        }

                        break;

                    case 5:

                        Console.WriteLine("\nVisualizando funcionários: ");
                        foreach(Funcionario obj in _lista)
                        {
                           Console.WriteLine($"\nFuncionário: {obj._nome}, Salário: {obj._salario}, Id: {obj._id}");
                        }

                        break;

                    case 6:

                        Console.WriteLine("\nComo você deseja pesquisar o funcionário?");
                        Console.WriteLine("1-Pelo Id.");
                        Console.WriteLine("2-Pelo Nome.");
                        int opcao = int.Parse(Console.ReadLine());

                        switch (opcao)
                        {
                            case 1:
                                Console.WriteLine("\nDigite o número de Id: ");
                                int id = int.Parse(Console.ReadLine());

                                Funcionario dado1 = _lista.Find(x =>x._id == id);

                                if (dado1 != null)
                                {
                                    Console.WriteLine($"\nFuncionário encontrado.");
                                    Console.WriteLine($"\nNome: {dado1._nome}, salário: R$ {dado1._salario}, Id: {dado1._id}");
                                }

                                else
                                {
                                    Console.WriteLine("\nFuncionario não encontrado!");
                                }

                            break;

                            case 2:
                                Console.WriteLine("\nDigite o nome: ");
                                string nome = Console.ReadLine();

                                Funcionario dado2 = _lista.Find(x => x._nome == nome);

                                if (dado2 != null)
                                {
                                    Console.WriteLine($"\nUsuário encontrado.");
                                    Console.WriteLine($"\nNome: {dado2._nome}, salário: R$ {dado2._salario}, Id: {dado2._id}");
                                }
                                else
                                {
                                    Console.WriteLine("\nFuncionario não encontrado!");
                                }
                            break;
                        }

                    break;

                    case 7:
                        Console.WriteLine("\nOrdenando Lista...");

                        _lista.Sort();

                        Console.WriteLine("\nA lista foi ordenada!");

                        break;

                    case 8:
                        Console.WriteLine("\nPara qual Id você deseja calcular o Imposto?");
                        int idImposto = int.Parse(Console.ReadLine());

                        Funcionario impostoId = _lista.Find(x => x._id == idImposto);
                        
                        if(impostoId != null)
                        {
                            Console.WriteLine("\nValor do imposto: ");
                            impostoId.CalcularImpostoDeRenda(impostoId._salario);
                        }
                        else
                        {
                            Console.WriteLine("\nFuncionário não encontrado!");
                        }
                    break;

                    default:
                        Console.WriteLine("\nOpção inválida! Por favor, escolha uma opção válida!");
                        break;

                }

            } while (escolha != 9);
        }

        private void visMenu()
        {
            Console.WriteLine("\nO que você deseja fazer?");
            Console.WriteLine("1-Cadastrar funcionário.");
            Console.WriteLine("2-Consultar valor do salário.");
            Console.WriteLine("3-Realizar aumento do salário.");
            Console.WriteLine("4-Realizar redução de salário.");
            Console.WriteLine("5-Visualizar todos as informações de todos os funcionários.");
            Console.WriteLine("6-Pesquisar funcionário.");
            Console.WriteLine("7-Ordenar Lista de funcionários.");
            Console.WriteLine("8-Calcular imposto de renda.");
            Console.WriteLine("9-Sair.");
        }


    }
}