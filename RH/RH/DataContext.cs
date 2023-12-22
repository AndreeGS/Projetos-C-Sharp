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

        private string _nomeData;
        private int _idData;
        private double _salarioData;

        public DataContext() { }
        public DataContext(string nome, double salario, int id) 
        {
            _nomeData = nome;
            _idData = id;
            _salarioData = salario;
        }

        public void cadastrar(string nome, double salario, int id)
        {
            Funcionario funcionario = new Funcionario(nome, salario, id);
            _lista.Add(funcionario);
        }

        public Funcionario consulta(int id)
        {
            Funcionario dado = _lista.Find(x => x._id);

            return dado;
        }

        public void aumentoSalario()
        {

        }
    }
}
