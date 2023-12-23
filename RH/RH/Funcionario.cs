using Microsoft.VisualBasic;
using RH;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class Funcionario
    {
        public string _nome;
        public double _salario;
        public int _id;

        public List<Funcionario> _lista = new List<Funcionario>();
        DataContext data = new DataContext();

        public Funcionario() { }
        public Funcionario(string nome, double salario, int id)
        {
            _id = id;
            _nome = nome;
            _salario = salario;
        }

        public void Cadastrar(string nome, double salario, int id)
        {
            data.cadastrar(nome, salario, id);
        }

        public string GetSalario(int id)
        {
            try
            {
               Funcionario dado = data.dataResgatarSalario(id);

                if (dado != null)
                {
                    return $"\nSalário do funcionario {dado._nome}: R$ {dado._salario}";
                }
                else
                {
                    return "\nFuncionario não encontrado";
                }
            }
            catch
            {
                return "\nId não existente na base de dados";
            }

        }

        public void aumentarSalario(int id)
        {
            try
            {
                Funcionario dado = data.dataVerificador(id);

                if (dado != null)
                {
                    Console.WriteLine("\nQual o valor do aumento?");
                    double valorAumento = double.Parse(Console.ReadLine());

                    data.dataAumentarSalario(id, valorAumento);

                    Console.WriteLine("\nAumento de salário realizado com sucesso.");
                    Console.WriteLine($"\nInformações do funcionário: {dado._nome}, Salário: R$ {dado._salario}");
                }
                else
                {
                    Console.WriteLine("\nEste Id não existe.");
                }
            }
            catch
            {
                Console.WriteLine("\nOcorreu algum erro.");
            }
        }

        public void reduzirSalario(int id)
        {

            try
            {
                Funcionario dado = data.dataVerificador(id);

                if (dado != null)
                {
                    Console.WriteLine("\nQual o valor da redução?");
                    double valorReducao = double.Parse(Console.ReadLine());

                    data.dataReduzirSalario(id, valorReducao);
                    

                    Console.WriteLine("\nRedução de salário realizada com sucesso.");
                    Console.WriteLine($"Informações do funcionário: {dado._nome}, R$ {dado._salario}");
                }
                else
                {
                    Console.WriteLine("\nEste Id não existe.");
                }
            }
            catch
            {
                Console.WriteLine("\nOcorreu algum erro.");
            }
        }

        public void visualizarFuncionarios()
        {
            data.dataVisualizarFuncionarios();
        }

        public void pesquisarFuncionario()
        {
            Console.WriteLine("Como você deseja pesquisar o funcionário?");
            Console.WriteLine("1-Pelo Id.");
            Console.WriteLine("2-Pelo Nome.");
            int escolha = int.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Digite o número de Id: ");
                    int id = int.Parse(Console.ReadLine());

                    Funcionario dado1 = data.dataPesquisarid(id);

                    if (dado1 != null)
                    {
                        Console.WriteLine($"Usuário encontrado.");
                        Console.WriteLine($"Nome: {dado1._nome}, salário: R$ {dado1._salario}, Id: {dado1._id}");
                    }
                    else
                    {
                        Console.WriteLine("Funcionario não encontrado!");
                    }
                    break;

                case 2:
                    Console.WriteLine("Digite o nome: ");
                    string nome = Console.ReadLine();

                    Funcionario dado2 = data.dataPesquisarNome(nome);

                    if (dado2 != null)
                    {
                        Console.WriteLine($"Usuário encontrado.");
                        Console.WriteLine($"Nome: {dado2._nome}, salário: R$ {dado2._salario}, Id: {dado2._id}");
                    }
                    else
                    {
                        Console.WriteLine("Funcionario não encontrado!");
                    }
                    break;
            }

        }

        public void Ordenar()
        {
            data.dataOrdenar();
            Console.WriteLine("A lista foi ordenada");
        }


        public double CalcularImpostoDeRenda()
        {
            double imposto = 0;
            double Salario = 2;

            if (Salario <= 1903.98)
            {
                imposto = 0;
            }
            else if (Salario <= 2826.65)
            {
                imposto = (Salario - 1903.98) * 0.075;
            }
            else if (Salario <= 3751.05)
            {
                imposto = (Salario - 2826.65) * 0.15;
            }
            else if (Salario <= 4664.68)
            {
                imposto = (Salario - 3751.05) * 0.225;
            }
            else
            {
                imposto = (Salario - 4664.68) * 0.275;
            }

            return imposto;
        }
    }
}




