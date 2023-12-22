using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Funcionarios
{
    internal class Funcionario
    {
        private string _nome;
        private double _salario;
        private int _id;

        List<Funcionario> _lista = new List<Funcionario>();

        public Funcionario() { }
        public Funcionario(string nome, double salario, int id)
        {
            _id = id;
            _nome = nome;
            _salario = salario;
        }

        public string Cadastrar()
        {
            Console.WriteLine("Qual a quantidade de funcionários você deseja cadastrar?");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.WriteLine("Qual o nome do funcionário?");
                string nome = Console.ReadLine();

                Console.WriteLine("Qual o valor do salário?");
                double salario = double.Parse(Console.ReadLine());

                Console.WriteLine("Qual o Id você deseja atribuir?");
                int id = int.Parse(Console.ReadLine());

                Funcionario funcionario = new Funcionario(nome, salario, id);

                _lista.Add(funcionario);
            }

            return "\nFuncionário Cadastrado com sucesso.";
        }

        public string GetSalario()
        {
            Console.WriteLine("\nPara qual Id você deseja consultar o salário?");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Funcionario dado = _lista.Find(x => x._id == id);

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
                return "\nOcorreu algum erro.";
            }

        }

        public void aumentarSalario()
        {
            Console.WriteLine("\nPara qual Id, você deseja realizar o aumento?");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Funcionario dado = _lista.Find(x => x._id == id);

                if (dado != null)
                {
                    Console.WriteLine("\nQual o valor do aumento?");
                    double valorAumento = double.Parse(Console.ReadLine());

                    dado._salario += valorAumento;

                    Console.WriteLine("\nAumento de salário realizado com sucesso.");
                    Console.WriteLine($"Informações do funcionário: {dado._nome}, Salário: R$ {dado._salario}");
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

        public void reduzirSalario()
        {
            Console.WriteLine("\nPara qual Id, você deseja realizar a redução?");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Funcionario dado = _lista.Find(x => x._id == id);

                if (dado != null)
                {
                    Console.WriteLine("\nQual o valor da redução?");
                    double valorReducao = double.Parse(Console.ReadLine());

                    dado._salario -= valorReducao;

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
            foreach (var dado in _lista)
            {
                Console.WriteLine($"Nome: {dado._nome}, Salário: R$ {dado._salario}, Id: {dado._id}.");
            }
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

                    Funcionario dado1 = _lista.Find(x => x._id == id);

                    Console.WriteLine($"Usuário encontrado.");
                    Console.WriteLine($"Nome: {dado1._nome}, salário: R$ {dado1._salario}, Id: {dado1._id}");
                    break;

                case 2:
                    Console.WriteLine("Digite o nome: ");
                    string nome = Console.ReadLine();

                    Funcionario dado2 = _lista.Find(x => x._nome == nome);

                    Console.WriteLine($"Usuário encontrado.");
                    Console.WriteLine($"Nome: {dado2._nome}, salário: R$ {dado2._salario}, Id: {dado2._id}");
                    break;
            }

        }

        public void Ordenar()
        {
            _lista.Sort();

            foreach (var dado in _lista)
            {
                Console.WriteLine($"Nome: {dado._nome}, Salário: R$ {dado._salario}, Id: {dado._id}.");
            }
        }
    }
}




