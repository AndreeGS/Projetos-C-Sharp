using Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RH
{
    internal class DataContext
    {
        
        public List<Funcionario> _lista = new List<Funcionario>();

        public DataContext() { }
        
        public void cadastrar(string nome, double salario, int id)
        {
            Funcionario funcionario = new Funcionario(nome, salario, id);
            _lista.Add(funcionario);
        }

        public Funcionario dataResgatarSalario(int id)
        {
            Funcionario funcionario = new Funcionario ();

            var dado = _lista.Find(x => x._id == id);


            return dado;
        }

        public Funcionario dataVerificador(int Id)
        {
            Funcionario dado = _lista.Find(x => x._id == Id);

            return dado;
        }

        public void dataAumentarSalario(int id, double valorAumento)
        {
            Funcionario dado = _lista.Find(x => x._id == id);

            dado._salario += valorAumento;
        }

        public void dataReduzirSalario(int id, double valorRedução)
        {
            Funcionario dado = _lista.Find(x => x._id == id);

            dado._salario -= valorRedução;
        }

        public void dataVisualizarFuncionarios()
        {
            Console.WriteLine("\nVisualizando a lista de funcionários: ");
            Console.WriteLine();

            foreach (var dado in _lista)
            {
                Console.WriteLine($"Nome: {dado._nome}, Salário: R$ {dado._salario}, Id: {dado._id}.");
            }
        }

        public Funcionario dataPesquisarid(int id)
        {
            Funcionario dado = _lista.Find(x => x._id == id);

            return dado;
        }

        public Funcionario dataPesquisarNome(string nome)
        {
            Funcionario dado = _lista.Find(x => x._nome == nome);

            return dado;
        }

        public void dataOrdenar()
        {
            _lista.Sort();
        }
    }
}
